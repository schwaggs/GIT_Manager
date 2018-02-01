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
        public static Color LBPanelBackgroundColor = Color.FromArgb(240, 240, 245);

        public MainViewFRM(string [] filepaths = null)
        {
            Configuration.Helpers.Deserialize_Condensed("");
            if (filepaths == null)
            {
                Thread t = new Thread(new ThreadStart(SplashStart));
                t.Start();

                while (!InitializationData.Initialized)
                {
                    Thread.Sleep(1000);

                    if (InitializationData.Abort)
                    {
                        t.Abort();

                        MessageBox.Show("Error loading configuration, closing GIT Manager.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.ExitThread();
                        Application.Exit();
                        Environment.Exit(1);
                    }
                }

                t.Abort();
                InitializeComponent();

                ReposLV.ShowItemToolTips = true;
                MainStatusSSL.Text = string.Empty;

                RootLocationCB_Initialize();

                if (ManagerData.Stores.Count > 0)
                {
                    //ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedItem.ToString()];
                }

                else
                {
                    ManagerData.Selected_Store = null;
                }

                ReposLV_Initialize();
            }

            else
            {
                // Drag and dropped filepath

                // Check to make sure the path is a directory
                List<DirectoryInfo> ToAdd = new List<DirectoryInfo>();
                int filecount = 0;

                foreach (string filepath in filepaths)
                {
                    FileAttributes attr = File.GetAttributes(filepath);

                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        // It's a directory so add it
                        DirectoryInfo pathInfo = new DirectoryInfo(filepath);

                        if (pathInfo.Exists)
                        {
                            ToAdd.Add(pathInfo);
                        }
                    }

                    else
                    {
                        filecount++;
                    }
                }

                if (filecount > 0)
                {
                    MessageBox.Show("Several file paths were detected, only directories can be used as stores.", "Files Detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (ToAdd.Count > 0)
                {
                    // Parse xml first and create Stores dictionary
                    foreach (DirectoryInfo dirInfo in ToAdd)
                    {
                        StoreCell tempStore = new StoreCell(dirInfo.FullName)
                        {
                            _Repos = new Dictionary<string, RepoCell>()
                        };

                        foreach (string dir in Directory.GetDirectories(dirInfo.FullName))
                        {
                            if (RepoHelpers.Is_Git_Repo(dir))
                            {
                                DirectoryInfo repoInfo = new DirectoryInfo(dir);

                                RepoCell tempRepo = new RepoCell()
                                {
                                    Path = dir,
                                    Current_Status = RepoCell.Status.Type.NEW,
                                    Last_Commit = DateTime.MinValue,
                                    Last_Commit_Message = string.Empty,
                                    Notes = new Dictionary<string, string>(),
                                    Logs = new Dictionary<string, List<EntryCell>>()
                                };

                                tempStore._Repos.Add(repoInfo.Name, tempRepo);
                            }
                        }

                        //ManagerData.Stores.Add(dirInfo.Name, tempStore);
                    }
                }

                // Dont open the program 
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
            }
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

            //NotesTB.Clear();
            //NotesCB.Items.Clear();

            foreach (string key in ManagerData.Selected_Repo.Notes.Keys)
            {
                //NotesCB.Items.Add(key);
            }

            //LogsTB.Clear();
            //LogsCB.Items.Clear();

            foreach (string key in ManagerData.Selected_Repo.Logs.Keys)
            {
               // LogsCB.Items.Add(key);
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

            if (ManagerData.Stores.Count > 0)
            {
                RootLocationCB.SelectedItem = RootLocationCB.Items[0];
                ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedItem.ToString()];
            }

            else
            {
                ManagerData.Selected_Store = null;
            }

            if (ManagerData.Selected_Store != null)
            {
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }

            else
            {
                MainStatusSSL.Text = "Invalid Store";
            }
        }

        private void RootLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerData.Selected_Store = ManagerData.Stores[RootLocationCB.SelectedItem.ToString()];
            ReposLV_Initialize();
            MainStatusSSL.Text = ManagerData.Selected_Store._Path;
        }

        private void ReposLV_Initialize()
        {
            ReposLV.Items.Clear();

            if (ManagerData.Selected_Store != null)
            {
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

            if (ManagerData.Selected_Store != null)
            {
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }

            else
            {
                MainStatusSSL.Text = string.Empty;
            }
            
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
            CloneRepoFRM CloneRepo = new CloneRepoFRM(ManagerData.Selected_Repo.Path);
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
            //AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
            MainStatusSSL.Text = "Add a note to the current repository.";
        }

        private void AddNoteBT_MouseLeave(object sender, EventArgs e)
        {
            //AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            MainStatusSSL.Text = string.Empty;
        }

        private void RefreshStoresBT_Click(object sender, EventArgs e)
        {

        }

        private void RefreshStoresBT_MouseEnter(object sender, EventArgs e)
        {
            RefreshStoresBT.BackgroundImage = Properties.Resources.RefreshIconHover;
            MainStatusSSL.Text = "Manually refresh all repository stores.";
        }

        private void RefreshStoresBT_MouseLeave(object sender, EventArgs e)
        {
            RefreshStoresBT.BackgroundImage = Properties.Resources.RefreshIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
            }

            else if (RootLocationCB.SelectedItem != null)
            {
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }

            else
            {
                MainStatusSSL.Text = "";
            }
        }
    }
}
