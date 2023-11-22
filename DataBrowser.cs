using DAABOM.Properties;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace DAABOM
{
    public partial class DataBrowser : Form
    {
        private readonly ReadWriter RW = new();
        private Dictionary<string, ProjectMetadata> projects = new();
        private Project? loadedProject;
        private Component? loadedComponent;
        private TreeNode? loadedComponentTreeNode;
        private int loadedComponentImageIndex;

        internal enum DescriptorType
        {
            TopLevel,
            RevisionLevel,
            BOM
        }

        public DataBrowser(bool isConnected)
        {
            InitializeComponent();
            UpdateConnectionIcon(isConnected);
            RepopulateProjectList();
        }

        [GeneratedRegex(@"(?<=\()(\d+)(?=\))")]
        private static partial Regex duplicateProjectNameIndexRegex();

        private void UpdateConnectionIcon(bool isConnected)
        {
            serverToolStripStatusLabel.Image =
                isConnected ? Resources.network_drive_world_1 : Resources.network_drive_unavailable_1;

            string workingBucketName = Program.workingBucket is not null ?
                Program.workingBucket.Name : "Error! Null Bucket!";

            serverToolStripStatusLabel.ToolTipText =
                isConnected ? $"Connected to {Program.connectedServer} bucket \"{workingBucketName}\"" :
                "Local mode";
        }

        internal void RepopulateProjectList()
        {
            string currentProject = projectListToolStripComboBox.Text;

            projects.Clear();
            projectListToolStripComboBox.Items.Clear();

            foreach (ProjectMetadata project in RW.ListProjects())
            {
                string projectName = project.Name;

                while (projects.ContainsKey(projectName)) // consider: save the index for duplicates separately. if someone makes a project literally called "xyz (1)" then making another "xyz (1)" should result in "xyz (1) (1)" not "xyz (2)"!
                {
                    if (duplicateProjectNameIndexRegex().IsMatch(projectName))
                    {
                        projectName = duplicateProjectNameIndexRegex().Replace(projectName,
                            m => (Convert.ToUInt32(m.Groups[^1].Value) + 1).ToString());
                    }

                    else
                    {
                        projectName += " (1)";
                    }
                }

                projects.Add(projectName, project);
                projectListToolStripComboBox.Items.Add(projectName);
            }

            projectListToolStripComboBox.SelectedItem =
                projectListToolStripComboBox.Items.Contains(currentProject) ? currentProject : null;
        }

        private void RepopulateProjectHierarchy()
        {
            TreeNode projectNode = projectTreeView.Nodes[0];
            TreeNodeCollection assembliesFolder = projectNode.Nodes[0].Nodes;
            TreeNodeCollection partsFolder = projectNode.Nodes[1].Nodes;
            TreeNodeCollection materialsFolder = projectNode.Nodes[2].Nodes;
            TreeNodeCollection otherFolder = projectNode.Nodes[3].Nodes;

            projectNode.Text = "? (No Project)";
            assembliesFolder.Clear();
            partsFolder.Clear();
            materialsFolder.Clear();
            otherFolder.Clear();

            if (loadedProject is not null)
            {
                projectNode.Text = loadedProject.Metadata.Name;

                foreach (var revisionCollector in loadedProject.Components.Values)
                {
                    TreeNode? componentNode;
                    int imageIndex;
                    ComponentReference firstRevision = revisionCollector.GetValueAtIndex(0);

                    switch (firstRevision.PartNumber[0])
                    {
                        case 'A':
                            componentNode = assembliesFolder.Add(FormatComponentDescriptor(firstRevision, DescriptorType.TopLevel));
                            imageIndex = 2;
                            break;
                        case 'P':
                            componentNode = partsFolder.Add(FormatComponentDescriptor(firstRevision, DescriptorType.TopLevel));
                            imageIndex = 3;
                            break;
                        case 'M':
                            componentNode = materialsFolder.Add(FormatComponentDescriptor(firstRevision, DescriptorType.TopLevel));
                            imageIndex = 4;
                            break;
                        default:
                            componentNode = otherFolder.Add(FormatComponentDescriptor(firstRevision, DescriptorType.TopLevel));
                            imageIndex = 1;
                            break;
                    }

                    componentNode.ImageIndex = imageIndex;
                    componentNode.SelectedImageIndex = imageIndex;

                    foreach (ComponentReference componentRevision in revisionCollector.Values)
                    {
                        TreeNode revisionNode = componentNode.Nodes.Add(FormatComponentDescriptor(componentRevision, DescriptorType.RevisionLevel));
                        revisionNode.ImageIndex = imageIndex;
                        revisionNode.SelectedImageIndex = imageIndex;
                    }
                }
            }
        }

        private void RepopulateComponentHierarchy()
        {
            TreeNode componentNode = componentTreeView.Nodes[0];

            componentNode.Text = "? (No Component)";
            componentNode.Nodes.Clear();

            if (loadedComponent is not null)
            {
                foreach (ComponentReference bomItem in loadedComponent.BOM)
                {
                    TreeNode bomItemNode = componentNode.Nodes.Add(FormatComponentDescriptor(bomItem, DescriptorType.BOM));

                    int imageIndex = bomItem.PartNumber[0] switch
                    {
                        'A' => 2,
                        'P' => 3,
                        'M' => 4,
                        _ => 1,
                    };

                    bomItemNode.ImageIndex = imageIndex;
                    bomItemNode.SelectedImageIndex = imageIndex;
                }
            }
        }

        private void SetWaitingState(bool waiting)
        {
            Cursor = waiting ? Cursors.WaitCursor : Cursors.Default;
            Enabled = !waiting;
        }

        private string FormatComponentDescriptor(ComponentReference component, DescriptorType type)
        {
            return type switch
            {
                DescriptorType.TopLevel => $"{component.PartNumber} - {component.Title}",
                DescriptorType.RevisionLevel => $"{component.PartNumber}/{component.Revision}",
                DescriptorType.BOM => $"{component.PartNumber}/{component.Revision} - {component.Title}",
                _ => throw new NotImplementedException(), // fix
            };
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProjectDialog newProjectDialog = new(RW, this);
            newProjectDialog.ShowDialog();
        }

        private void projectListToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWaitingState(true);

            loadedProject = RW.ParseProject(projects[projectListToolStripComboBox.Text].GUID);
            RepopulateProjectHierarchy();

            SetWaitingState(false);
        }

        private void projectTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (loadedProject is not null && loadedProject.GetComponent(e.Node.Text) is ComponentReference component)
            {
                SetWaitingState(true);

                loadedComponent = RW.ParseComponent(loadedProject.Metadata.GUID, component);
                RepopulateComponentHierarchy();

                if (loadedComponentTreeNode is not null)
                {
                    loadedComponentTreeNode.ImageIndex = loadedComponentImageIndex;
                    loadedComponentTreeNode.SelectedImageIndex = loadedComponentImageIndex;
                }

                loadedComponentTreeNode = e.Node;
                loadedComponentImageIndex = e.Node.ImageIndex;
                e.Node.ImageIndex = 0;
                e.Node.SelectedImageIndex = 0;

                SetWaitingState(false);
            }

            else
            {
                // do something
            }
        }
    }
}