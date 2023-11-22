namespace DAABOM
{
    partial class NewProjectDialog
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
            tableLayoutPanel = new TableLayoutPanel();
            buttonTableLayoutPanel = new TableLayoutPanel();
            cancelButton = new Button();
            createButton = new Button();
            projectNameLabel = new Label();
            projectNameTextBox = new TextBox();
            tableLayoutPanel.SuspendLayout();
            buttonTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel.Controls.Add(buttonTableLayoutPanel, 0, 1);
            tableLayoutPanel.Controls.Add(projectNameLabel, 0, 0);
            tableLayoutPanel.Controls.Add(projectNameTextBox, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(304, 62);
            tableLayoutPanel.TabIndex = 0;
            // 
            // buttonTableLayoutPanel
            // 
            buttonTableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.SetColumnSpan(buttonTableLayoutPanel, 2);
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.Controls.Add(cancelButton, 1, 0);
            buttonTableLayoutPanel.Controls.Add(createButton, 0, 0);
            buttonTableLayoutPanel.Dock = DockStyle.Fill;
            buttonTableLayoutPanel.Location = new Point(0, 31);
            buttonTableLayoutPanel.Margin = new Padding(0);
            buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            buttonTableLayoutPanel.RowCount = 1;
            buttonTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonTableLayoutPanel.Size = new Size(304, 31);
            buttonTableLayoutPanel.TabIndex = 9;
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
            // 
            // createButton
            // 
            createButton.Dock = DockStyle.Fill;
            createButton.Location = new Point(3, 3);
            createButton.Name = "createButton";
            createButton.Size = new Size(146, 25);
            createButton.TabIndex = 2;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Dock = DockStyle.Fill;
            projectNameLabel.Location = new Point(3, 0);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(70, 31);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Name:";
            projectNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Dock = DockStyle.Fill;
            projectNameTextBox.Location = new Point(79, 3);
            projectNameTextBox.MaxLength = 24;
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(222, 25);
            projectNameTextBox.TabIndex = 1;
            // 
            // NewProjectDialog
            // 
            AcceptButton = createButton;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(304, 62);
            ControlBox = false;
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewProjectDialog";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New DAABOM Project";
            TopMost = true;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            buttonTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label projectNameLabel;
        private TextBox projectNameTextBox;
        private TableLayoutPanel buttonTableLayoutPanel;
        private Button cancelButton;
        private Button createButton;
    }
}