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
    public partial class MoveRepoFRMold : Form
    {
        public MoveRepoFRMold()
        {
            InitializeComponent();
        }

        private void MoveRepoFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool StoreData = true;

            if (
                    string.IsNullOrEmpty(RepoSourceTB.Text) &&
                    string.IsNullOrEmpty(RepoDestinationTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoSourceTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoDestinationTB.Text)
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
                                    "Close Move Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    e.Cancel = (Verify == DialogResult.No);
                }

                if (String.IsNullOrEmpty(RepoDestinationTB.Text) || String.IsNullOrWhiteSpace(RepoDestinationTB.Text))
                {
                    StoreData = false;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Repository Destination is empty, close window?",
                                    "Close Move Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    e.Cancel = (Verify == DialogResult.No);

                }

                if (StoreData)
                {
                    MoveRepoData.Repository_Source = RepoSourceTB.Text;
                    MoveRepoData.Repository_Destination = RepoDestinationTB.Text;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Are you sure you want to move this repository?",
                                    "Close Move Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    if (Verify == DialogResult.Yes)
                    {
                        MoveRepoMethods.MoveRepository();
                    }

                    else
                    {
                        Verify = MessageBox.Show
                                (
                                    this,
                                    "Close Window?",
                                    "Close New Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                        e.Cancel = (Verify == DialogResult.No);
                    }
                }

                else
                {
                    MoveRepoData.Repository_Destination = string.Empty;
                    MoveRepoData.Repository_Source = string.Empty;
                }
            }
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

        private void BrowseRepoDestinationBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MoveRepoData.Repository_Destination = dialog.FileName;
                RepoDestinationTB.Text = MoveRepoData.Repository_Destination;
            }
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
           // MoveRepoDescriptionSSLB.Text = Properties.Resources.MOVE_REPO_BROWSE_SOURCE_INFO;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon;
            MoveRepoDescriptionSSLB.Text = string.Empty;
        }

        private void BrowseRepoDestinationBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoDestinationBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            //MoveRepoDescriptionSSLB.Text = Properties.Resources.MOVE_REPO_BROWSE_DESTINATION_INFO;
        }

        private void BrowseRepoDestinationBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoDestinationBT.BackgroundImage = Properties.Resources.Browse_Icon;
            MoveRepoDescriptionSSLB.Text = string.Empty;
        }
    }
}
