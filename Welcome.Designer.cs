namespace DAABOM
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            workingFolderBrowserDialog = new FolderBrowserDialog();
            logoPictureBox = new PictureBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            workingFolderLabel = new Label();
            workingFolderTextBox = new TextBox();
            workingFolderChooseButton = new Button();
            minioServerLabel = new Label();
            minioServerChooseButton = new Button();
            minioServerTextBox = new TextBox();
            minioBucketComboBox = new ComboBox();
            launchButtonsTableLayoutPanel = new TableLayoutPanel();
            launchOnlineButton = new Button();
            launchLocalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            launchButtonsTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // workingFolderBrowserDialog
            // 
            workingFolderBrowserDialog.Description = "This folder may be completely cleared. Do not choose a folder containing information you are afraid of losing.";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Dock = DockStyle.Top;
            logoPictureBox.Image = Properties.Resources.DAABOMLogo;
            logoPictureBox.Location = new Point(0, 0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(240, 55);
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Controls.Add(workingFolderLabel, 0, 0);
            mainTableLayoutPanel.Controls.Add(workingFolderTextBox, 0, 1);
            mainTableLayoutPanel.Controls.Add(workingFolderChooseButton, 1, 0);
            mainTableLayoutPanel.Controls.Add(minioServerLabel, 0, 2);
            mainTableLayoutPanel.Controls.Add(minioServerChooseButton, 1, 2);
            mainTableLayoutPanel.Controls.Add(minioServerTextBox, 0, 3);
            mainTableLayoutPanel.Controls.Add(minioBucketComboBox, 0, 4);
            mainTableLayoutPanel.Dock = DockStyle.Top;
            mainTableLayoutPanel.Location = new Point(0, 55);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 5;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.Size = new Size(240, 156);
            mainTableLayoutPanel.TabIndex = 1;
            // 
            // workingFolderLabel
            // 
            workingFolderLabel.AutoSize = true;
            workingFolderLabel.Dock = DockStyle.Fill;
            workingFolderLabel.Location = new Point(3, 0);
            workingFolderLabel.Name = "workingFolderLabel";
            workingFolderLabel.Size = new Size(114, 31);
            workingFolderLabel.TabIndex = 0;
            workingFolderLabel.Text = "Working Folder";
            workingFolderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // workingFolderTextBox
            // 
            mainTableLayoutPanel.SetColumnSpan(workingFolderTextBox, 2);
            workingFolderTextBox.Dock = DockStyle.Fill;
            workingFolderTextBox.Enabled = false;
            workingFolderTextBox.Location = new Point(3, 34);
            workingFolderTextBox.Name = "workingFolderTextBox";
            workingFolderTextBox.ReadOnly = true;
            workingFolderTextBox.Size = new Size(234, 25);
            workingFolderTextBox.TabIndex = 1;
            // 
            // workingFolderChooseButton
            // 
            workingFolderChooseButton.Dock = DockStyle.Fill;
            workingFolderChooseButton.Location = new Point(123, 3);
            workingFolderChooseButton.Name = "workingFolderChooseButton";
            workingFolderChooseButton.Size = new Size(114, 25);
            workingFolderChooseButton.TabIndex = 2;
            workingFolderChooseButton.Text = "Choose &Folder";
            workingFolderChooseButton.UseVisualStyleBackColor = true;
            workingFolderChooseButton.Click += workingFolderChooseButton_Click;
            // 
            // minioServerLabel
            // 
            minioServerLabel.AutoSize = true;
            minioServerLabel.Dock = DockStyle.Fill;
            minioServerLabel.Location = new Point(3, 62);
            minioServerLabel.Name = "minioServerLabel";
            minioServerLabel.Size = new Size(114, 31);
            minioServerLabel.TabIndex = 3;
            minioServerLabel.Text = "Minio Server";
            minioServerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minioServerChooseButton
            // 
            minioServerChooseButton.Dock = DockStyle.Fill;
            minioServerChooseButton.Location = new Point(123, 65);
            minioServerChooseButton.Name = "minioServerChooseButton";
            minioServerChooseButton.Size = new Size(114, 25);
            minioServerChooseButton.TabIndex = 4;
            minioServerChooseButton.Text = "Choose &Server";
            minioServerChooseButton.UseVisualStyleBackColor = true;
            minioServerChooseButton.Click += minioServerChooseButton_Click;
            // 
            // minioServerTextBox
            // 
            mainTableLayoutPanel.SetColumnSpan(minioServerTextBox, 2);
            minioServerTextBox.Dock = DockStyle.Fill;
            minioServerTextBox.Enabled = false;
            minioServerTextBox.Location = new Point(3, 96);
            minioServerTextBox.Name = "minioServerTextBox";
            minioServerTextBox.ReadOnly = true;
            minioServerTextBox.Size = new Size(234, 25);
            minioServerTextBox.TabIndex = 5;
            // 
            // minioBucketComboBox
            // 
            mainTableLayoutPanel.SetColumnSpan(minioBucketComboBox, 2);
            minioBucketComboBox.Dock = DockStyle.Fill;
            minioBucketComboBox.FormattingEnabled = true;
            minioBucketComboBox.Location = new Point(3, 127);
            minioBucketComboBox.Name = "minioBucketComboBox";
            minioBucketComboBox.Size = new Size(234, 25);
            minioBucketComboBox.TabIndex = 6;
            // 
            // launchButtonsTableLayoutPanel
            // 
            launchButtonsTableLayoutPanel.ColumnCount = 2;
            launchButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            launchButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            launchButtonsTableLayoutPanel.Controls.Add(launchOnlineButton, 0, 0);
            launchButtonsTableLayoutPanel.Controls.Add(launchLocalButton, 1, 0);
            launchButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            launchButtonsTableLayoutPanel.Location = new Point(0, 211);
            launchButtonsTableLayoutPanel.Name = "launchButtonsTableLayoutPanel";
            launchButtonsTableLayoutPanel.RowCount = 1;
            launchButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            launchButtonsTableLayoutPanel.Size = new Size(240, 28);
            launchButtonsTableLayoutPanel.TabIndex = 2;
            // 
            // launchOnlineButton
            // 
            launchOnlineButton.Dock = DockStyle.Fill;
            launchOnlineButton.Location = new Point(3, 0);
            launchOnlineButton.Margin = new Padding(3, 0, 3, 3);
            launchOnlineButton.Name = "launchOnlineButton";
            launchOnlineButton.Size = new Size(114, 25);
            launchOnlineButton.TabIndex = 0;
            launchOnlineButton.Text = "Launch Online";
            launchOnlineButton.UseVisualStyleBackColor = true;
            // 
            // launchLocalButton
            // 
            launchLocalButton.Dock = DockStyle.Fill;
            launchLocalButton.Location = new Point(123, 0);
            launchLocalButton.Margin = new Padding(3, 0, 3, 3);
            launchLocalButton.Name = "launchLocalButton";
            launchLocalButton.Size = new Size(114, 25);
            launchLocalButton.TabIndex = 1;
            launchLocalButton.Text = "Launch Local";
            launchLocalButton.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AccessibleDescription = "DAABOM login and settings window";
            AccessibleName = "DAABOM Welcome";
            AccessibleRole = AccessibleRole.Window;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 239);
            Controls.Add(launchButtonsTableLayoutPanel);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(logoPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DAABOM";
            Load += Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            launchButtonsTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog workingFolderBrowserDialog;
        private PictureBox logoPictureBox;
        private TableLayoutPanel mainTableLayoutPanel;
        private Label workingFolderLabel;
        private TextBox workingFolderTextBox;
        private Button workingFolderChooseButton;
        private Label minioServerLabel;
        private Button minioServerChooseButton;
        private TextBox minioServerTextBox;
        private TableLayoutPanel launchButtonsTableLayoutPanel;
        private Button launchOnlineButton;
        private Button launchLocalButton;
        private ComboBox minioBucketComboBox;
    }
}