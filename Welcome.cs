using DAABOM.Properties;
using System.Diagnostics;

namespace DAABOM
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            launchLocalButton.Enabled = false;
            launchOnlineButton.Enabled = false;
            minioServerChooseButton.Enabled = false;
            minioBucketComboBox.Enabled = false;

            workingFolderTextBox.Text = Program.workingFolderPath = Settings.Default.WorkingFolder;

            Program.onClientClosed += ClearMinioFields;
        }

        private void workingFolderChooseButton_Click(object sender, EventArgs e)
        {
            if (workingFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Program.workingFolderPath =
                    workingFolderTextBox.Text =
                    Settings.Default.WorkingFolder =
                    workingFolderBrowserDialog.SelectedPath;

                launchLocalButton.Enabled = true;
                minioServerChooseButton.Enabled = true;
            }
        }

        private void minioServerChooseButton_Click(object sender, EventArgs e)
        {
            MinioServerDialog serverDialog = new();

            if (serverDialog.ShowDialog() == DialogResult.OK)
            {
                minioServerTextBox.Text = serverDialog.server;
                launchOnlineButton.Enabled = true;
                minioBucketComboBox.Enabled = true;

                minioBucketComboBox.Items.Clear();
                foreach (string bucketName in Program.bucketDictionary.Keys) minioBucketComboBox.Items.Add(bucketName);

                minioBucketComboBox.SelectedIndex = 0;
            }
        }

        private void ClearMinioFields()
        {
            minioServerTextBox.Text = string.Empty;
            minioBucketComboBox.Items.Clear();
            minioBucketComboBox.Text = string.Empty;
            launchOnlineButton.Enabled = false;
            minioBucketComboBox.Enabled = false;
        }

        private void launchLocalButton_Click(object sender, EventArgs e)
        {
            DataBrowser browser = new(false);
            browser.Show();
        }

        private void launchOnlineButton_Click(object sender, EventArgs e)
        {
            Program.workingBucket = Program.bucketDictionary[minioBucketComboBox.Text];

            DataBrowser browser = new(true);
            browser.Show();
        }
    }
}