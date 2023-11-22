namespace DAABOM
{
    partial class DataBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Assemblies", 7, 7);
            TreeNode treeNode2 = new TreeNode("Parts", 7, 7);
            TreeNode treeNode3 = new TreeNode("Materials", 7, 7);
            TreeNode treeNode4 = new TreeNode("Other", 7, 7);
            TreeNode treeNode5 = new TreeNode("? (No Project)", 6, 6, new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBrowser));
            TreeNode treeNode6 = new TreeNode("? (No Component)", 1, 1);
            statusStrip = new StatusStrip();
            localFilepathLabelToolStripStatusLabel = new ToolStripStatusLabel();
            localFilepathToolStripStatusLabel = new ToolStripStatusLabel();
            editPropertiesSplitButton = new ToolStripSplitButton();
            enableEditingToolStripMenuItem = new ToolStripMenuItem();
            saveChangesToolStripMenuItem = new ToolStripMenuItem();
            discardChangesToolStripMenuItem = new ToolStripMenuItem();
            serverToolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            splitContainerMain = new SplitContainer();
            treeTabControl = new TabControl();
            projectTabPage = new TabPage();
            projectTreeView = new TreeView();
            treeViewImageList = new ImageList(components);
            componentTabPage = new TabPage();
            componentTreeView = new TreeView();
            tabControl = new TabControl();
            propertiesPage = new TabPage();
            propertiesTableLayoutPanel = new TableLayoutPanel();
            notesLabel = new Label();
            vendorLabel = new Label();
            originLabel = new Label();
            descriptionLabel = new Label();
            revisionLabel = new Label();
            titleLabel = new Label();
            statusLabel = new Label();
            materialLabel = new Label();
            vendorPNLabel = new Label();
            partNumberLabel = new Label();
            partNumberTextBox = new TextBox();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            originComboBox = new ComboBox();
            manufacturerTextBox = new TextBox();
            manufacturerPNTextBox = new TextBox();
            materialTextBox = new TextBox();
            statusComboBox = new ComboBox();
            notesTextBox = new TextBox();
            revisionSplitContainer = new SplitContainer();
            revisionTextBox = new TextBox();
            revisionDateTimePicker = new DateTimePicker();
            whereUsedPage = new TabPage();
            whereUsedListView = new ListView();
            whereUsedPartNumberColumnHeader = new ColumnHeader();
            whereUsedTitleColumnHeader = new ColumnHeader();
            whereUsedRevisionColumnHeader = new ColumnHeader();
            referencesPage = new TabPage();
            whereUsedTableLayoutPanel = new TableLayoutPanel();
            SWFileLabel = new Label();
            SWDWGLabel = new Label();
            DWGPDFLabel = new Label();
            SWFileSplitContainer = new SplitContainer();
            SWFileOpenButton = new Button();
            SWFileFilepathTextBox = new TextBox();
            SWDWGSplitContainer = new SplitContainer();
            SWDWGOpenButton = new Button();
            SWDWGFilepathTextBox = new TextBox();
            DWGPDFSplitContainer = new SplitContainer();
            DWGPDFOpenButton = new Button();
            DWGPDFFilepathTextBox = new TextBox();
            revisionReferencesListView = new ListView();
            revisionReferencesLabel = new Label();
            previewPage = new TabPage();
            menuStrip = new MenuStrip();
            projectListToolStripComboBox = new ToolStripComboBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            newComponentToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            treeTabControl.SuspendLayout();
            projectTabPage.SuspendLayout();
            componentTabPage.SuspendLayout();
            tabControl.SuspendLayout();
            propertiesPage.SuspendLayout();
            propertiesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)revisionSplitContainer).BeginInit();
            revisionSplitContainer.Panel1.SuspendLayout();
            revisionSplitContainer.Panel2.SuspendLayout();
            revisionSplitContainer.SuspendLayout();
            whereUsedPage.SuspendLayout();
            referencesPage.SuspendLayout();
            whereUsedTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SWFileSplitContainer).BeginInit();
            SWFileSplitContainer.Panel1.SuspendLayout();
            SWFileSplitContainer.Panel2.SuspendLayout();
            SWFileSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SWDWGSplitContainer).BeginInit();
            SWDWGSplitContainer.Panel1.SuspendLayout();
            SWDWGSplitContainer.Panel2.SuspendLayout();
            SWDWGSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DWGPDFSplitContainer).BeginInit();
            DWGPDFSplitContainer.Panel1.SuspendLayout();
            DWGPDFSplitContainer.Panel2.SuspendLayout();
            DWGPDFSplitContainer.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(18, 18);
            statusStrip.Items.AddRange(new ToolStripItem[] { localFilepathLabelToolStripStatusLabel, localFilepathToolStripStatusLabel, editPropertiesSplitButton, serverToolStripStatusLabel, toolStripProgressBar });
            statusStrip.Location = new Point(0, 575);
            statusStrip.Name = "statusStrip";
            statusStrip.ShowItemToolTips = true;
            statusStrip.Size = new Size(1008, 24);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // localFilepathLabelToolStripStatusLabel
            // 
            localFilepathLabelToolStripStatusLabel.Name = "localFilepathLabelToolStripStatusLabel";
            localFilepathLabelToolStripStatusLabel.Size = new Size(90, 19);
            localFilepathLabelToolStripStatusLabel.Text = "Local Filepath:";
            // 
            // localFilepathToolStripStatusLabel
            // 
            localFilepathToolStripStatusLabel.AutoSize = false;
            localFilepathToolStripStatusLabel.IsLink = true;
            localFilepathToolStripStatusLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
            localFilepathToolStripStatusLabel.Name = "localFilepathToolStripStatusLabel";
            localFilepathToolStripStatusLabel.RightToLeft = RightToLeft.No;
            localFilepathToolStripStatusLabel.Size = new Size(746, 19);
            localFilepathToolStripStatusLabel.Spring = true;
            localFilepathToolStripStatusLabel.Text = "?";
            localFilepathToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editPropertiesSplitButton
            // 
            editPropertiesSplitButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editPropertiesSplitButton.DropDownItems.AddRange(new ToolStripItem[] { enableEditingToolStripMenuItem, saveChangesToolStripMenuItem, discardChangesToolStripMenuItem });
            editPropertiesSplitButton.Image = Properties.Resources.signature_no_0;
            editPropertiesSplitButton.ImageScaling = ToolStripItemImageScaling.None;
            editPropertiesSplitButton.ImageTransparentColor = Color.Magenta;
            editPropertiesSplitButton.Name = "editPropertiesSplitButton";
            editPropertiesSplitButton.Size = new Size(33, 22);
            // 
            // enableEditingToolStripMenuItem
            // 
            enableEditingToolStripMenuItem.Name = "enableEditingToolStripMenuItem";
            enableEditingToolStripMenuItem.Size = new Size(180, 24);
            enableEditingToolStripMenuItem.Text = "Enable Editing";
            // 
            // saveChangesToolStripMenuItem
            // 
            saveChangesToolStripMenuItem.Name = "saveChangesToolStripMenuItem";
            saveChangesToolStripMenuItem.Size = new Size(180, 24);
            saveChangesToolStripMenuItem.Text = "Save Changes";
            // 
            // discardChangesToolStripMenuItem
            // 
            discardChangesToolStripMenuItem.Name = "discardChangesToolStripMenuItem";
            discardChangesToolStripMenuItem.Size = new Size(180, 24);
            discardChangesToolStripMenuItem.Text = "Discard Changes";
            // 
            // serverToolStripStatusLabel
            // 
            serverToolStripStatusLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            serverToolStripStatusLabel.Image = Properties.Resources.network_drive_unavailable_1;
            serverToolStripStatusLabel.ImageScaling = ToolStripItemImageScaling.None;
            serverToolStripStatusLabel.Margin = new Padding(0, 3, 6, 2);
            serverToolStripStatusLabel.Name = "serverToolStripStatusLabel";
            serverToolStripStatusLabel.Size = new Size(16, 19);
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 18);
            // 
            // splitContainerMain
            // 
            splitContainerMain.BorderStyle = BorderStyle.Fixed3D;
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 29);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(treeTabControl);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(tabControl);
            splitContainerMain.Size = new Size(1008, 546);
            splitContainerMain.SplitterDistance = 336;
            splitContainerMain.TabIndex = 1;
            // 
            // treeTabControl
            // 
            treeTabControl.Controls.Add(projectTabPage);
            treeTabControl.Controls.Add(componentTabPage);
            treeTabControl.Dock = DockStyle.Fill;
            treeTabControl.Location = new Point(0, 0);
            treeTabControl.Name = "treeTabControl";
            treeTabControl.SelectedIndex = 0;
            treeTabControl.Size = new Size(332, 542);
            treeTabControl.TabIndex = 0;
            // 
            // projectTabPage
            // 
            projectTabPage.Controls.Add(projectTreeView);
            projectTabPage.Location = new Point(4, 26);
            projectTabPage.Name = "projectTabPage";
            projectTabPage.Padding = new Padding(3);
            projectTabPage.Size = new Size(324, 512);
            projectTabPage.TabIndex = 0;
            projectTabPage.Text = "Project";
            projectTabPage.UseVisualStyleBackColor = true;
            // 
            // projectTreeView
            // 
            projectTreeView.Dock = DockStyle.Fill;
            projectTreeView.ImageIndex = 0;
            projectTreeView.ImageList = treeViewImageList;
            projectTreeView.Location = new Point(3, 3);
            projectTreeView.Name = "projectTreeView";
            treeNode1.ImageIndex = 7;
            treeNode1.Name = "assembliesNode";
            treeNode1.SelectedImageIndex = 7;
            treeNode1.Text = "Assemblies";
            treeNode2.ImageIndex = 7;
            treeNode2.Name = "partsNode";
            treeNode2.SelectedImageIndex = 7;
            treeNode2.Text = "Parts";
            treeNode3.ImageIndex = 7;
            treeNode3.Name = "materialsNode";
            treeNode3.SelectedImageIndex = 7;
            treeNode3.Text = "Materials";
            treeNode4.ImageIndex = 7;
            treeNode4.Name = "otherNode";
            treeNode4.SelectedImageIndex = 7;
            treeNode4.Text = "Other";
            treeNode5.ImageIndex = 6;
            treeNode5.Name = "projectNode";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "? (No Project)";
            projectTreeView.Nodes.AddRange(new TreeNode[] { treeNode5 });
            projectTreeView.SelectedImageIndex = 0;
            projectTreeView.Size = new Size(318, 506);
            projectTreeView.TabIndex = 0;
            projectTreeView.NodeMouseDoubleClick += projectTreeView_NodeMouseDoubleClick;
            // 
            // treeViewImageList
            // 
            treeViewImageList.ColorDepth = ColorDepth.Depth8Bit;
            treeViewImageList.ImageStream = (ImageListStreamer)resources.GetObject("treeViewImageList.ImageStream");
            treeViewImageList.TransparentColor = Color.Transparent;
            treeViewImageList.Images.SetKeyName(0, "check-1.png");
            treeViewImageList.Images.SetKeyName(1, "circle_question-1.png");
            treeViewImageList.Images.SetKeyName(2, "gears_3-1.png");
            treeViewImageList.Images.SetKeyName(3, "gears-1.png");
            treeViewImageList.Images.SetKeyName(4, "cylinder_database-0.png");
            treeViewImageList.Images.SetKeyName(5, "network_drive_world-1.png");
            treeViewImageList.Images.SetKeyName(6, "desktop-3.png");
            treeViewImageList.Images.SetKeyName(7, "directory_closed-1.png");
            // 
            // componentTabPage
            // 
            componentTabPage.Controls.Add(componentTreeView);
            componentTabPage.Location = new Point(4, 26);
            componentTabPage.Name = "componentTabPage";
            componentTabPage.Padding = new Padding(3);
            componentTabPage.Size = new Size(324, 512);
            componentTabPage.TabIndex = 1;
            componentTabPage.Text = "Component";
            componentTabPage.UseVisualStyleBackColor = true;
            // 
            // componentTreeView
            // 
            componentTreeView.Dock = DockStyle.Fill;
            componentTreeView.ImageIndex = 0;
            componentTreeView.ImageList = treeViewImageList;
            componentTreeView.Location = new Point(3, 3);
            componentTreeView.Name = "componentTreeView";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "componentNode";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "? (No Component)";
            componentTreeView.Nodes.AddRange(new TreeNode[] { treeNode6 });
            componentTreeView.SelectedImageIndex = 0;
            componentTreeView.Size = new Size(318, 506);
            componentTreeView.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(propertiesPage);
            tabControl.Controls.Add(whereUsedPage);
            tabControl.Controls.Add(referencesPage);
            tabControl.Controls.Add(previewPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(664, 542);
            tabControl.TabIndex = 0;
            // 
            // propertiesPage
            // 
            propertiesPage.Controls.Add(propertiesTableLayoutPanel);
            propertiesPage.Location = new Point(4, 26);
            propertiesPage.Name = "propertiesPage";
            propertiesPage.Padding = new Padding(3);
            propertiesPage.Size = new Size(656, 512);
            propertiesPage.TabIndex = 0;
            propertiesPage.Text = "Properties";
            propertiesPage.UseVisualStyleBackColor = true;
            // 
            // propertiesTableLayoutPanel
            // 
            propertiesTableLayoutPanel.AutoSize = true;
            propertiesTableLayoutPanel.ColumnCount = 2;
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            propertiesTableLayoutPanel.Controls.Add(notesLabel, 0, 10);
            propertiesTableLayoutPanel.Controls.Add(vendorLabel, 0, 6);
            propertiesTableLayoutPanel.Controls.Add(originLabel, 0, 5);
            propertiesTableLayoutPanel.Controls.Add(descriptionLabel, 0, 2);
            propertiesTableLayoutPanel.Controls.Add(revisionLabel, 0, 3);
            propertiesTableLayoutPanel.Controls.Add(titleLabel, 0, 1);
            propertiesTableLayoutPanel.Controls.Add(statusLabel, 0, 9);
            propertiesTableLayoutPanel.Controls.Add(materialLabel, 0, 8);
            propertiesTableLayoutPanel.Controls.Add(vendorPNLabel, 0, 7);
            propertiesTableLayoutPanel.Controls.Add(partNumberLabel, 0, 0);
            propertiesTableLayoutPanel.Controls.Add(partNumberTextBox, 1, 0);
            propertiesTableLayoutPanel.Controls.Add(titleTextBox, 1, 1);
            propertiesTableLayoutPanel.Controls.Add(descriptionTextBox, 1, 2);
            propertiesTableLayoutPanel.Controls.Add(originComboBox, 1, 5);
            propertiesTableLayoutPanel.Controls.Add(manufacturerTextBox, 1, 6);
            propertiesTableLayoutPanel.Controls.Add(manufacturerPNTextBox, 1, 7);
            propertiesTableLayoutPanel.Controls.Add(materialTextBox, 1, 8);
            propertiesTableLayoutPanel.Controls.Add(statusComboBox, 1, 9);
            propertiesTableLayoutPanel.Controls.Add(notesTextBox, 1, 10);
            propertiesTableLayoutPanel.Controls.Add(revisionSplitContainer, 1, 3);
            propertiesTableLayoutPanel.Dock = DockStyle.Fill;
            propertiesTableLayoutPanel.Location = new Point(3, 3);
            propertiesTableLayoutPanel.Name = "propertiesTableLayoutPanel";
            propertiesTableLayoutPanel.RowCount = 11;
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.RowStyles.Add(new RowStyle());
            propertiesTableLayoutPanel.Size = new Size(650, 506);
            propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Dock = DockStyle.Fill;
            notesLabel.Location = new Point(3, 279);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(319, 227);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes";
            notesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Dock = DockStyle.Fill;
            vendorLabel.Location = new Point(3, 155);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new Size(319, 31);
            vendorLabel.TabIndex = 18;
            vendorLabel.Text = "Vendor";
            vendorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Dock = DockStyle.Fill;
            originLabel.Location = new Point(3, 124);
            originLabel.Name = "originLabel";
            originLabel.Size = new Size(319, 31);
            originLabel.TabIndex = 16;
            originLabel.Text = "Origin";
            originLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Location = new Point(3, 62);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(319, 31);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // revisionLabel
            // 
            revisionLabel.AutoSize = true;
            revisionLabel.Dock = DockStyle.Fill;
            revisionLabel.Location = new Point(3, 93);
            revisionLabel.Name = "revisionLabel";
            revisionLabel.Size = new Size(319, 31);
            revisionLabel.TabIndex = 0;
            revisionLabel.Text = "Revision";
            revisionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Location = new Point(3, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(319, 31);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Location = new Point(3, 248);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(319, 31);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Dock = DockStyle.Fill;
            materialLabel.Location = new Point(3, 217);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(319, 31);
            materialLabel.TabIndex = 8;
            materialLabel.Text = "Material";
            materialLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vendorPNLabel
            // 
            vendorPNLabel.AutoSize = true;
            vendorPNLabel.Dock = DockStyle.Fill;
            vendorPNLabel.Location = new Point(3, 186);
            vendorPNLabel.Name = "vendorPNLabel";
            vendorPNLabel.Size = new Size(319, 31);
            vendorPNLabel.TabIndex = 6;
            vendorPNLabel.Text = "Vendor Part Number";
            vendorPNLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Dock = DockStyle.Fill;
            partNumberLabel.Location = new Point(3, 0);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new Size(319, 31);
            partNumberLabel.TabIndex = 4;
            partNumberLabel.Text = "Part Number";
            partNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // partNumberTextBox
            // 
            partNumberTextBox.Dock = DockStyle.Fill;
            partNumberTextBox.Enabled = false;
            partNumberTextBox.Location = new Point(328, 3);
            partNumberTextBox.MaxLength = 9;
            partNumberTextBox.Name = "partNumberTextBox";
            partNumberTextBox.Size = new Size(319, 25);
            partNumberTextBox.TabIndex = 20;
            // 
            // titleTextBox
            // 
            titleTextBox.Dock = DockStyle.Fill;
            titleTextBox.Enabled = false;
            titleTextBox.Location = new Point(328, 34);
            titleTextBox.MaxLength = 42;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(319, 25);
            titleTextBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Location = new Point(328, 65);
            descriptionTextBox.MaxLength = 42;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(319, 25);
            descriptionTextBox.TabIndex = 22;
            // 
            // originComboBox
            // 
            originComboBox.Dock = DockStyle.Fill;
            originComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            originComboBox.Enabled = false;
            originComboBox.Items.AddRange(new object[] { "Make", "Buy", "Modify" });
            originComboBox.Location = new Point(328, 127);
            originComboBox.Name = "originComboBox";
            originComboBox.Size = new Size(319, 25);
            originComboBox.TabIndex = 23;
            // 
            // manufacturerTextBox
            // 
            manufacturerTextBox.Dock = DockStyle.Fill;
            manufacturerTextBox.Enabled = false;
            manufacturerTextBox.Location = new Point(328, 158);
            manufacturerTextBox.MaxLength = 42;
            manufacturerTextBox.Name = "manufacturerTextBox";
            manufacturerTextBox.Size = new Size(319, 25);
            manufacturerTextBox.TabIndex = 24;
            // 
            // manufacturerPNTextBox
            // 
            manufacturerPNTextBox.Dock = DockStyle.Fill;
            manufacturerPNTextBox.Enabled = false;
            manufacturerPNTextBox.Location = new Point(328, 189);
            manufacturerPNTextBox.MaxLength = 42;
            manufacturerPNTextBox.Name = "manufacturerPNTextBox";
            manufacturerPNTextBox.Size = new Size(319, 25);
            manufacturerPNTextBox.TabIndex = 25;
            // 
            // materialTextBox
            // 
            materialTextBox.Dock = DockStyle.Fill;
            materialTextBox.Enabled = false;
            materialTextBox.Location = new Point(328, 220);
            materialTextBox.MaxLength = 42;
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(319, 25);
            materialTextBox.TabIndex = 26;
            // 
            // statusComboBox
            // 
            statusComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Finished", "Manufacturing / Assembly", "Design Complete", "Design In Progress", "Design Not Started", "Old Revision", "Obsolete" });
            statusComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            statusComboBox.Dock = DockStyle.Fill;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Enabled = false;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Finished", "Manufacturing / Assembly", "Design Complete", "Design In Progress", "Design Not Started", "Obsolete" });
            statusComboBox.Location = new Point(328, 251);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(319, 25);
            statusComboBox.TabIndex = 27;
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Fill;
            notesTextBox.Enabled = false;
            notesTextBox.Location = new Point(328, 282);
            notesTextBox.MaxLength = 420;
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(319, 221);
            notesTextBox.TabIndex = 28;
            // 
            // revisionSplitContainer
            // 
            revisionSplitContainer.Dock = DockStyle.Fill;
            revisionSplitContainer.FixedPanel = FixedPanel.Panel1;
            revisionSplitContainer.IsSplitterFixed = true;
            revisionSplitContainer.Location = new Point(328, 96);
            revisionSplitContainer.Name = "revisionSplitContainer";
            // 
            // revisionSplitContainer.Panel1
            // 
            revisionSplitContainer.Panel1.Controls.Add(revisionTextBox);
            // 
            // revisionSplitContainer.Panel2
            // 
            revisionSplitContainer.Panel2.Controls.Add(revisionDateTimePicker);
            revisionSplitContainer.Size = new Size(319, 25);
            revisionSplitContainer.SplitterDistance = 70;
            revisionSplitContainer.TabIndex = 29;
            // 
            // revisionTextBox
            // 
            revisionTextBox.Dock = DockStyle.Fill;
            revisionTextBox.Enabled = false;
            revisionTextBox.Location = new Point(0, 0);
            revisionTextBox.MaxLength = 4;
            revisionTextBox.Name = "revisionTextBox";
            revisionTextBox.ReadOnly = true;
            revisionTextBox.Size = new Size(70, 25);
            revisionTextBox.TabIndex = 0;
            revisionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // revisionDateTimePicker
            // 
            revisionDateTimePicker.Dock = DockStyle.Fill;
            revisionDateTimePicker.Enabled = false;
            revisionDateTimePicker.Location = new Point(0, 0);
            revisionDateTimePicker.Name = "revisionDateTimePicker";
            revisionDateTimePicker.Size = new Size(245, 25);
            revisionDateTimePicker.TabIndex = 0;
            // 
            // whereUsedPage
            // 
            whereUsedPage.Controls.Add(whereUsedListView);
            whereUsedPage.Location = new Point(4, 26);
            whereUsedPage.Name = "whereUsedPage";
            whereUsedPage.Padding = new Padding(3);
            whereUsedPage.Size = new Size(656, 512);
            whereUsedPage.TabIndex = 2;
            whereUsedPage.Text = "Where Used";
            whereUsedPage.UseVisualStyleBackColor = true;
            // 
            // whereUsedListView
            // 
            whereUsedListView.Columns.AddRange(new ColumnHeader[] { whereUsedPartNumberColumnHeader, whereUsedTitleColumnHeader, whereUsedRevisionColumnHeader });
            whereUsedListView.Dock = DockStyle.Fill;
            whereUsedListView.Location = new Point(3, 3);
            whereUsedListView.Name = "whereUsedListView";
            whereUsedListView.Size = new Size(650, 506);
            whereUsedListView.TabIndex = 0;
            whereUsedListView.UseCompatibleStateImageBehavior = false;
            whereUsedListView.View = View.Details;
            // 
            // whereUsedPartNumberColumnHeader
            // 
            whereUsedPartNumberColumnHeader.Text = "Part Number";
            whereUsedPartNumberColumnHeader.Width = 292;
            // 
            // whereUsedTitleColumnHeader
            // 
            whereUsedTitleColumnHeader.Text = "Title";
            whereUsedTitleColumnHeader.Width = 292;
            // 
            // whereUsedRevisionColumnHeader
            // 
            whereUsedRevisionColumnHeader.Text = "Revision";
            whereUsedRevisionColumnHeader.Width = 62;
            // 
            // referencesPage
            // 
            referencesPage.Controls.Add(whereUsedTableLayoutPanel);
            referencesPage.Location = new Point(4, 26);
            referencesPage.Name = "referencesPage";
            referencesPage.Padding = new Padding(3);
            referencesPage.Size = new Size(656, 512);
            referencesPage.TabIndex = 3;
            referencesPage.Text = "References";
            referencesPage.UseVisualStyleBackColor = true;
            // 
            // whereUsedTableLayoutPanel
            // 
            whereUsedTableLayoutPanel.ColumnCount = 2;
            whereUsedTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99667F));
            whereUsedTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.003334F));
            whereUsedTableLayoutPanel.Controls.Add(SWFileLabel, 0, 0);
            whereUsedTableLayoutPanel.Controls.Add(SWDWGLabel, 0, 1);
            whereUsedTableLayoutPanel.Controls.Add(DWGPDFLabel, 0, 2);
            whereUsedTableLayoutPanel.Controls.Add(SWFileSplitContainer, 1, 0);
            whereUsedTableLayoutPanel.Controls.Add(SWDWGSplitContainer, 1, 1);
            whereUsedTableLayoutPanel.Controls.Add(DWGPDFSplitContainer, 1, 2);
            whereUsedTableLayoutPanel.Controls.Add(revisionReferencesListView, 1, 3);
            whereUsedTableLayoutPanel.Controls.Add(revisionReferencesLabel, 0, 3);
            whereUsedTableLayoutPanel.Dock = DockStyle.Fill;
            whereUsedTableLayoutPanel.Location = new Point(3, 3);
            whereUsedTableLayoutPanel.Name = "whereUsedTableLayoutPanel";
            whereUsedTableLayoutPanel.RowCount = 4;
            whereUsedTableLayoutPanel.RowStyles.Add(new RowStyle());
            whereUsedTableLayoutPanel.RowStyles.Add(new RowStyle());
            whereUsedTableLayoutPanel.RowStyles.Add(new RowStyle());
            whereUsedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            whereUsedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            whereUsedTableLayoutPanel.Size = new Size(650, 506);
            whereUsedTableLayoutPanel.TabIndex = 0;
            // 
            // SWFileLabel
            // 
            SWFileLabel.AutoSize = true;
            SWFileLabel.Dock = DockStyle.Fill;
            SWFileLabel.Location = new Point(3, 0);
            SWFileLabel.Name = "SWFileLabel";
            SWFileLabel.Size = new Size(156, 31);
            SWFileLabel.TabIndex = 0;
            SWFileLabel.Text = "SW File";
            SWFileLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SWDWGLabel
            // 
            SWDWGLabel.AutoSize = true;
            SWDWGLabel.Dock = DockStyle.Fill;
            SWDWGLabel.Location = new Point(3, 31);
            SWDWGLabel.Name = "SWDWGLabel";
            SWDWGLabel.Size = new Size(156, 31);
            SWDWGLabel.TabIndex = 1;
            SWDWGLabel.Text = "SW DWG";
            SWDWGLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DWGPDFLabel
            // 
            DWGPDFLabel.AutoSize = true;
            DWGPDFLabel.Dock = DockStyle.Fill;
            DWGPDFLabel.Location = new Point(3, 62);
            DWGPDFLabel.Name = "DWGPDFLabel";
            DWGPDFLabel.Size = new Size(156, 31);
            DWGPDFLabel.TabIndex = 2;
            DWGPDFLabel.Text = "DWG PDF";
            DWGPDFLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SWFileSplitContainer
            // 
            SWFileSplitContainer.Dock = DockStyle.Fill;
            SWFileSplitContainer.FixedPanel = FixedPanel.Panel1;
            SWFileSplitContainer.IsSplitterFixed = true;
            SWFileSplitContainer.Location = new Point(165, 3);
            SWFileSplitContainer.Name = "SWFileSplitContainer";
            // 
            // SWFileSplitContainer.Panel1
            // 
            SWFileSplitContainer.Panel1.Controls.Add(SWFileOpenButton);
            // 
            // SWFileSplitContainer.Panel2
            // 
            SWFileSplitContainer.Panel2.Controls.Add(SWFileFilepathTextBox);
            SWFileSplitContainer.Size = new Size(482, 25);
            SWFileSplitContainer.TabIndex = 3;
            // 
            // SWFileOpenButton
            // 
            SWFileOpenButton.Dock = DockStyle.Fill;
            SWFileOpenButton.Location = new Point(0, 0);
            SWFileOpenButton.Name = "SWFileOpenButton";
            SWFileOpenButton.Size = new Size(50, 25);
            SWFileOpenButton.TabIndex = 0;
            SWFileOpenButton.Text = "Open";
            SWFileOpenButton.UseVisualStyleBackColor = true;
            // 
            // SWFileFilepathTextBox
            // 
            SWFileFilepathTextBox.Dock = DockStyle.Fill;
            SWFileFilepathTextBox.Location = new Point(0, 0);
            SWFileFilepathTextBox.Name = "SWFileFilepathTextBox";
            SWFileFilepathTextBox.Size = new Size(428, 25);
            SWFileFilepathTextBox.TabIndex = 0;
            // 
            // SWDWGSplitContainer
            // 
            SWDWGSplitContainer.Dock = DockStyle.Fill;
            SWDWGSplitContainer.FixedPanel = FixedPanel.Panel1;
            SWDWGSplitContainer.IsSplitterFixed = true;
            SWDWGSplitContainer.Location = new Point(165, 34);
            SWDWGSplitContainer.Name = "SWDWGSplitContainer";
            // 
            // SWDWGSplitContainer.Panel1
            // 
            SWDWGSplitContainer.Panel1.Controls.Add(SWDWGOpenButton);
            // 
            // SWDWGSplitContainer.Panel2
            // 
            SWDWGSplitContainer.Panel2.Controls.Add(SWDWGFilepathTextBox);
            SWDWGSplitContainer.Size = new Size(482, 25);
            SWDWGSplitContainer.TabIndex = 4;
            // 
            // SWDWGOpenButton
            // 
            SWDWGOpenButton.Dock = DockStyle.Fill;
            SWDWGOpenButton.Location = new Point(0, 0);
            SWDWGOpenButton.Name = "SWDWGOpenButton";
            SWDWGOpenButton.Size = new Size(50, 25);
            SWDWGOpenButton.TabIndex = 0;
            SWDWGOpenButton.Text = "Open";
            SWDWGOpenButton.UseVisualStyleBackColor = true;
            // 
            // SWDWGFilepathTextBox
            // 
            SWDWGFilepathTextBox.Dock = DockStyle.Fill;
            SWDWGFilepathTextBox.Location = new Point(0, 0);
            SWDWGFilepathTextBox.Name = "SWDWGFilepathTextBox";
            SWDWGFilepathTextBox.Size = new Size(428, 25);
            SWDWGFilepathTextBox.TabIndex = 0;
            // 
            // DWGPDFSplitContainer
            // 
            DWGPDFSplitContainer.Dock = DockStyle.Fill;
            DWGPDFSplitContainer.FixedPanel = FixedPanel.Panel1;
            DWGPDFSplitContainer.IsSplitterFixed = true;
            DWGPDFSplitContainer.Location = new Point(165, 65);
            DWGPDFSplitContainer.Name = "DWGPDFSplitContainer";
            // 
            // DWGPDFSplitContainer.Panel1
            // 
            DWGPDFSplitContainer.Panel1.Controls.Add(DWGPDFOpenButton);
            // 
            // DWGPDFSplitContainer.Panel2
            // 
            DWGPDFSplitContainer.Panel2.Controls.Add(DWGPDFFilepathTextBox);
            DWGPDFSplitContainer.Size = new Size(482, 25);
            DWGPDFSplitContainer.TabIndex = 5;
            // 
            // DWGPDFOpenButton
            // 
            DWGPDFOpenButton.Dock = DockStyle.Fill;
            DWGPDFOpenButton.Location = new Point(0, 0);
            DWGPDFOpenButton.Name = "DWGPDFOpenButton";
            DWGPDFOpenButton.Size = new Size(50, 25);
            DWGPDFOpenButton.TabIndex = 0;
            DWGPDFOpenButton.Text = "Open";
            DWGPDFOpenButton.UseVisualStyleBackColor = true;
            // 
            // DWGPDFFilepathTextBox
            // 
            DWGPDFFilepathTextBox.Dock = DockStyle.Fill;
            DWGPDFFilepathTextBox.Location = new Point(0, 0);
            DWGPDFFilepathTextBox.Name = "DWGPDFFilepathTextBox";
            DWGPDFFilepathTextBox.Size = new Size(428, 25);
            DWGPDFFilepathTextBox.TabIndex = 0;
            // 
            // revisionReferencesListView
            // 
            revisionReferencesListView.Dock = DockStyle.Fill;
            revisionReferencesListView.Location = new Point(165, 96);
            revisionReferencesListView.Name = "revisionReferencesListView";
            revisionReferencesListView.Size = new Size(482, 407);
            revisionReferencesListView.TabIndex = 7;
            revisionReferencesListView.UseCompatibleStateImageBehavior = false;
            // 
            // revisionReferencesLabel
            // 
            revisionReferencesLabel.AutoSize = true;
            revisionReferencesLabel.Dock = DockStyle.Fill;
            revisionReferencesLabel.Location = new Point(3, 93);
            revisionReferencesLabel.Name = "revisionReferencesLabel";
            revisionReferencesLabel.Size = new Size(156, 413);
            revisionReferencesLabel.TabIndex = 9;
            revisionReferencesLabel.Text = "Revision References";
            revisionReferencesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // previewPage
            // 
            previewPage.Location = new Point(4, 26);
            previewPage.Name = "previewPage";
            previewPage.Padding = new Padding(3);
            previewPage.Size = new Size(656, 512);
            previewPage.TabIndex = 4;
            previewPage.Text = "Preview";
            previewPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(18, 18);
            menuStrip.Items.AddRange(new ToolStripItem[] { projectListToolStripComboBox, fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1008, 29);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // projectListToolStripComboBox
            // 
            projectListToolStripComboBox.Alignment = ToolStripItemAlignment.Right;
            projectListToolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectListToolStripComboBox.FlatStyle = FlatStyle.Standard;
            projectListToolStripComboBox.MaxLength = 24;
            projectListToolStripComboBox.Name = "projectListToolStripComboBox";
            projectListToolStripComboBox.Size = new Size(256, 25);
            projectListToolStripComboBox.Sorted = true;
            projectListToolStripComboBox.SelectedIndexChanged += projectListToolStripComboBox_SelectedIndexChanged;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, newComponentToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(198, 24);
            newToolStripMenuItem.Text = "New";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.Size = new Size(198, 24);
            newProjectToolStripMenuItem.Text = "Project";
            newProjectToolStripMenuItem.Click += newProjectToolStripMenuItem_Click;
            // 
            // newComponentToolStripMenuItem
            // 
            newComponentToolStripMenuItem.Name = "newComponentToolStripMenuItem";
            newComponentToolStripMenuItem.Size = new Size(198, 24);
            newComponentToolStripMenuItem.Text = "Component";
            // 
            // DataBrowser
            // 
            AccessibleDescription = "DAABOM browser window";
            AccessibleName = "DAABOM Browser";
            AccessibleRole = AccessibleRole.Window;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 599);
            Controls.Add(splitContainerMain);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "DataBrowser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DAABOM Browser";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            treeTabControl.ResumeLayout(false);
            projectTabPage.ResumeLayout(false);
            componentTabPage.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            propertiesPage.ResumeLayout(false);
            propertiesPage.PerformLayout();
            propertiesTableLayoutPanel.ResumeLayout(false);
            propertiesTableLayoutPanel.PerformLayout();
            revisionSplitContainer.Panel1.ResumeLayout(false);
            revisionSplitContainer.Panel1.PerformLayout();
            revisionSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)revisionSplitContainer).EndInit();
            revisionSplitContainer.ResumeLayout(false);
            whereUsedPage.ResumeLayout(false);
            referencesPage.ResumeLayout(false);
            whereUsedTableLayoutPanel.ResumeLayout(false);
            whereUsedTableLayoutPanel.PerformLayout();
            SWFileSplitContainer.Panel1.ResumeLayout(false);
            SWFileSplitContainer.Panel2.ResumeLayout(false);
            SWFileSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SWFileSplitContainer).EndInit();
            SWFileSplitContainer.ResumeLayout(false);
            SWDWGSplitContainer.Panel1.ResumeLayout(false);
            SWDWGSplitContainer.Panel2.ResumeLayout(false);
            SWDWGSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SWDWGSplitContainer).EndInit();
            SWDWGSplitContainer.ResumeLayout(false);
            DWGPDFSplitContainer.Panel1.ResumeLayout(false);
            DWGPDFSplitContainer.Panel2.ResumeLayout(false);
            DWGPDFSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DWGPDFSplitContainer).EndInit();
            DWGPDFSplitContainer.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private SplitContainer splitContainerMain;
        private TabControl tabControl;
        private TabPage propertiesPage;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingsMenu;
        private TabPage whereUsedPage;
        private TableLayoutPanel propertiesTableLayoutPanel;
        private Label partNumberLabel;
        private Label revisionLabel;
        private Label titleLabel;
        private Label statusLabel;
        private Label materialLabel;
        private Label vendorPNLabel;
        private Label descriptionLabel;
        private Label originLabel;
        private Label vendorLabel;
        private TabPage referencesPage;
        private TextBox partNumberTextBox;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label notesLabel;
        private ComboBox originComboBox;
        private TextBox manufacturerTextBox;
        private TextBox manufacturerPNTextBox;
        private TextBox materialTextBox;
        private ComboBox statusComboBox;
        private SplitContainer revisionSplitContainer;
        private TextBox revisionTextBox;
        private DateTimePicker revisionDateTimePicker;
        private TextBox notesTextBox;
        private ToolStripStatusLabel localFilepathToolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripSplitButton editPropertiesSplitButton;
        private TabPage previewPage;
        private ToolStripMenuItem enableEditingToolStripMenuItem;
        private ToolStripMenuItem saveChangesToolStripMenuItem;
        private ToolStripMenuItem discardChangesToolStripMenuItem;
        private ListView whereUsedListView;
        private ColumnHeader whereUsedPartNumberColumnHeader;
        private ColumnHeader whereUsedTitleColumnHeader;
        private ColumnHeader whereUsedRevisionColumnHeader;
        private ToolStripMenuItem minioToolStripMenuItem;
        private ToolStripMenuItem authenticationToolStripMenuItem;
        private TableLayoutPanel whereUsedTableLayoutPanel;
        private Label SWFileLabel;
        private Label SWDWGLabel;
        private Label DWGPDFLabel;
        private SplitContainer SWFileSplitContainer;
        private Button SWFileOpenButton;
        private TextBox SWFileFilepathTextBox;
        private SplitContainer SWDWGSplitContainer;
        private Button SWDWGOpenButton;
        private TextBox SWDWGFilepathTextBox;
        private SplitContainer DWGPDFSplitContainer;
        private TextBox DWGPDFFilepathTextBox;
        private Button DWGPDFOpenButton;
        private ListView revisionReferencesListView;
        private Label revisionReferencesLabel;
        private ToolStripStatusLabel localFilepathLabelToolStripStatusLabel;
        private ToolStripStatusLabel serverToolStripStatusLabel;
        private TabControl treeTabControl;
        private TabPage projectTabPage;
        private TabPage componentTabPage;
        private TreeView componentTreeView;
        private TreeView projectTreeView;
        private ImageList treeViewImageList;
        private ToolStripComboBox projectListToolStripComboBox;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem newComponentToolStripMenuItem;
    }
}