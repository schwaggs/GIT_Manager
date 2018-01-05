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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class LogViewFRM : Form
    {
        public LogViewFRM()
        {
            InitializeComponent();
        }

        private void RepoLocationTB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RepoLocationTB.Text) || !string.IsNullOrWhiteSpace(RepoLocationTB.Text))
            {
                LogResultsTB.Visible = true;

                DirectoryInfo SourceDirInfo = new DirectoryInfo(RepoLocationTB.Text);

                if (SourceDirInfo.Exists)
                {
                    if (SourceDirInfo.FullName.Contains(".git"))
                    {
                        LogResultsTB.Text = RepoIO.Get_Repo_Log(SourceDirInfo);
                    }

                    else
                    {
                        LogResultsTB.Text = @"Not a valid repository.";
                    }
                }

                else
                {
                    LogResultsTB.Text = @"Not a valid repository location.";
                }
            }

            else
            {
                LogResultsTB.Visible = false;
            }
        }

        private void BrowseRepoBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                RepoLocationTB.Text = dialog.FileName;
            }
        }

        private void BrowseRepoBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
        }

        private void BrowseRepoBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoBT.BackgroundImage = Properties.Resources.Browse_Icon;
        }

        private void RepoLocationTB_KeyDown(object sender, KeyEventArgs e)
        {
            DirectoryInfo SourceDirInfo = null;

            if (e.KeyCode == Keys.Enter)
            {
                LogResultsTB.Visible = true;

                try
                {
                    SourceDirInfo = new DirectoryInfo(RepoLocationTB.Text);
                }

                catch
                {
                    return;
                }

                if (SourceDirInfo == null || SourceDirInfo.Exists)
                {
                    if (SourceDirInfo.FullName.Contains(".git"))
                    {
                        LogResultsTB.Text = RepoIO.Get_Repo_Log(SourceDirInfo);
                    }

                    else
                    {
                        LogResultsTB.Text = @"Not a valid repository.";
                    }
                }

                else
                {
                    LogResultsTB.Text = @"Not a valid repository location.";
                }
            }
        }
    }
}
