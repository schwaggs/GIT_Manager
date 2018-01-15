using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class CloneRepoFRMold : Form
    {
        public CloneRepoFRMold()
        {
            InitializeComponent();
        }

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MoveRepoData.Repository_Source = dialog.FileName;
                RepoSourceTB.Text = MoveRepoData.Repository_Source;
            }
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            //CloneRepoDescriptionSSLB.Text = Properties.Resources.CLONE_REPO_BROWSE_SOURCE_INFO;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon;
            CloneRepoDescriptionSSLB.Text = string.Empty;
        }

        private void BrowseCloneDestinationBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MoveRepoData.Repository_Source = dialog.FileName;
                CloneDestinationTB.Text = MoveRepoData.Repository_Source;
            }
        }

        private void BrowseCloneDestinationBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseCloneDestinationBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            //CloneRepoDescriptionSSLB.Text = Properties.Resources.CLONE_REPO_BROWSE_DESTINATION_INFO;
        }

        private void BrowseCloneDestinationBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseCloneDestinationBT.BackgroundImage = Properties.Resources.Browse_Icon;
            CloneRepoDescriptionSSLB.Text = string.Empty;
        }

        private void CloneRepoFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool StoreData = true;

            if (
                    string.IsNullOrEmpty(RepoSourceTB.Text) &&
                    string.IsNullOrEmpty(CloneDestinationTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoSourceTB.Text) &&
                    string.IsNullOrWhiteSpace(CloneDestinationTB.Text)
               )
            {
            }

            else
            {
                if (String.IsNullOrEmpty(RepoSourceTB.Text) || String.IsNullOrWhiteSpace(RepoSourceTB.Text))
                {
                    StoreData = false;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Repository Source is empty, close window?",
                                    "Close Clone Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    e.Cancel = (Verify == DialogResult.No);
                }

                if (String.IsNullOrEmpty(CloneDestinationTB.Text) || String.IsNullOrWhiteSpace(CloneDestinationTB.Text))
                {
                    StoreData = false;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Clone Destination is empty, close window?",
                                    "Close Clone Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    e.Cancel = (Verify == DialogResult.No);

                }

                if (StoreData)
                {
                    CloneRepoData.Repository_Source = RepoSourceTB.Text;
                    CloneRepoData.Clone_Destination = CloneDestinationTB.Text;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Are you sure you want to clone this repository?",
                                    "Close Clone Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    if (Verify == DialogResult.Yes)
                    {
                        CloneRepoMethods.Clone_Repository();
                    }

                    else
                    {
                        Verify = MessageBox.Show
                                (
                                    this,
                                    "Close Window?",
                                    "Close Clone Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                        e.Cancel = (Verify == DialogResult.No);
                    }
                }

                else
                {
                    CloneRepoData.Repository_Source = string.Empty;
                    CloneRepoData.Clone_Destination = string.Empty;
                }
            }
        }
    }
}
