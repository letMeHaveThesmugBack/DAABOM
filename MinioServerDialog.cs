using DAABOM.Properties;
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
            serverTextBox.Text = Program.connectedServer ?? Settings.Default.MinioServer;
            usernameTextBox.Text = Program.username ?? Settings.Default.Username;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Program.OpenClient(new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text, serverTextBox.Text), this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        internal void SetWaitingState(bool waiting)
        {
            Cursor = waiting ? Cursors.WaitCursor : Cursors.Default;

            connectButton.Enabled = !waiting;
            serverTextBox.Enabled = !waiting;
            usernameTextBox.Enabled = !waiting;
            passwordTextBox.Enabled = !waiting;
        }
    }
}