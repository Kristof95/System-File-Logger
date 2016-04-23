namespace SysFileLogger
{
    partial class MainDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            this.subDirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.autodetectradio = new System.Windows.Forms.RadioButton();
            this.PathOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.currentPath = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.DescriptEveryGroupBox = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.mainDialogTab = new System.Windows.Forms.TabPage();
            this.MoreInfosBtn = new System.Windows.Forms.Button();
            this.readOnly = new System.Windows.Forms.Label();
            this.lastAccessTimeLab = new System.Windows.Forms.Label();
            this.lastWriteTimeLab = new System.Windows.Forms.Label();
            this.fileSizeLab = new System.Windows.Forms.Label();
            this.SecurityPermsTextBox = new System.Windows.Forms.TextBox();
            this.LastAccessTimeTxtBox = new System.Windows.Forms.TextBox();
            this.LastWriteTimeTxtBox = new System.Windows.Forms.TextBox();
            this.FileSizeTxtBox = new System.Windows.Forms.TextBox();
            this.FileAttrView = new System.Windows.Forms.DataGridView();
            this.Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldFullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfosBox = new System.Windows.Forms.GroupBox();
            this.renamedTab = new System.Windows.Forms.TabPage();
            this.renamedDataGrid = new System.Windows.Forms.DataGridView();
            this.filePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renamedFilesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTab = new System.Windows.Forms.TabPage();
            this.createdFilesDataGrid = new System.Windows.Forms.DataGridView();
            this.filePathOnCreatedTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileExtensionOnCreatedTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdFileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedTab = new System.Windows.Forms.TabPage();
            this.deletedDataGrid = new System.Windows.Forms.DataGridView();
            this.filesPathOnDeleteTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileExtensionOnDeleteTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedFilesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogHistory = new System.Windows.Forms.TabPage();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.fileExtensions = new System.Windows.Forms.ComboBox();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.fileExtensionsLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.PathOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.MainTab.SuspendLayout();
            this.mainDialogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileAttrView)).BeginInit();
            this.renamedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renamedDataGrid)).BeginInit();
            this.createdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createdFilesDataGrid)).BeginInit();
            this.deletedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGrid)).BeginInit();
            this.LogHistory.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // subDirectoryCheckBox
            // 
            this.subDirectoryCheckBox.AutoSize = true;
            this.subDirectoryCheckBox.Enabled = false;
            this.subDirectoryCheckBox.Location = new System.Drawing.Point(22, 20);
            this.subDirectoryCheckBox.Name = "subDirectoryCheckBox";
            this.subDirectoryCheckBox.Size = new System.Drawing.Size(129, 17);
            this.subDirectoryCheckBox.TabIndex = 2;
            this.subDirectoryCheckBox.Text = "Include subdirectories";
            this.subDirectoryCheckBox.UseVisualStyleBackColor = true;
            this.subDirectoryCheckBox.CheckedChanged += new System.EventHandler(this.subDirectoryCheckBox_CheckedChanged);
            // 
            // autodetectradio
            // 
            this.autodetectradio.AutoSize = true;
            this.autodetectradio.Checked = true;
            this.autodetectradio.Enabled = false;
            this.autodetectradio.Location = new System.Drawing.Point(17, 61);
            this.autodetectradio.Name = "autodetectradio";
            this.autodetectradio.Size = new System.Drawing.Size(131, 17);
            this.autodetectradio.TabIndex = 4;
            this.autodetectradio.TabStop = true;
            this.autodetectradio.Text = "Auto-detect partition(s)";
            this.autodetectradio.UseVisualStyleBackColor = true;
            this.autodetectradio.CheckedChanged += new System.EventHandler(this.autodetectradio_CheckedChanged);
            // 
            // PathOptionsGroupBox
            // 
            this.PathOptionsGroupBox.Controls.Add(this.currentPath);
            this.PathOptionsGroupBox.Controls.Add(this.BrowseButton);
            this.PathOptionsGroupBox.Controls.Add(this.autodetectradio);
            this.PathOptionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathOptionsGroupBox.Location = new System.Drawing.Point(12, 404);
            this.PathOptionsGroupBox.Name = "PathOptionsGroupBox";
            this.PathOptionsGroupBox.Size = new System.Drawing.Size(359, 84);
            this.PathOptionsGroupBox.TabIndex = 8;
            this.PathOptionsGroupBox.TabStop = false;
            this.PathOptionsGroupBox.Text = "Options";
            // 
            // currentPath
            // 
            this.currentPath.Location = new System.Drawing.Point(80, 22);
            this.currentPath.Name = "currentPath";
            this.currentPath.ReadOnly = true;
            this.currentPath.Size = new System.Drawing.Size(273, 20);
            this.currentPath.TabIndex = 6;
            this.currentPath.TextChanged += new System.EventHandler(this.currentPath_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(17, 20);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(56, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DescriptEveryGroupBox
            // 
            this.DescriptEveryGroupBox.BackColor = System.Drawing.Color.Khaki;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.mainDialogTab);
            this.MainTab.Controls.Add(this.renamedTab);
            this.MainTab.Controls.Add(this.createdTab);
            this.MainTab.Controls.Add(this.deletedTab);
            this.MainTab.Controls.Add(this.LogHistory);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1014, 386);
            this.MainTab.TabIndex = 9;
            // 
            // mainDialogTab
            // 
            this.mainDialogTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainDialogTab.Controls.Add(this.MoreInfosBtn);
            this.mainDialogTab.Controls.Add(this.readOnly);
            this.mainDialogTab.Controls.Add(this.lastAccessTimeLab);
            this.mainDialogTab.Controls.Add(this.lastWriteTimeLab);
            this.mainDialogTab.Controls.Add(this.fileSizeLab);
            this.mainDialogTab.Controls.Add(this.SecurityPermsTextBox);
            this.mainDialogTab.Controls.Add(this.LastAccessTimeTxtBox);
            this.mainDialogTab.Controls.Add(this.LastWriteTimeTxtBox);
            this.mainDialogTab.Controls.Add(this.FileSizeTxtBox);
            this.mainDialogTab.Controls.Add(this.FileAttrView);
            this.mainDialogTab.Controls.Add(this.MoreInfosBox);
            this.mainDialogTab.Location = new System.Drawing.Point(4, 22);
            this.mainDialogTab.Name = "mainDialogTab";
            this.mainDialogTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainDialogTab.Size = new System.Drawing.Size(1006, 360);
            this.mainDialogTab.TabIndex = 0;
            this.mainDialogTab.Text = "Changed";
            this.mainDialogTab.ToolTipText = "Collect every file event.";
            // 
            // MoreInfosBtn
            // 
            this.MoreInfosBtn.Location = new System.Drawing.Point(719, 326);
            this.MoreInfosBtn.Name = "MoreInfosBtn";
            this.MoreInfosBtn.Size = new System.Drawing.Size(284, 31);
            this.MoreInfosBtn.TabIndex = 3;
            this.MoreInfosBtn.Text = "More file informations";
            this.MoreInfosBtn.UseVisualStyleBackColor = true;
            this.MoreInfosBtn.Click += new System.EventHandler(this.MoreInfosBtn_Click);
            // 
            // readOnly
            // 
            this.readOnly.AutoSize = true;
            this.readOnly.Location = new System.Drawing.Point(741, 212);
            this.readOnly.Name = "readOnly";
            this.readOnly.Size = new System.Drawing.Size(57, 13);
            this.readOnly.TabIndex = 2;
            this.readOnly.Text = "Read Only";
            this.readOnly.Visible = false;
            // 
            // lastAccessTimeLab
            // 
            this.lastAccessTimeLab.AutoSize = true;
            this.lastAccessTimeLab.Location = new System.Drawing.Point(741, 172);
            this.lastAccessTimeLab.Name = "lastAccessTimeLab";
            this.lastAccessTimeLab.Size = new System.Drawing.Size(86, 13);
            this.lastAccessTimeLab.TabIndex = 2;
            this.lastAccessTimeLab.Text = "Last access time";
            this.lastAccessTimeLab.Visible = false;
            // 
            // lastWriteTimeLab
            // 
            this.lastWriteTimeLab.AutoSize = true;
            this.lastWriteTimeLab.Location = new System.Drawing.Point(741, 131);
            this.lastWriteTimeLab.Name = "lastWriteTimeLab";
            this.lastWriteTimeLab.Size = new System.Drawing.Size(74, 13);
            this.lastWriteTimeLab.TabIndex = 2;
            this.lastWriteTimeLab.Text = "Last write time";
            this.lastWriteTimeLab.Visible = false;
            // 
            // fileSizeLab
            // 
            this.fileSizeLab.AutoSize = true;
            this.fileSizeLab.Location = new System.Drawing.Point(741, 92);
            this.fileSizeLab.Name = "fileSizeLab";
            this.fileSizeLab.Size = new System.Drawing.Size(66, 13);
            this.fileSizeLab.TabIndex = 2;
            this.fileSizeLab.Text = "File size(MB)";
            this.fileSizeLab.Visible = false;
            // 
            // SecurityPermsTextBox
            // 
            this.SecurityPermsTextBox.Location = new System.Drawing.Point(834, 209);
            this.SecurityPermsTextBox.Name = "SecurityPermsTextBox";
            this.SecurityPermsTextBox.ReadOnly = true;
            this.SecurityPermsTextBox.Size = new System.Drawing.Size(139, 20);
            this.SecurityPermsTextBox.TabIndex = 1;
            this.SecurityPermsTextBox.Visible = false;
            // 
            // LastAccessTimeTxtBox
            // 
            this.LastAccessTimeTxtBox.Location = new System.Drawing.Point(834, 169);
            this.LastAccessTimeTxtBox.Name = "LastAccessTimeTxtBox";
            this.LastAccessTimeTxtBox.ReadOnly = true;
            this.LastAccessTimeTxtBox.Size = new System.Drawing.Size(139, 20);
            this.LastAccessTimeTxtBox.TabIndex = 1;
            this.LastAccessTimeTxtBox.Visible = false;
            // 
            // LastWriteTimeTxtBox
            // 
            this.LastWriteTimeTxtBox.Location = new System.Drawing.Point(834, 128);
            this.LastWriteTimeTxtBox.Name = "LastWriteTimeTxtBox";
            this.LastWriteTimeTxtBox.ReadOnly = true;
            this.LastWriteTimeTxtBox.Size = new System.Drawing.Size(139, 20);
            this.LastWriteTimeTxtBox.TabIndex = 1;
            this.LastWriteTimeTxtBox.Visible = false;
            // 
            // FileSizeTxtBox
            // 
            this.FileSizeTxtBox.Location = new System.Drawing.Point(834, 89);
            this.FileSizeTxtBox.Name = "FileSizeTxtBox";
            this.FileSizeTxtBox.ReadOnly = true;
            this.FileSizeTxtBox.Size = new System.Drawing.Size(139, 20);
            this.FileSizeTxtBox.TabIndex = 1;
            this.FileSizeTxtBox.Visible = false;
            // 
            // FileAttrView
            // 
            this.FileAttrView.AllowUserToAddRows = false;
            this.FileAttrView.AllowUserToDeleteRows = false;
            this.FileAttrView.AllowUserToOrderColumns = true;
            this.FileAttrView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileAttrView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FileAttrView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.FileAttrView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileAttrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileAttrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Files,
            this.oldFullPath,
            this.typeOfChange,
            this.dateOfChange});
            this.FileAttrView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.FileAttrView.Location = new System.Drawing.Point(0, 0);
            this.FileAttrView.MultiSelect = false;
            this.FileAttrView.Name = "FileAttrView";
            this.FileAttrView.Size = new System.Drawing.Size(713, 360);
            this.FileAttrView.TabIndex = 0;
            this.FileAttrView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileAttrView_CellDoubleClick);
            this.FileAttrView.SelectionChanged += new System.EventHandler(this.FileAttrView_SelectionChanged);
            // 
            // Files
            // 
            this.Files.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Files.FillWeight = 65.65144F;
            this.Files.HeaderText = "File(s) path";
            this.Files.Name = "Files";
            this.Files.ReadOnly = true;
            // 
            // oldFullPath
            // 
            this.oldFullPath.FillWeight = 65.65144F;
            this.oldFullPath.HeaderText = "Old path of the file";
            this.oldFullPath.Name = "oldFullPath";
            this.oldFullPath.ReadOnly = true;
            // 
            // typeOfChange
            // 
            this.typeOfChange.FillWeight = 203.0457F;
            this.typeOfChange.HeaderText = "Type of change";
            this.typeOfChange.Name = "typeOfChange";
            this.typeOfChange.ReadOnly = true;
            // 
            // dateOfChange
            // 
            this.dateOfChange.FillWeight = 65.65144F;
            this.dateOfChange.HeaderText = "Date";
            this.dateOfChange.Name = "dateOfChange";
            this.dateOfChange.ReadOnly = true;
            // 
            // MoreInfosBox
            // 
            this.MoreInfosBox.Location = new System.Drawing.Point(719, 3);
            this.MoreInfosBox.Name = "MoreInfosBox";
            this.MoreInfosBox.Size = new System.Drawing.Size(286, 320);
            this.MoreInfosBox.TabIndex = 4;
            this.MoreInfosBox.TabStop = false;
            this.MoreInfosBox.Text = "File/Folder informations";
            // 
            // renamedTab
            // 
            this.renamedTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.renamedTab.Controls.Add(this.renamedDataGrid);
            this.renamedTab.Location = new System.Drawing.Point(4, 22);
            this.renamedTab.Name = "renamedTab";
            this.renamedTab.Padding = new System.Windows.Forms.Padding(3);
            this.renamedTab.Size = new System.Drawing.Size(1006, 360);
            this.renamedTab.TabIndex = 1;
            this.renamedTab.Text = "Renamed file(s)";
            this.renamedTab.ToolTipText = "Log rename events in file system.";
            // 
            // renamedDataGrid
            // 
            this.renamedDataGrid.AllowUserToAddRows = false;
            this.renamedDataGrid.AllowUserToDeleteRows = false;
            this.renamedDataGrid.AllowUserToOrderColumns = true;
            this.renamedDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.renamedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.renamedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.renamedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePath,
            this.oldName,
            this.newName,
            this.renamedFilesDate});
            this.renamedDataGrid.Location = new System.Drawing.Point(0, 0);
            this.renamedDataGrid.Name = "renamedDataGrid";
            this.renamedDataGrid.ReadOnly = true;
            this.renamedDataGrid.Size = new System.Drawing.Size(1006, 360);
            this.renamedDataGrid.TabIndex = 0;
            // 
            // filePath
            // 
            this.filePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filePath.HeaderText = "File(s) path";
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            // 
            // oldName
            // 
            this.oldName.HeaderText = "From";
            this.oldName.Name = "oldName";
            this.oldName.ReadOnly = true;
            this.oldName.Width = 180;
            // 
            // newName
            // 
            this.newName.HeaderText = "To";
            this.newName.Name = "newName";
            this.newName.ReadOnly = true;
            // 
            // renamedFilesDate
            // 
            this.renamedFilesDate.HeaderText = "Date";
            this.renamedFilesDate.Name = "renamedFilesDate";
            this.renamedFilesDate.ReadOnly = true;
            this.renamedFilesDate.Width = 200;
            // 
            // createdTab
            // 
            this.createdTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createdTab.Controls.Add(this.createdFilesDataGrid);
            this.createdTab.Location = new System.Drawing.Point(4, 22);
            this.createdTab.Name = "createdTab";
            this.createdTab.Padding = new System.Windows.Forms.Padding(3);
            this.createdTab.Size = new System.Drawing.Size(1006, 360);
            this.createdTab.TabIndex = 2;
            this.createdTab.Text = "Created file(s)";
            this.createdTab.ToolTipText = "Log create events in file system.";
            // 
            // createdFilesDataGrid
            // 
            this.createdFilesDataGrid.AllowUserToAddRows = false;
            this.createdFilesDataGrid.AllowUserToDeleteRows = false;
            this.createdFilesDataGrid.AllowUserToOrderColumns = true;
            this.createdFilesDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.createdFilesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdFilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createdFilesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePathOnCreatedTab,
            this.fileExtensionOnCreatedTab,
            this.createdFileDate});
            this.createdFilesDataGrid.Location = new System.Drawing.Point(0, 0);
            this.createdFilesDataGrid.Name = "createdFilesDataGrid";
            this.createdFilesDataGrid.ReadOnly = true;
            this.createdFilesDataGrid.Size = new System.Drawing.Size(1006, 360);
            this.createdFilesDataGrid.TabIndex = 0;
            // 
            // filePathOnCreatedTab
            // 
            this.filePathOnCreatedTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filePathOnCreatedTab.HeaderText = "File(s) path";
            this.filePathOnCreatedTab.Name = "filePathOnCreatedTab";
            this.filePathOnCreatedTab.ReadOnly = true;
            // 
            // fileExtensionOnCreatedTab
            // 
            this.fileExtensionOnCreatedTab.HeaderText = "Extension";
            this.fileExtensionOnCreatedTab.Name = "fileExtensionOnCreatedTab";
            this.fileExtensionOnCreatedTab.ReadOnly = true;
            // 
            // createdFileDate
            // 
            this.createdFileDate.HeaderText = "Date";
            this.createdFileDate.Name = "createdFileDate";
            this.createdFileDate.ReadOnly = true;
            this.createdFileDate.Width = 200;
            // 
            // deletedTab
            // 
            this.deletedTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deletedTab.Controls.Add(this.deletedDataGrid);
            this.deletedTab.Location = new System.Drawing.Point(4, 22);
            this.deletedTab.Name = "deletedTab";
            this.deletedTab.Size = new System.Drawing.Size(1006, 360);
            this.deletedTab.TabIndex = 3;
            this.deletedTab.Text = "Deleted file(s)";
            this.deletedTab.ToolTipText = "Log delete events in file system.";
            // 
            // deletedDataGrid
            // 
            this.deletedDataGrid.AllowUserToAddRows = false;
            this.deletedDataGrid.AllowUserToDeleteRows = false;
            this.deletedDataGrid.AllowUserToOrderColumns = true;
            this.deletedDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.deletedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deletedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesPathOnDeleteTab,
            this.fileExtensionOnDeleteTab,
            this.deletedFilesDate});
            this.deletedDataGrid.Location = new System.Drawing.Point(0, 0);
            this.deletedDataGrid.Name = "deletedDataGrid";
            this.deletedDataGrid.ReadOnly = true;
            this.deletedDataGrid.Size = new System.Drawing.Size(1006, 364);
            this.deletedDataGrid.TabIndex = 0;
            // 
            // filesPathOnDeleteTab
            // 
            this.filesPathOnDeleteTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filesPathOnDeleteTab.HeaderText = "File(s) path";
            this.filesPathOnDeleteTab.Name = "filesPathOnDeleteTab";
            this.filesPathOnDeleteTab.ReadOnly = true;
            // 
            // fileExtensionOnDeleteTab
            // 
            this.fileExtensionOnDeleteTab.HeaderText = "Extension";
            this.fileExtensionOnDeleteTab.Name = "fileExtensionOnDeleteTab";
            this.fileExtensionOnDeleteTab.ReadOnly = true;
            // 
            // deletedFilesDate
            // 
            this.deletedFilesDate.HeaderText = "Date";
            this.deletedFilesDate.Name = "deletedFilesDate";
            this.deletedFilesDate.ReadOnly = true;
            this.deletedFilesDate.Width = 200;
            // 
            // LogHistory
            // 
            this.LogHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogHistory.Controls.Add(this.LogListBox);
            this.LogHistory.Location = new System.Drawing.Point(4, 22);
            this.LogHistory.Name = "LogHistory";
            this.LogHistory.Padding = new System.Windows.Forms.Padding(3);
            this.LogHistory.Size = new System.Drawing.Size(1006, 360);
            this.LogHistory.TabIndex = 4;
            this.LogHistory.Text = "History";
            this.LogHistory.ToolTipText = "Log previous events in file system.";
            // 
            // LogListBox
            // 
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(6, 6);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(997, 342);
            this.LogListBox.Sorted = true;
            this.LogListBox.TabIndex = 0;
            // 
            // fileExtensions
            // 
            this.fileExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileExtensions.FormattingEnabled = true;
            this.fileExtensions.Location = new System.Drawing.Point(104, 42);
            this.fileExtensions.Name = "fileExtensions";
            this.fileExtensions.Size = new System.Drawing.Size(58, 21);
            this.fileExtensions.TabIndex = 5;
            this.fileExtensions.SelectedIndexChanged += new System.EventHandler(this.fileExtensions_SelectedIndexChanged);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.fileExtensionsLabel);
            this.FilterGroupBox.Controls.Add(this.fileExtensions);
            this.FilterGroupBox.Controls.Add(this.subDirectoryCheckBox);
            this.FilterGroupBox.Location = new System.Drawing.Point(798, 404);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(228, 84);
            this.FilterGroupBox.TabIndex = 10;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            // 
            // fileExtensionsLabel
            // 
            this.fileExtensionsLabel.AutoSize = true;
            this.fileExtensionsLabel.Location = new System.Drawing.Point(19, 45);
            this.fileExtensionsLabel.Name = "fileExtensionsLabel";
            this.fileExtensionsLabel.Size = new System.Drawing.Size(76, 13);
            this.fileExtensionsLabel.TabIndex = 6;
            this.fileExtensionsLabel.Text = "File extensions";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 508);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.PathOptionsGroupBox);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDialog";
            this.Text = "File system monitor";
            this.Load += new System.EventHandler(this.MainDialog_Load);
            this.PathOptionsGroupBox.ResumeLayout(false);
            this.PathOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.mainDialogTab.ResumeLayout(false);
            this.mainDialogTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileAttrView)).EndInit();
            this.renamedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renamedDataGrid)).EndInit();
            this.createdTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createdFilesDataGrid)).EndInit();
            this.deletedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGrid)).EndInit();
            this.LogHistory.ResumeLayout(false);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton autodetectradio;
        private System.Windows.Forms.GroupBox PathOptionsGroupBox;
        private System.Windows.Forms.ToolTip DescriptEveryGroupBox;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox subDirectoryCheckBox;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage mainDialogTab;
        private System.Windows.Forms.DataGridView FileAttrView;
        private System.Windows.Forms.TabPage renamedTab;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.Label fileExtensionsLabel;
        private System.Windows.Forms.ComboBox fileExtensions;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabPage createdTab;
        private System.Windows.Forms.TabPage deletedTab;
        private System.Windows.Forms.DataGridView renamedDataGrid;
        private System.Windows.Forms.DataGridView createdFilesDataGrid;
        private System.Windows.Forms.DataGridView deletedDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesPathOnDeleteTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileExtensionOnDeleteTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedFilesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathOnCreatedTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileExtensionOnCreatedTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdFileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn newName;
        private System.Windows.Forms.DataGridViewTextBoxColumn renamedFilesDate;
        private System.Windows.Forms.TextBox currentPath;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label readOnly;
        private System.Windows.Forms.Label lastAccessTimeLab;
        private System.Windows.Forms.Label lastWriteTimeLab;
        private System.Windows.Forms.Label fileSizeLab;
        private System.Windows.Forms.TextBox SecurityPermsTextBox;
        private System.Windows.Forms.TextBox LastAccessTimeTxtBox;
        private System.Windows.Forms.TextBox LastWriteTimeTxtBox;
        private System.Windows.Forms.TextBox FileSizeTxtBox;
        private System.Windows.Forms.Button MoreInfosBtn;
        private System.Windows.Forms.GroupBox MoreInfosBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldFullPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfChange;
        private System.Windows.Forms.TabPage LogHistory;
        private System.Windows.Forms.ListBox LogListBox;
    }
}

