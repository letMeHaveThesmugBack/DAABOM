using DAABOM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minio.DataModel;

namespace DAABOM
{
    public partial class DataBrowser : Form
    {
        public DataBrowser(bool isConnected)
        {
            InitializeComponent();
            UpdateConnectionIcon(isConnected);
        }

        private void DataBrowser_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void originLabel_Click(object sender, EventArgs e)
        {

        }

        private void originTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enableEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal void UpdateConnectionIcon(bool isConnected)
        {
            serverToolStripStatusLabel.Image =
                isConnected ? Resources.network_drive_world_1 : Resources.network_drive_unavailable_1;

            string workingBucketName = Program.workingBucket is not null ? Program.workingBucket.Name : "Error! Null Bucket!";

            serverToolStripStatusLabel.ToolTipText =
                isConnected ? $"Connected to {Program.connectedServer} bucket \"{workingBucketName}\"" :
                "Local mode";
        }
    }
}
