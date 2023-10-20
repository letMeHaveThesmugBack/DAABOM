using Minio.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAABOM
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            workingFolderTextBox.Text = Program.workingFolderPath = Properties.Settings.Default.WorkingFolder;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            launchLocalButton.Enabled = false;
            launchOnlineButton.Enabled = false;
            minioServerChooseButton.Enabled = false;
            minioBucketComboBox.Enabled = false;

            Program.onClientClosed += ClearMinioFields;
        }

        private void workingFolderChooseButton_Click(object sender, EventArgs e)
        {
            if (workingFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.WorkingFolder = workingFolderBrowserDialog.SelectedPath;
                workingFolderTextBox.Text = workingFolderBrowserDialog.SelectedPath;

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
    }
}