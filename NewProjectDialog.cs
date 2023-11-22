namespace DAABOM
{
    internal partial class NewProjectDialog : Form
    {
        internal NewProjectDialog(ReadWriter readWriter, DataBrowser callingForm)
        {
            InitializeComponent();

            RW = readWriter;
            caller = callingForm;
        }

        private readonly ReadWriter RW;
        private readonly DataBrowser caller;

        private void createButton_Click(object sender, EventArgs e)
        {
            Project? project = RW.CreateProject(projectNameTextBox.Text);
            Close();

            if (project is not null)
            {
                MessageBox.Show($"""Successfully created project "{project.Metadata.Name}" with GUID {project.Metadata.GUID} !""", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error creating project."); // Make better
            }

            caller.RepopulateProjectList();
        }
    }
}
