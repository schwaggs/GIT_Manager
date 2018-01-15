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
    public partial class CloneRepoFRM : Form
    {

        public static bool retry { get; set; }

        public CloneRepoFRM()
        {
            InitializeComponent();
            retry = false;
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
                DestinationPathTB.Text = dialog.FileName;
            }
        }

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DestinationPathTB.Text) || string.IsNullOrWhiteSpace(DestinationPathTB.Text))
            {
                MessageBox.Show("Not a valid destination!.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (Helpers.Is_Git_Repo(RepoPathTB.Text))
                {
                    if (Helpers.Clone(DestinationPathTB.Text))
                    {
                    }

                    else
                    {
                        retry = true;
                    }
                }

                else
                {
                    MessageBox.Show("Not a valid repository!", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (retry)
            {
                retry = false;

                DialogResult res = MessageBox.Show("Error cloning repository, retry?", "Error Cloning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if (res == DialogResult.Retry)
                {
                    CloneRepoBT.PerformClick();
                }
            }

            return;
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
    }
}
