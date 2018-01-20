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
    public partial class MainViewFRM : Form
    {
        
        public MainViewFRM()
        {
            FileInfo ConfigInfo = new FileInfo(Properties.Settings.Default.ConfigPath);

            if (string.IsNullOrEmpty(Properties.Settings.Default.ConfigPath) || string.IsNullOrWhiteSpace(Properties.Settings.Default.ConfigPath)
                || !ConfigInfo.Exists
               )
            {
                SettingsViewFRM init = new SettingsViewFRM();
                init.ShowDialog();
            }

            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();

            while (!InitializationData.Initialized)
            {
                Thread.Sleep(1000);

                if (InitializationData.Abort)
                {
                    t.Abort();

                    DialogResult retry = MessageBox.Show("Invalid Base Path\nWould you like to change it now?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    if (retry == DialogResult.No)
                    {
                        MessageBox.Show("Base path must be a valid path to continue", "Closing Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        Application.ExitThread();
                        Application.Exit();
                        Environment.Exit(1);
                    }

                    CommonOpenFileDialog dirbrowser = new CommonOpenFileDialog
                    {
                        InitialDirectory = @"C:\",
                        IsFolderPicker = true
                    };

                    if (dirbrowser.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        InitializationData.Retry = true;
                        InitializationData.Abort = false;
                        InitializationData.Initialized = false;

                        Properties.Settings.Default.RepoBaseDir = dirbrowser.FileName;
                        Properties.Settings.Default.Save();

                        t = new Thread(new ThreadStart(SplashStart));
                        t.Start();
                    }

                    else
                    {
                        MessageBox.Show("Base path must be a valid path to continue", "Closing Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        Application.ExitThread();
                        Application.Exit();
                        Environment.Exit(1);
                    }
                }
            }
            
            t.Abort();
            InitializeComponent();

            ReposLV.ShowItemToolTips = true;
            MainStatusSSL.Text = string.Empty;

            RootLocationCB_Initialize();
            RootLocationCB.SelectedIndex = 0;

            ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedValue.ToString()];

            ReposLV_Initialize();
        }

        public void SplashStart()
        {
            InitializationData.Initializer = new InitializationViewFRM();
            InitializationData.Initializer.ShowDialog();
        }

        private void NewRepoBT_Click(object sender, EventArgs e)
        {
            
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon;
        }

        private void Populate_Info_List()
        {
            RepoPathTB.Text = ManagerData.Selected_Repo.Path;
            RepoStatusCB.SelectedIndex = (int)ManagerData.Selected_Repo.Current_Status;
            LastCommitTB.Text = ManagerData.Selected_Repo.Last_Commit.ToString();
            LastCommitMessageTB.Text = ManagerData.Selected_Repo.Last_Commit_Message;

            NotesTB.Clear();
            NotesCB.Items.Clear();

            foreach (string key in ManagerData.Selected_Repo.Notes.Keys)
            {
                NotesCB.Items.Add(key);
            }

            LogsTB.Clear();
            LogsCB.Items.Clear();

            foreach (string key in ManagerData.Selected_Repo.Logs.Keys)
            {
                LogsCB.Items.Add(key);
            }
        }

        private void MainViewFRM_Load(object sender, EventArgs e)
        {
            
        }

        private void SettingsBT_Click(object sender, EventArgs e)
        {
            SettingsViewFRM settings = new SettingsViewFRM();
            settings.ShowDialog();
        }

        private void SettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon_Hover;
            MainStatusSSL.Text = "Open the settings window.";
        }

        private void SettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void RootLocationCB_Initialize()
        {
            RootLocationCB.Items.Clear();

            foreach (string key in ManagerData.Stores.Keys)
            {
                RootLocationCB.Items.Add(key);
            }

            RootLocationCB.SelectedIndex = 1;

            ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedItem.ToString()];

            if (ManagerData.Selected_Store != null)
            {
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }
        }

        private void RootLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManagerData.Selected_Store != null)
            {
                ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedItem.ToString()];
                ReposLV_Initialize();
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }
        }

        private void ReposLV_Initialize()
        {
            ReposLV.Items.Clear();

            foreach (string repo in ManagerData.Selected_Store._Repos.Keys)
            {
                ListViewItem lvi = new ListViewItem
                {
                    Name = repo,
                    Text = repo
                };

                ReposLV.Items.Add(lvi);
            }
        }

        private void ReposLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EditRepoBTP.Visible)
            {
                EditRepoBTP.Visible = true;
            }

            if (ReposLV.SelectedItems.Count > 0)
            {
                ManagerData.Selected_Repo = ManagerData.Selected_Store._Repos[ReposLV.SelectedItems[0].Name];

                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }
        }

        private void RootLocationCB_Click(object sender, EventArgs e)
        {
            // Save any changes to the last selected repo
            ReposLV.SelectedItems.Clear();
            MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            
        }

        private void RepoStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteRepoBT_Click(object sender, EventArgs e)
        {
            ListViewItem selected = ReposLV.SelectedItems[0];
            ReposLV.Items.Remove(selected);
            ReposLV.SelectedItems.Clear();

            // Actually Delete Repo

        }

        private void MoveRepoBT_Click(object sender, EventArgs e)
        {
            MoveRepoFRM MoveRepo = new MoveRepoFRM();
            MoveRepo.ShowDialog();
        }

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            CloneRepoFRM CloneRepo = new CloneRepoFRM();
            CloneRepo.ShowDialog();
        }


        private void DeleteRepoBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
            MainStatusSSL.Text = "Delete the current repository.";
        }

        private void MoveRepoBT_MouseEnter(object sender, EventArgs e)
        {
            MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon_Hover;
            MainStatusSSL.Text = "Move the current repository.";

            
        }

        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
            MainStatusSSL.Text = "Clone the current repository.";
        }

        

        

        private void DeleteRepoBT_MouseLeave(object sender, EventArgs e)
        {
            DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void MoveRepoBT_MouseLeave(object sender, EventArgs e)
        {
            MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void CloneRepoBT_MouseLeave(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void SaveRepoChangesBT_Click(object sender, EventArgs e)
        {

        }

        private void ClearRepoChangesBT_Click(object sender, EventArgs e)
        {

        }

        private void SaveRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            SaveRepoChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
            MainStatusSSL.Text = "Save all changes to the current repo.";
        }

        private void SaveRepoChangesBT_MouseLeave(object sender, EventArgs e)
        {
            SaveRepoChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void ClearRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            ClearRepoChangesBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon_Hover;
            MainStatusSSL.Text = "Clear all changes to the current repo";
        }

        private void ClearRepoChangesBT_MouseLeave(object sender, EventArgs e)
        {
            ClearRepoChangesBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void AddRepoBT_Click(object sender, EventArgs e)
        {

        }

        private void AddRepoBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
            MainStatusSSL.Text = "Add a repository to the current store";
        }

        private void AddRepoBT_MouseLeave(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }

            else
            {
                if (ManagerData.Selected_Store != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }

                else
                {
                    MainStatusSSL.Text = string.Empty;
                }
            }
        }

        private void AddNoteBT_Click(object sender, EventArgs e)
        {

        }

        private void AddNoteBT_MouseEnter(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
            MainStatusSSL.Text = "Add a note to the current repository.";
        }

        private void AddNoteBT_MouseLeave(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            MainStatusSSL.Text = string.Empty;
        }
    }
}
