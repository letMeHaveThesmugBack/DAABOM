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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBrowser));
            statusStrip = new StatusStrip();
            projectToolStripStatusLabel = new ToolStripStatusLabel();
            projectNameToolStripStatusLabel = new ToolStripStatusLabel();
            localToolStripStatusLabel = new ToolStripStatusLabel();
            localFilepathToolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            editPropertiesSplitButton = new ToolStripSplitButton();
            enableEditingToolStripMenuItem = new ToolStripMenuItem();
            saveChangesToolStripMenuItem = new ToolStripMenuItem();
            discardChangesToolStripMenuItem = new ToolStripMenuItem();
            serverToolStripStatusLabel = new ToolStripStatusLabel();
            splitContainerMain = new SplitContainer();
            splitContainerLeft = new SplitContainer();
            projectComboBox = new ComboBox();
            projectTreeView = new TreeView();
            tabControl = new TabControl();
            propertiesPage = new TabPage();
            propertiesTableLayoutPanel = new TableLayoutPanel();
            notesLabel = new Label();
            manufacturerLabel = new Label();
            originLabel = new Label();
            descriptionLabel = new Label();
            revisionLabel = new Label();
            titleLabel = new Label();
            statusLabel = new Label();
            materialLabel = new Label();
            manufacturerPNLabel = new Label();
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
            splitContainerRevision = new SplitContainer();
            revisionTextBox = new TextBox();
            revisionDateTimePicker = new DateTimePicker();
            revisionsPage = new TabPage();
            revisionsListView = new ListView();
            revisionsRevisionColumnHeader = new ColumnHeader();
            revisionsRevisionDateColumnHeader = new ColumnHeader();
            revisionsFilepathColumnHeader = new ColumnHeader();
            usagePage = new TabPage();
            usageListView = new ListView();
            usagePartNumberColumnHeader = new ColumnHeader();
            usageTitleColumnHeader = new ColumnHeader();
            usageRevisionColumnHeader = new ColumnHeader();
            dataPage = new TabPage();
            dataTableLayoutPanel = new TableLayoutPanel();
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
            commonReferencesListView = new ListView();
            revisionReferencesListView = new ListView();
            commonReferencesLabel = new Label();
            revisionReferencesLabel = new Label();
            previewPage = new TabPage();
            menuStrip = new MenuStrip();
            projectToolStripMenuItem = new ToolStripMenuItem();
            selectProjectToolStripMenuItem = new ToolStripMenuItem();
            settingsMenu = new ToolStripMenuItem();
            minioToolStripMenuItem = new ToolStripMenuItem();
            authenticationToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerLeft).BeginInit();
            splitContainerLeft.Panel1.SuspendLayout();
            splitContainerLeft.Panel2.SuspendLayout();
            splitContainerLeft.SuspendLayout();
            tabControl.SuspendLayout();
            propertiesPage.SuspendLayout();
            propertiesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerRevision).BeginInit();
            splitContainerRevision.Panel1.SuspendLayout();
            splitContainerRevision.Panel2.SuspendLayout();
            splitContainerRevision.SuspendLayout();
            revisionsPage.SuspendLayout();
            usagePage.SuspendLayout();
            dataPage.SuspendLayout();
            dataTableLayoutPanel.SuspendLayout();
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
            statusStrip.Items.AddRange(new ToolStripItem[] { projectToolStripStatusLabel, projectNameToolStripStatusLabel, localToolStripStatusLabel, localFilepathToolStripStatusLabel, toolStripProgressBar, editPropertiesSplitButton, serverToolStripStatusLabel });
            statusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip.Location = new Point(0, 575);
            statusStrip.Name = "statusStrip";
            statusStrip.ShowItemToolTips = true;
            statusStrip.Size = new Size(1008, 24);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // projectToolStripStatusLabel
            // 
            projectToolStripStatusLabel.Name = "projectToolStripStatusLabel";
            projectToolStripStatusLabel.Size = new Size(51, 19);
            projectToolStripStatusLabel.Text = "Project:";
            // 
            // projectNameToolStripStatusLabel
            // 
            projectNameToolStripStatusLabel.AutoSize = false;
            projectNameToolStripStatusLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
            projectNameToolStripStatusLabel.Margin = new Padding(0, 3, 6, 2);
            projectNameToolStripStatusLabel.Name = "projectNameToolStripStatusLabel";
            projectNameToolStripStatusLabel.Size = new Size(280, 19);
            projectNameToolStripStatusLabel.Text = "?";
            projectNameToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // localToolStripStatusLabel
            // 
            localToolStripStatusLabel.Name = "localToolStripStatusLabel";
            localToolStripStatusLabel.Size = new Size(90, 19);
            localToolStripStatusLabel.Text = "Local Filepath:";
            // 
            // localFilepathToolStripStatusLabel
            // 
            localFilepathToolStripStatusLabel.AutoSize = false;
            localFilepathToolStripStatusLabel.IsLink = true;
            localFilepathToolStripStatusLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
            localFilepathToolStripStatusLabel.Margin = new Padding(0, 3, 6, 2);
            localFilepathToolStripStatusLabel.Name = "localFilepathToolStripStatusLabel";
            localFilepathToolStripStatusLabel.Size = new Size(400, 19);
            localFilepathToolStripStatusLabel.Text = "?";
            localFilepathToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 18);
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
            editPropertiesSplitButton.Text = "Edit Properties";
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
            discardChangesToolStripMenuItem.Click += enableEditingToolStripMenuItem_Click;
            // 
            // serverToolStripStatusLabel
            // 
            serverToolStripStatusLabel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            serverToolStripStatusLabel.Image = Properties.Resources.network_drive_unavailable_1;
            serverToolStripStatusLabel.ImageScaling = ToolStripItemImageScaling.None;
            serverToolStripStatusLabel.Name = "serverToolStripStatusLabel";
            serverToolStripStatusLabel.Size = new Size(16, 19);
            serverToolStripStatusLabel.Text = "Server";
            // 
            // splitContainerMain
            // 
            splitContainerMain.BorderStyle = BorderStyle.Fixed3D;
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 25);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(splitContainerLeft);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(tabControl);
            splitContainerMain.Size = new Size(1008, 550);
            splitContainerMain.SplitterDistance = 336;
            splitContainerMain.TabIndex = 1;
            // 
            // splitContainerLeft
            // 
            splitContainerLeft.BorderStyle = BorderStyle.Fixed3D;
            splitContainerLeft.Dock = DockStyle.Fill;
            splitContainerLeft.FixedPanel = FixedPanel.Panel1;
            splitContainerLeft.IsSplitterFixed = true;
            splitContainerLeft.Location = new Point(0, 0);
            splitContainerLeft.Name = "splitContainerLeft";
            splitContainerLeft.Orientation = Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            splitContainerLeft.Panel1.Controls.Add(projectComboBox);
            // 
            // splitContainerLeft.Panel2
            // 
            splitContainerLeft.Panel2.Controls.Add(projectTreeView);
            splitContainerLeft.Size = new Size(336, 550);
            splitContainerLeft.SplitterDistance = 25;
            splitContainerLeft.TabIndex = 0;
            // 
            // projectComboBox
            // 
            projectComboBox.Dock = DockStyle.Fill;
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(0, 0);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(332, 25);
            projectComboBox.TabIndex = 0;
            projectComboBox.SelectedIndexChanged += projectComboBox_SelectedIndexChanged;
            // 
            // projectTreeView
            // 
            projectTreeView.Dock = DockStyle.Fill;
            projectTreeView.Location = new Point(0, 0);
            projectTreeView.Name = "projectTreeView";
            projectTreeView.Size = new Size(332, 517);
            projectTreeView.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(propertiesPage);
            tabControl.Controls.Add(revisionsPage);
            tabControl.Controls.Add(usagePage);
            tabControl.Controls.Add(dataPage);
            tabControl.Controls.Add(previewPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(664, 546);
            tabControl.TabIndex = 0;
            // 
            // propertiesPage
            // 
            propertiesPage.Controls.Add(propertiesTableLayoutPanel);
            propertiesPage.Location = new Point(4, 26);
            propertiesPage.Name = "propertiesPage";
            propertiesPage.Padding = new Padding(3);
            propertiesPage.Size = new Size(656, 516);
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
            propertiesTableLayoutPanel.Controls.Add(manufacturerLabel, 0, 6);
            propertiesTableLayoutPanel.Controls.Add(originLabel, 0, 5);
            propertiesTableLayoutPanel.Controls.Add(descriptionLabel, 0, 2);
            propertiesTableLayoutPanel.Controls.Add(revisionLabel, 0, 3);
            propertiesTableLayoutPanel.Controls.Add(titleLabel, 0, 1);
            propertiesTableLayoutPanel.Controls.Add(statusLabel, 0, 9);
            propertiesTableLayoutPanel.Controls.Add(materialLabel, 0, 8);
            propertiesTableLayoutPanel.Controls.Add(manufacturerPNLabel, 0, 7);
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
            propertiesTableLayoutPanel.Controls.Add(splitContainerRevision, 1, 3);
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
            propertiesTableLayoutPanel.Size = new Size(650, 510);
            propertiesTableLayoutPanel.TabIndex = 0;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Dock = DockStyle.Fill;
            notesLabel.Location = new Point(3, 279);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new Size(319, 233);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes";
            notesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Dock = DockStyle.Fill;
            manufacturerLabel.Location = new Point(3, 155);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(319, 31);
            manufacturerLabel.TabIndex = 18;
            manufacturerLabel.Text = "Manufacturer";
            manufacturerLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            originLabel.Click += originLabel_Click;
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
            // manufacturerPNLabel
            // 
            manufacturerPNLabel.AutoSize = true;
            manufacturerPNLabel.Dock = DockStyle.Fill;
            manufacturerPNLabel.Location = new Point(3, 186);
            manufacturerPNLabel.Name = "manufacturerPNLabel";
            manufacturerPNLabel.Size = new Size(319, 31);
            manufacturerPNLabel.TabIndex = 6;
            manufacturerPNLabel.Text = "Manufacturer Part Number";
            manufacturerPNLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            partNumberLabel.Click += label1_Click_1;
            // 
            // partNumberTextBox
            // 
            partNumberTextBox.Dock = DockStyle.Fill;
            partNumberTextBox.Location = new Point(328, 3);
            partNumberTextBox.MaxLength = 9;
            partNumberTextBox.Name = "partNumberTextBox";
            partNumberTextBox.Size = new Size(319, 25);
            partNumberTextBox.TabIndex = 20;
            // 
            // titleTextBox
            // 
            titleTextBox.Dock = DockStyle.Fill;
            titleTextBox.Location = new Point(328, 34);
            titleTextBox.MaxLength = 42;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(319, 25);
            titleTextBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(328, 65);
            descriptionTextBox.MaxLength = 42;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(319, 25);
            descriptionTextBox.TabIndex = 22;
            // 
            // originComboBox
            // 
            originComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Make", "Buy", "Modify" });
            originComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            originComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            originComboBox.Dock = DockStyle.Fill;
            originComboBox.FormattingEnabled = true;
            originComboBox.Items.AddRange(new object[] { "Make", "Buy", "Modify" });
            originComboBox.Location = new Point(328, 127);
            originComboBox.Name = "originComboBox";
            originComboBox.Size = new Size(319, 25);
            originComboBox.TabIndex = 23;
            originComboBox.SelectedIndexChanged += originTextBox_SelectedIndexChanged;
            // 
            // manufacturerTextBox
            // 
            manufacturerTextBox.Dock = DockStyle.Fill;
            manufacturerTextBox.Location = new Point(328, 158);
            manufacturerTextBox.MaxLength = 42;
            manufacturerTextBox.Name = "manufacturerTextBox";
            manufacturerTextBox.Size = new Size(319, 25);
            manufacturerTextBox.TabIndex = 24;
            // 
            // manufacturerPNTextBox
            // 
            manufacturerPNTextBox.Dock = DockStyle.Fill;
            manufacturerPNTextBox.Location = new Point(328, 189);
            manufacturerPNTextBox.MaxLength = 42;
            manufacturerPNTextBox.Name = "manufacturerPNTextBox";
            manufacturerPNTextBox.Size = new Size(319, 25);
            manufacturerPNTextBox.TabIndex = 25;
            // 
            // materialTextBox
            // 
            materialTextBox.Dock = DockStyle.Fill;
            materialTextBox.Location = new Point(328, 220);
            materialTextBox.MaxLength = 42;
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(319, 25);
            materialTextBox.TabIndex = 26;
            // 
            // statusComboBox
            // 
            statusComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Finished", "Manufacturing / Assembly", "Design Complete", "Design In Progress", "Design Not Started", "Old Revision", "Obsolete" });
            statusComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            statusComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            statusComboBox.Dock = DockStyle.Fill;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Finished", "Manufacturing / Assembly", "Design Complete", "Design In Progress", "Design Not Started", "Obsolete" });
            statusComboBox.Location = new Point(328, 251);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(319, 25);
            statusComboBox.TabIndex = 27;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // notesTextBox
            // 
            notesTextBox.Dock = DockStyle.Fill;
            notesTextBox.Location = new Point(328, 282);
            notesTextBox.MaxLength = 420;
            notesTextBox.Multiline = true;
            notesTextBox.Name = "notesTextBox";
            notesTextBox.Size = new Size(319, 227);
            notesTextBox.TabIndex = 28;
            // 
            // splitContainerRevision
            // 
            splitContainerRevision.Dock = DockStyle.Fill;
            splitContainerRevision.FixedPanel = FixedPanel.Panel1;
            splitContainerRevision.IsSplitterFixed = true;
            splitContainerRevision.Location = new Point(328, 96);
            splitContainerRevision.Name = "splitContainerRevision";
            // 
            // splitContainerRevision.Panel1
            // 
            splitContainerRevision.Panel1.Controls.Add(revisionTextBox);
            // 
            // splitContainerRevision.Panel2
            // 
            splitContainerRevision.Panel2.Controls.Add(revisionDateTimePicker);
            splitContainerRevision.Size = new Size(319, 25);
            splitContainerRevision.TabIndex = 29;
            // 
            // revisionTextBox
            // 
            revisionTextBox.Dock = DockStyle.Fill;
            revisionTextBox.Location = new Point(0, 0);
            revisionTextBox.MaxLength = 5;
            revisionTextBox.Name = "revisionTextBox";
            revisionTextBox.ReadOnly = true;
            revisionTextBox.Size = new Size(50, 25);
            revisionTextBox.TabIndex = 0;
            revisionTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // revisionDateTimePicker
            // 
            revisionDateTimePicker.Dock = DockStyle.Fill;
            revisionDateTimePicker.Enabled = false;
            revisionDateTimePicker.Location = new Point(0, 0);
            revisionDateTimePicker.Name = "revisionDateTimePicker";
            revisionDateTimePicker.Size = new Size(265, 25);
            revisionDateTimePicker.TabIndex = 0;
            // 
            // revisionsPage
            // 
            revisionsPage.Controls.Add(revisionsListView);
            revisionsPage.Location = new Point(4, 26);
            revisionsPage.Name = "revisionsPage";
            revisionsPage.Padding = new Padding(3);
            revisionsPage.Size = new Size(656, 516);
            revisionsPage.TabIndex = 1;
            revisionsPage.Text = "Revisions";
            revisionsPage.UseVisualStyleBackColor = true;
            // 
            // revisionsListView
            // 
            revisionsListView.Columns.AddRange(new ColumnHeader[] { revisionsRevisionColumnHeader, revisionsRevisionDateColumnHeader, revisionsFilepathColumnHeader });
            revisionsListView.Dock = DockStyle.Fill;
            revisionsListView.Location = new Point(3, 3);
            revisionsListView.MultiSelect = false;
            revisionsListView.Name = "revisionsListView";
            revisionsListView.Size = new Size(650, 510);
            revisionsListView.TabIndex = 0;
            revisionsListView.UseCompatibleStateImageBehavior = false;
            revisionsListView.View = View.Details;
            // 
            // revisionsRevisionColumnHeader
            // 
            revisionsRevisionColumnHeader.Text = "Revision";
            revisionsRevisionColumnHeader.Width = 64;
            // 
            // revisionsRevisionDateColumnHeader
            // 
            revisionsRevisionDateColumnHeader.Text = "Revision Date";
            revisionsRevisionDateColumnHeader.Width = 121;
            // 
            // revisionsFilepathColumnHeader
            // 
            revisionsFilepathColumnHeader.Text = "Filepath";
            revisionsFilepathColumnHeader.Width = 461;
            // 
            // usagePage
            // 
            usagePage.Controls.Add(usageListView);
            usagePage.Location = new Point(4, 26);
            usagePage.Name = "usagePage";
            usagePage.Padding = new Padding(3);
            usagePage.Size = new Size(656, 516);
            usagePage.TabIndex = 2;
            usagePage.Text = "Usage";
            usagePage.UseVisualStyleBackColor = true;
            // 
            // usageListView
            // 
            usageListView.Columns.AddRange(new ColumnHeader[] { usagePartNumberColumnHeader, usageTitleColumnHeader, usageRevisionColumnHeader });
            usageListView.Dock = DockStyle.Fill;
            usageListView.Location = new Point(3, 3);
            usageListView.Name = "usageListView";
            usageListView.Size = new Size(650, 510);
            usageListView.TabIndex = 0;
            usageListView.UseCompatibleStateImageBehavior = false;
            usageListView.View = View.Details;
            // 
            // usagePartNumberColumnHeader
            // 
            usagePartNumberColumnHeader.Text = "Part Number";
            usagePartNumberColumnHeader.Width = 292;
            // 
            // usageTitleColumnHeader
            // 
            usageTitleColumnHeader.Text = "Title";
            usageTitleColumnHeader.Width = 292;
            // 
            // usageRevisionColumnHeader
            // 
            usageRevisionColumnHeader.Text = "Revision";
            usageRevisionColumnHeader.Width = 62;
            // 
            // dataPage
            // 
            dataPage.Controls.Add(dataTableLayoutPanel);
            dataPage.Location = new Point(4, 26);
            dataPage.Name = "dataPage";
            dataPage.Padding = new Padding(3);
            dataPage.Size = new Size(656, 516);
            dataPage.TabIndex = 3;
            dataPage.Text = "Data";
            dataPage.UseVisualStyleBackColor = true;
            // 
            // dataTableLayoutPanel
            // 
            dataTableLayoutPanel.ColumnCount = 2;
            dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99667F));
            dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.003334F));
            dataTableLayoutPanel.Controls.Add(SWFileLabel, 0, 0);
            dataTableLayoutPanel.Controls.Add(SWDWGLabel, 0, 1);
            dataTableLayoutPanel.Controls.Add(DWGPDFLabel, 0, 2);
            dataTableLayoutPanel.Controls.Add(SWFileSplitContainer, 1, 0);
            dataTableLayoutPanel.Controls.Add(SWDWGSplitContainer, 1, 1);
            dataTableLayoutPanel.Controls.Add(DWGPDFSplitContainer, 1, 2);
            dataTableLayoutPanel.Controls.Add(commonReferencesListView, 1, 3);
            dataTableLayoutPanel.Controls.Add(revisionReferencesListView, 1, 4);
            dataTableLayoutPanel.Controls.Add(commonReferencesLabel, 0, 3);
            dataTableLayoutPanel.Controls.Add(revisionReferencesLabel, 0, 4);
            dataTableLayoutPanel.Dock = DockStyle.Fill;
            dataTableLayoutPanel.Location = new Point(3, 3);
            dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            dataTableLayoutPanel.RowCount = 5;
            dataTableLayoutPanel.RowStyles.Add(new RowStyle());
            dataTableLayoutPanel.RowStyles.Add(new RowStyle());
            dataTableLayoutPanel.RowStyles.Add(new RowStyle());
            dataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            dataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            dataTableLayoutPanel.Size = new Size(650, 510);
            dataTableLayoutPanel.TabIndex = 0;
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
            // commonReferencesListView
            // 
            commonReferencesListView.Dock = DockStyle.Fill;
            commonReferencesListView.Location = new Point(165, 96);
            commonReferencesListView.Name = "commonReferencesListView";
            commonReferencesListView.Size = new Size(482, 202);
            commonReferencesListView.TabIndex = 6;
            commonReferencesListView.UseCompatibleStateImageBehavior = false;
            // 
            // revisionReferencesListView
            // 
            revisionReferencesListView.Dock = DockStyle.Fill;
            revisionReferencesListView.Location = new Point(165, 304);
            revisionReferencesListView.Name = "revisionReferencesListView";
            revisionReferencesListView.Size = new Size(482, 203);
            revisionReferencesListView.TabIndex = 7;
            revisionReferencesListView.UseCompatibleStateImageBehavior = false;
            // 
            // commonReferencesLabel
            // 
            commonReferencesLabel.AutoSize = true;
            commonReferencesLabel.Dock = DockStyle.Fill;
            commonReferencesLabel.Location = new Point(3, 93);
            commonReferencesLabel.Name = "commonReferencesLabel";
            commonReferencesLabel.Size = new Size(156, 208);
            commonReferencesLabel.TabIndex = 8;
            commonReferencesLabel.Text = "Common References";
            commonReferencesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // revisionReferencesLabel
            // 
            revisionReferencesLabel.AutoSize = true;
            revisionReferencesLabel.Dock = DockStyle.Fill;
            revisionReferencesLabel.Location = new Point(3, 301);
            revisionReferencesLabel.Name = "revisionReferencesLabel";
            revisionReferencesLabel.Size = new Size(156, 209);
            revisionReferencesLabel.TabIndex = 9;
            revisionReferencesLabel.Text = "Revision References";
            revisionReferencesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // previewPage
            // 
            previewPage.Location = new Point(4, 26);
            previewPage.Name = "previewPage";
            previewPage.Padding = new Padding(3);
            previewPage.Size = new Size(656, 516);
            previewPage.TabIndex = 4;
            previewPage.Text = "Preview";
            previewPage.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(18, 18);
            menuStrip.Items.AddRange(new ToolStripItem[] { projectToolStripMenuItem, settingsMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1008, 25);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectProjectToolStripMenuItem });
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(60, 21);
            projectToolStripMenuItem.Text = "Project";
            // 
            // selectProjectToolStripMenuItem
            // 
            selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            selectProjectToolStripMenuItem.Size = new Size(160, 24);
            selectProjectToolStripMenuItem.Text = "Select &Project";
            // 
            // settingsMenu
            // 
            settingsMenu.DropDownItems.AddRange(new ToolStripItem[] { minioToolStripMenuItem, authenticationToolStripMenuItem });
            settingsMenu.Name = "settingsMenu";
            settingsMenu.Size = new Size(66, 21);
            settingsMenu.Text = "Settings";
            settingsMenu.Click += toolStripMenuItem2_Click;
            // 
            // minioToolStripMenuItem
            // 
            minioToolStripMenuItem.Name = "minioToolStripMenuItem";
            minioToolStripMenuItem.Size = new Size(164, 24);
            minioToolStripMenuItem.Text = "Minio";
            // 
            // authenticationToolStripMenuItem
            // 
            authenticationToolStripMenuItem.Name = "authenticationToolStripMenuItem";
            authenticationToolStripMenuItem.Size = new Size(164, 24);
            authenticationToolStripMenuItem.Text = "Authentication";
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
            Load += DataBrowser_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            splitContainerLeft.Panel1.ResumeLayout(false);
            splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerLeft).EndInit();
            splitContainerLeft.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            propertiesPage.ResumeLayout(false);
            propertiesPage.PerformLayout();
            propertiesTableLayoutPanel.ResumeLayout(false);
            propertiesTableLayoutPanel.PerformLayout();
            splitContainerRevision.Panel1.ResumeLayout(false);
            splitContainerRevision.Panel1.PerformLayout();
            splitContainerRevision.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerRevision).EndInit();
            splitContainerRevision.ResumeLayout(false);
            revisionsPage.ResumeLayout(false);
            usagePage.ResumeLayout(false);
            dataPage.ResumeLayout(false);
            dataTableLayoutPanel.ResumeLayout(false);
            dataTableLayoutPanel.PerformLayout();
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
        private TabPage revisionsPage;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingsMenu;
        private TabPage usagePage;
        private SplitContainer splitContainerLeft;
        private ComboBox projectComboBox;
        private TreeView projectTreeView;
        private TableLayoutPanel propertiesTableLayoutPanel;
        private Label partNumberLabel;
        private Label revisionLabel;
        private Label titleLabel;
        private Label statusLabel;
        private Label materialLabel;
        private Label manufacturerPNLabel;
        private Label descriptionLabel;
        private Label originLabel;
        private Label manufacturerLabel;
        private TabPage dataPage;
        private TextBox partNumberTextBox;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label notesLabel;
        private ComboBox originComboBox;
        private TextBox manufacturerTextBox;
        private TextBox manufacturerPNTextBox;
        private TextBox materialTextBox;
        private ComboBox statusComboBox;
        private SplitContainer splitContainerRevision;
        private TextBox revisionTextBox;
        private DateTimePicker revisionDateTimePicker;
        private TextBox notesTextBox;
        private ToolStripStatusLabel localFilepathToolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private ListView revisionsListView;
        private ColumnHeader revisionsRevisionColumnHeader;
        private ColumnHeader revisionsRevisionDateColumnHeader;
        private ColumnHeader revisionsFilepathColumnHeader;
        private ToolStripSplitButton editPropertiesSplitButton;
        private TabPage previewPage;
        private ToolStripMenuItem enableEditingToolStripMenuItem;
        private ToolStripMenuItem saveChangesToolStripMenuItem;
        private ToolStripMenuItem discardChangesToolStripMenuItem;
        private ListView usageListView;
        private ColumnHeader usagePartNumberColumnHeader;
        private ColumnHeader usageTitleColumnHeader;
        private ColumnHeader usageRevisionColumnHeader;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem selectProjectToolStripMenuItem;
        private ToolStripMenuItem minioToolStripMenuItem;
        private ToolStripMenuItem authenticationToolStripMenuItem;
        private TableLayoutPanel dataTableLayoutPanel;
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
        private ListView commonReferencesListView;
        private ListView revisionReferencesListView;
        private Label commonReferencesLabel;
        private Label revisionReferencesLabel;
        private ToolStripStatusLabel localToolStripStatusLabel;
        private ToolStripStatusLabel projectToolStripStatusLabel;
        private ToolStripStatusLabel projectNameToolStripStatusLabel;
        private ToolStripStatusLabel serverToolStripStatusLabel;
    }
}