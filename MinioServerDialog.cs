using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DAABOM
{
    public partial class MinioServerDialog : Form
    {
        internal CancellationTokenSource cancellationTokenSource = new();

        public MinioServerDialog()
        {
            InitializeComponent();
        }

        internal string server { get => serverTextBox.Text; }

        private void MinioServerDialog_Load(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Program.OpenClient(new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text, serverTextBox.Text), this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        internal void SetWaitingState(bool isWaiting)
        {
            if (isWaiting)
            {
                Cursor = Cursors.WaitCursor;
            }

            else
            {
                Cursor = Cursors.Default;
            }

            connectButton.Enabled = !isWaiting;
            serverTextBox.Enabled = !isWaiting;
            usernameTextBox.Enabled = !isWaiting;
            passwordTextBox.Enabled = !isWaiting;
        }
    }
}