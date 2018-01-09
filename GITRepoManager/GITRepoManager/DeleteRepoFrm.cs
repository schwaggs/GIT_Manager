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
    public partial class DeleteRepoFRM : Form
    {
        public DeleteRepoFRM()
        {
            InitializeComponent();
        }

        private void BrowseLocationBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DeleteRepoData.Repository_Setting_Location = dialog.FileName;
                RepoLocationTB.Text = DeleteRepoData.Repository_Setting_Location;
            }
        }

        private void DeleteRepoFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool StoreData = true;

            if (
                    string.IsNullOrEmpty(RepoLocationTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoLocationTB.Text)
               )
            {
            }

            else
            {
                if (StoreData)
                {
                    DeleteRepoData.Repository_Setting_Location = RepoLocationTB.Text;
                    DeleteRepoData.Is_Local_Clone = IsLocalRepoCB.Checked;
                    NewRepoData.Repository_Option_Readme = DeleteLocalCB.Checked;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Are you sure you want to delete this repository?",
                                    "Close Delete Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    if (Verify == DialogResult.Yes)
                    {
                        DeleteRepoMethods.DeleteRepository();
                        e.Cancel = (Verify == DialogResult.No);
                    }

                    else
                    {
                        Verify = MessageBox.Show
                                    (
                                        this,
                                        "Close Window?",
                                        "Close Delete Repo Window",
                                        MessageBoxButtons.YesNo
                                    );

                        e.Cancel = (Verify == DialogResult.No);
                    }
                }

                else
                {
                    DeleteRepoData.Repository_Setting_Location = string.Empty;
                    DeleteRepoData.Is_Local_Clone = false;
                    DeleteRepoData.Delete_Local_Clone = false;
                }
            }
        }

        private void BrowseLocationBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseLocationBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            //DeleteRepoDescriptionSSLB.Text = Properties.Resources.DELETE_REPO_BROWSE_HOVER;
        }

        private void BrowseLocationBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseLocationBT.BackgroundImage = Properties.Resources.Browse_Icon;
            DeleteRepoDescriptionSSLB.Text = string.Empty;
        }

        private void DeleteLocalCB_MouseEnter(object sender, EventArgs e)
        {
            //DeleteRepoDescriptionSSLB.Text = Properties.Resources.DELETE_REPO_DELETE_LOCAL_INFO;
        }

        private void DeleteLocalCB_MouseLeave(object sender, EventArgs e)
        {
            DeleteRepoDescriptionSSLB.Text = string.Empty;
        }

        private void IsLocalRepoCB_MouseEnter(object sender, EventArgs e)
        {
            //DeleteRepoDescriptionSSLB.Text = Properties.Resources.DELETE_REPO_IS_CLONE_INFO;
        }

        private void IsLocalRepoCB_MouseLeave(object sender, EventArgs e)
        {
            DeleteRepoDescriptionSSLB.Text = string.Empty;
        }
    }
}
