using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System_File_Logger;
using System.Diagnostics;

namespace SysFileLogger
{

    public partial class MainDialog : Form
    {

        PartitionHandler partitionHandler = new PartitionHandler();
        FileFilterManager fileFilterMng = new FileFilterManager();

        public MainDialog()
        {
            InitializeComponent();
        }


        private void MainDialog_Load(object sender, EventArgs e)
        {
            partitionHandler.GetActivePartitions();
            fileFilterMng.FillComboBoxWithFileExt(fileExtensions);
        }


        private void autodetectradio_CheckedChanged(object sender, EventArgs e)
        {
            if (autodetectradio.Checked)
            {
                fileSystemWatcher.Path = partitionHandler.PartitionPath;
                currentPath.Text = partitionHandler.PartitionPath;
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            fileFilterMng.UpdateFilesList(FileAttrView, e.FullPath, e.ChangeType.ToString());
        }


        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            string fileExt = Path.GetExtension(e.FullPath);
            fileFilterMng.UpdateCreatedFilesDict(createdFilesDataGrid, e.FullPath, fileExt);
        }


        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string fileExtension = Path.GetExtension(e.FullPath);
            fileFilterMng.UpdateDeletedFilesDict(deletedDataGrid, e.FullPath, fileExtension);
        }


        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            fileFilterMng.UpdateRenamedFilesDict(renamedDataGrid, e.FullPath, e.OldName);
            fileFilterMng.NewFileName = e.Name;
        }


        private void subDirectoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (subDirectoryCheckBox.Checked)
            {
                fileSystemWatcher.IncludeSubdirectories = true;
            }
        }


        private void BrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            fileSystemWatcher.Path = folderBrowserDialog.SelectedPath;

            currentPath.Text = folderBrowserDialog.SelectedPath;
            FileAttrView.Rows.Clear();
        }


        private void currentPath_TextChanged(object sender, EventArgs e)
        {
            if (currentPath.Text != null) subDirectoryCheckBox.Enabled = true;
        }

        private void fileExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileFilterMng.FileFilter(fileExtensions, fileSystemWatcher);
        }

        private void FileAttrView_SelectionChanged(object sender, EventArgs e)
        {
            fileFilterMng.GetFileAttributes(FileAttrView);

            FileSizeTxtBox.Text = fileFilterMng.FileSize.ToString();
            LastWriteTimeTxtBox.Text = fileFilterMng.LastWriteTime.ToString();
            LastAccessTimeTxtBox.Text = fileFilterMng.LastAccessTime.ToString();
            SecurityPermsTextBox.Text = fileFilterMng.ReadOnly;
        }

        private void MoreInfosBtn_Click(object sender, EventArgs e)
        {
            MoreInfosBox.Visible = true;
            fileSizeLab.Visible = true;
            FileSizeTxtBox.Visible = true;
            lastAccessTimeLab.Visible = true;
            LastAccessTimeTxtBox.Visible = true;
            lastWriteTimeLab.Visible = true;
            LastWriteTimeTxtBox.Visible = true;
            readOnly.Visible = true;
            SecurityPermsTextBox.Visible = true;
        }

        private void FileAttrView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fileFilterMng.ShowInExplorer(FileAttrView);
            }
            catch (Exception)
            {
                string warningMsg = "Please choose from file path column!";
                MessageBox.Show(warningMsg, "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
