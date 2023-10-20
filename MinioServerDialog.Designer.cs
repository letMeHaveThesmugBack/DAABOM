namespace DAABOM
{
    partial class MinioServerDialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            serverLabel = new Label();
            serverTextBox = new TextBox();
            buttonTableLayoutPanel = new TableLayoutPanel();
            connectButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            buttonTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(passwordTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(usernameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(serverLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(serverTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonTableLayoutPanel, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(304, 124);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Location = new Point(79, 65);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(222, 25);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Location = new Point(79, 34);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(222, 25);
            usernameTextBox.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Location = new Point(3, 62);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 31);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.Location = new Point(3, 31);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(70, 31);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serverLabel
            // 
            serverLabel.AutoSize = true;
            serverLabel.Dock = DockStyle.Fill;
            serverLabel.Location = new Point(3, 0);
            serverLabel.Name = "serverLabel";
            serverLabel.Size = new Size(70, 31);
            serverLabel.TabIndex = 0;
            serverLabel.Text = "Server:";
            serverLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serverTextBox
            // 
            serverTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            serverTextBox.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            serverTextBox.Dock = DockStyle.Fill;
            serverTextBox.Location = new Point(79, 3);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(222, 25);
            serverTextBox.TabIndex = 5;
            // 
            // buttonTableLayoutPanel
            // 
            buttonTableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(buttonTableLayoutPanel, 2);
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.Controls.Add(connectButton, 0, 0);
            buttonTableLayoutPanel.Controls.Add(cancelButton, 1, 0);
            buttonTableLayoutPanel.Dock = DockStyle.Fill;
            buttonTableLayoutPanel.Location = new Point(0, 93);
            buttonTableLayoutPanel.Margin = new Padding(0);
            buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            buttonTableLayoutPanel.RowCount = 1;
            buttonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.Size = new Size(304, 31);
            buttonTableLayoutPanel.TabIndex = 8;
            // 
            // connectButton
            // 
            connectButton.Dock = DockStyle.Fill;
            connectButton.Location = new Point(3, 3);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(146, 25);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(155, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(146, 25);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // MinioServerDialog
            // 
            AcceptButton = connectButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(304, 124);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MinioServerDialog";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DAABOM Minio Server Selection";
            TopMost = true;
            Load += MinioServerDialog_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label serverLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox serverTextBox;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private TableLayoutPanel buttonTableLayoutPanel;
        private Button connectButton;
        private Button cancelButton;
    }
}