using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SysFileLogger
{
    public class FileFilterManager
    {
        private Dictionary<string, string> allFileEvents;
        private Dictionary<string, string> renamedFiles;
        private Dictionary<string, string> createdFiles;
        private Dictionary<string, string> deletedFiles;

        private DateTime date = DateTime.Now;
        private DateTime lastWriteTime;
        private DateTime lastAccessTime;

        private string oldFullPath;
        private string newFileName;
        private string readOnly;

        private double fileSize;

        public enum FileExtensions
        {
            Default, Txt, Exe, Dat, Rtf, Zip, Pdf, Xml, Doc, Html, Mp3, Tif, Torrent, Rar, Php, Jar, Css, Ppt
        }

        public string OldFullPath
        {
            get
            {
                return oldFullPath;
            }

            set
            {
                oldFullPath = value;
            }
        }

        public string NewFileName
        {
            get
            {
                return newFileName;
            }

            set
            {
                newFileName = value;
            }
        }

        public double FileSize
        {
            get
            {
                return fileSize;
            }

            set
            {
                fileSize = value;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return lastWriteTime;
            }

            set
            {
                lastWriteTime = value;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return lastAccessTime;
            }

            set
            {
                lastAccessTime = value;
            }
        }

        public string ReadOnly
        {
            get
            {
                return readOnly;
            }

            set
            {
                readOnly = value;
            }
        }

        public void UpdateFilesList(DataGridView displayAllEvents, string fullPath, string changeType)
        {
            allFileEvents = new Dictionary<string, string>();
            allFileEvents.Add(fullPath, changeType);

            foreach (KeyValuePair<string, string> pair in allFileEvents)
            {
                displayAllEvents.Rows.Add(pair.Key, oldFullPath, pair.Value, date.ToString());
            }
        }


        public void UpdateRenamedFilesDict(DataGridView renamedFileInfosDisplay, string fullPath, string oldFileName)
        {
            string newFileName = Path.GetFileName(fullPath);
            renamedFiles = new Dictionary<string, string>();
            renamedFiles.Add(fullPath, oldFileName);

            foreach (KeyValuePair<string, string> fileAttrPair in renamedFiles)
            {
                renamedFileInfosDisplay.Rows.Add(fileAttrPair.Key, oldFileName, newFileName, date.ToString());
            }
        }


        public void UpdateCreatedFilesDict(DataGridView createdFileInfosDisplay, string pathOfFile, string extension)
        {
            createdFiles = new Dictionary<string, string>();
            if (extension.Equals("")) extension = "folder";
            createdFiles.Add(pathOfFile, extension);

            foreach (KeyValuePair<string, string> newFilesAttrs in createdFiles)
            {
                createdFileInfosDisplay.Rows.Add(newFilesAttrs.Key, newFilesAttrs.Value, date.ToString());
            }
        }

        public void UpdateDeletedFilesDict(DataGridView deletedFileInfosDisplay, string path, string extension)
        {
            deletedFiles = new Dictionary<string, string>();

            if (extension.Equals("")) extension = "folder";

            deletedFiles.Add(path, extension);

            foreach (KeyValuePair<string, string> deletedFilesAttrs in deletedFiles)
            {
                deletedFileInfosDisplay.Rows.Add(deletedFilesAttrs.Key, deletedFilesAttrs.Value, date.ToString());
            }
        }

        public bool IsPathSelected(string path)
        {
            if(path != null)
            {
                return true;
            }
            return false;
        }

        public void FillComboBoxWithFileExt(ComboBox fileExtenstionsComboB)
        {
            fileExtenstionsComboB.DataSource = Enum.GetValues(typeof(FileExtensions));
        }

        
        public void FileFilter(ComboBox filter, FileSystemWatcher fileSysWatch)
        {
            if(filter.SelectedIndex == 0)
            {
                fileSysWatch.Filter = "*.*";
            }
            else
            {
                string selectedExt = filter.SelectedItem.ToString();
                fileSysWatch.Filter = "*." + selectedExt.ToLower();
            }
        }


        public void GetFileAttributes(DataGridView items)
        {   
            try
            {
                string path = items.CurrentCell.Value.ToString();
                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    FileSize = fileInfo.Length / 1024 / 1024;
                    LastWriteTime = fileInfo.LastWriteTime;
                    LastAccessTime = fileInfo.LastAccessTime;
                    ReadOnly = fileInfo.IsReadOnly.ToString();
                }
                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    FileSize = dirInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length) / 1024 / 1024;
                    LastWriteTime = dirInfo.LastWriteTime;
                    LastAccessTime = dirInfo.LastAccessTime;
                    ReadOnly = "-";
                }
            }
            catch(NullReferenceException)
            {
                string badPath = "Please choose from the file path column!";
                MessageBox.Show(badPath, "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                string perms = "Sorry, permission denied!";
                MessageBox.Show(perms, "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }           
        }

        public void ShowInExplorer(DataGridView filePaths)
        {
            string path = filePaths.CurrentCell.Value.ToString();

            ProcessStartInfo StartInformation = new ProcessStartInfo();
            StartInformation.FileName = path;

            Process process = Process.Start(StartInformation);
            process.EnableRaisingEvents = true;
        }
    }
}
