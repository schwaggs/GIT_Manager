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
    public partial class AddRepoFRM : Form
    {
        private string StorePath { get; set; }
        private string RepoName { get; set; }
        public bool Repo_Added { get; set; }

        public AddRepoFRM(string path)
        {
            StorePath = path;
            InitializeComponent();
        }

        #region BrowseRepoSourceBT

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                NewRepoNameTB.Text = dialog.FileName;
            }
        }

        #endregion

        #region AddRepoFRM

        private void AddRepoFRM_Load(object sender, EventArgs e)
        {
            Repo_Added = false;
            StorePathTB.Text = StorePath;
            NewRepoNameTB.Focus();
        }

        #endregion

        #region CloneRepoBT

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!string.IsNullOrEmpty(NewRepoNameTB.Text) && !string.IsNullOrWhiteSpace(NewRepoNameTB.Text))
            {
                RepoName = NewRepoNameTB.Text;

                Repo_Added = RepoHelpers.Create_Blank_Repository(StorePathTB.Text, RepoName);

                DirectoryInfo storeInfo = new DirectoryInfo(StorePath);

                if (Repo_Added)
                {
                    AutoClosingMessageBox.Show(RepoName + " added to " + storeInfo.Name, "Repo Added Successfully", 1500);
                    Close();
                }
            }

            else
            {
                MessageBox.Show("Please provide a repository name to continue", "Blank Repository Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Cursor = Cursors.Default;
        }

        #endregion

        #region CloneRepoBT

        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        #endregion

        #region CloneRepoBT

        private void CloneRepoBT_MouseLeave(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.NewIcon;
        }

        #endregion
    }
}
