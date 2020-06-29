using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvShowRenaming
{
    public partial class Form1 : Form
    {
        private List<string> videoExtensions = new List<string>()
        {
            ".avi",
            ".mp4",
            ".mkv"
        };

        private List<string> subtitleExtensions = new List<string>()
        {
            ".srt",
            ".sub"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var selectFolderDialog = new FolderBrowserDialog();
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtSelectedFolder.Text = selectFolderDialog.SelectedPath;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Working...";
            var rootDirectory = new DirectoryInfo(txtSelectedFolder.Text);
            if (rootDirectory.Exists)
            {
                RenameFilesChildInDir(rootDirectory, rootDirectory.Name);
            }
            lblResult.Text = "Finished...";
        }

        private void RenameFilesChildInDir(DirectoryInfo dir, string prefix)
        {
            FindFilesAndRenameInFolder(dir, prefix);

            var choldDirs = dir.GetDirectories().ToList();
            foreach (var childDir in choldDirs)
            {
                RenameFilesChildInDir(childDir, $"{prefix}_{childDir.Name}");
            }
        }

        private void FindFilesAndRenameInFolder(DirectoryInfo dir, string prefix)
        {
            var filesInDir = dir.GetFiles().ToList();
            var videoFile = filesInDir.FirstOrDefault(x => videoExtensions.Contains(x.Extension));
            if (videoFile != null)
            {
                var newVideoFilePath = Path.Combine(videoFile.DirectoryName, $"{prefix}{videoFile.Extension}");//GetFileNameWithPrefixWithExtension(videoFile, prefix);
                MoveFile(videoFile.FullName, newVideoFilePath);
                videoFile = new FileInfo(newVideoFilePath);
                var subtitleFile = filesInDir.FirstOrDefault(x => subtitleExtensions.Contains(x.Extension));
                if (subtitleFile != null)
                {
                    MoveFile(subtitleFile.FullName, $"{GetFileNameWithoutExtension(videoFile)}{subtitleFile.Extension}");
                }
            }
        }

        private void MoveFile(string oldFullName, string newFullName)
        {
            try
            {
                File.Move(oldFullName, newFullName);
            }
            catch (Exception ex)
            {
                txtLog.Text += $@"
error on old file: {oldFullName}, new file: {newFullName}.
error: {ex.Message}";
            }
        }

        private string GetFileNameWithoutExtension(FileInfo file)
        {
            return file.FullName.Substring(0, file.FullName.Length - file.Extension.Length);
        }
    }
}
