using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class CloneRepoFRM : Form
    {

        public static bool retry { get; set; }
        public static string dir { get; set; }

        public CloneRepoFRM(string directory)
        {
            InitializeComponent();
            retry = false;
            dir = directory;
        }

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = DestinationPathTB.Text,

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DestinationPathTB.Text = dialog.FileName;
            }
        }

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            progressBar1.Show();

            if (string.IsNullOrEmpty(DestinationPathTB.Text) || string.IsNullOrWhiteSpace(DestinationPathTB.Text))
            {
                MessageBox.Show("Not a valid destination!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (RepoHelpers.Is_Git_Repo(RepoPathTB.Text))
                {
                    bool ClonerResult = false;

                    if (RepoHelpers.Clone_Repo(DestinationPathTB.Text, true))
                    {
                        ClonerResult = false;

                        DirectoryInfo cloneInfo = new DirectoryInfo(RepoPathTB.Text);
                        DirectoryInfo localInfo = new DirectoryInfo(Properties.Settings.Default.CloneLocalSourcePath);

                        AutoClosingMessageBox.Show(cloneInfo.Name + " successfully cloned to " + localInfo.Name, "Clone Successful", 1500);
                    }

                    else
                    {
                        ClonerResult = true;
                    }

                    retry = ClonerResult;
                }

                else
                {
                    MessageBox.Show("Not a valid repository!", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            progressBar1.Hide();

            if (retry)
            {
                retry = false;

                DialogResult res = MessageBox.Show("Error cloning repository, retry?", "Error Cloning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (res == DialogResult.Retry)
                {
                    CloneRepoBT.PerformClick();
                }
            }

            Close();
        }

        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
        }

        private void CloneRepoBT_MouseLeave(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon;
        }

        private void ClearAllBT_Click(object sender, EventArgs e)
        {
            DestinationPathTB.Clear();
        }

        private void ClearAllBT_MouseEnter(object sender, EventArgs e)
        {
            ClearAllBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon_Hover;
        }

        private void ClearAllBT_MouseLeave(object sender, EventArgs e)
        {
            ClearAllBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon;
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon;
        }

        private void CloneRepoFRM_Load(object sender, EventArgs e)
        {
            RepoPathTB.Text = dir;
            RepoPathTB.SelectionStart = RepoPathTB.SelectionStart;
            RepoPathTB.SelectionLength = 0;
            DestinationPathTB.Text = Properties.Settings.Default.CloneLocalSourcePath;
            CloneRepoBT.Focus();
        }

        private void RepoPathTB_Click(object sender, EventArgs e)
        {
            RepoPathTB.SelectAll();
        }
    }
}
