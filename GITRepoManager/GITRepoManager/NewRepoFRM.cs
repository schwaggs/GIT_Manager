﻿using System;
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
    public partial class NewRepoFRM : Form
    {
        public NewRepoFRM()
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
                NewRepoData.Repository_Setting_Location = dialog.FileName;
                RepoLocationTB.Text = NewRepoData.Repository_Setting_Location;
            }
        }

        private void BrowseLocationBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseLocationBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            NewRepoDescriptionSSLB.Text = Properties.Resources.NEW_REPO_BROWSE_HOVER;

        }

        private void BrowseLocationBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseLocationBT.BackgroundImage = Properties.Resources.Browse_Icon;
            NewRepoDescriptionSSLB.Text = string.Empty;
        }

        private void NewRepoFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool StoreData = true;
            NewRepoData.Repository_Setting_Use_Location = false;

            if (
                    string.IsNullOrEmpty(RepoNameTB.Text) &&
                    string.IsNullOrEmpty(RepoLocationTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoNameTB.Text) &&
                    string.IsNullOrWhiteSpace(RepoLocationTB.Text)
               )
            {}

            else
            {
                if (String.IsNullOrEmpty(RepoNameTB.Text) || String.IsNullOrWhiteSpace(RepoNameTB.Text))
                {
                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Repository name is empty, use location as repository name?",
                                    "Close New Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    if (Verify == DialogResult.Yes)
                    {
                        NewRepoData.Repository_Setting_Use_Location = true;
                    }

                    e.Cancel = (Verify == DialogResult.No);
                }

                if (String.IsNullOrEmpty(RepoLocationTB.Text) || String.IsNullOrWhiteSpace(RepoLocationTB.Text))
                {
                    StoreData = false;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Repository location is empty, close window?",
                                    "Close New Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    e.Cancel = (Verify == DialogResult.No);

                }

                if (StoreData)
                {
                    NewRepoData.Repository_Setting_Name = RepoNameTB.Text;
                    NewRepoData.Repository_Setting_Location = RepoLocationTB.Text;
                    NewRepoData.Repository_Option_Bare = OptionBareCB.Checked;
                    NewRepoData.Repository_Option_Readme = OptionReadmeCB.Checked;

                    var Verify = MessageBox.Show
                                (
                                    this,
                                    "Are you sure you want to create this repository?",
                                    "Close New Repo Window",
                                    MessageBoxButtons.YesNo
                                );

                    if (Verify == DialogResult.Yes)
                    {
                        NewRepoMethods.CreateNewRepository();
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
                    NewRepoData.Repository_Setting_Name = String.Empty;
                    NewRepoData.Repository_Setting_Location = String.Empty;
                    NewRepoData.Repository_Option_Bare = false;
                    NewRepoData.Repository_Option_Readme = false;
                }
            }
        }

        private void OptionBareCB_MouseEnter(object sender, EventArgs e)
        {
            NewRepoDescriptionSSLB.Text = Properties.Resources.NEW_REPO_BARE_INFO;
        }

        private void OptionBareCB_MouseLeave(object sender, EventArgs e)
        {
            NewRepoDescriptionSSLB.Text = string.Empty;
        }

        private void OptionReadmeCB_MouseEnter(object sender, EventArgs e)
        {
            NewRepoDescriptionSSLB.Text = Properties.Resources.NEW_REPO_README_INFO;
        }

        private void OptionReadmeCB_MouseLeave(object sender, EventArgs e)
        {
            NewRepoDescriptionSSLB.Text = string.Empty;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RepoLocationGB_Enter(object sender, EventArgs e)
        {

        }

        private void RepoNameGB_Enter(object sender, EventArgs e)
        {

        }
    }
}