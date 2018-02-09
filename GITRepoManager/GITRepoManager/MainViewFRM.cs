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
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class MainViewFRM : Form
    {
        public static Color LBPanelBackgroundColor = Color.FromArgb(240, 240, 245);

        public MainViewFRM(string [] filepaths = null)
        {
            //foreach (XmlNode found in Configuration.Helpers.Search_Nodes("new", false))
            //{
            //    string message = string.Empty;
            //    foreach (XmlAttribute attr in found.Attributes)
            //    {
            //        message += attr.Name + ":  " + attr.Value + Environment.NewLine;
            //    }

            //    MessageBox.Show(message);
            //}

            //Configuration.Helpers.Serialize_Condensed_All("");

            #region Normal Start

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

                //ReposLV.ShowItemToolTips = true;
                MainStatusSSL.Text = string.Empty;

                StoreLocationCB_Initialize();

                ReposLV_Initialize();
            }

            #endregion


            #region Drag and Drop

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
                        DirectoryInfo pathInfo = new DirectoryInfo(filepath);

                        if (pathInfo.Exists)
                        {
                            // Add the directory to temporary store list
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
                    // Populate manager data with temporary data to only write out to config.

                }

                if (MessageBox.Show("Stores have been added to the configuration, open GIT Manager?", "Stores Added", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ManagerData.Stores.Clear();
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

                    //ReposLV.ShowItemToolTips = true;
                    MainStatusSSL.Text = string.Empty;

                    StoreLocationCB_Initialize();

                    ReposLV_Initialize();
                }

                else
                {
                    // Dont open the program 
                    Application.ExitThread();
                    Application.Exit();
                    Environment.Exit(0);
                }
            }

            #endregion
        }

        #region Event - Form Load

        #region Event Handler - MainViewFRM

        private void MainViewFRM_Load(object sender, EventArgs e)
        {

        }

        #endregion Event Handler - MainViewFRM

        #endregion Event -Form Load


        #region Mouse Click

        #region NewRepoBT

        private void NewRepoBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region SettingsBT

        private void SettingsBT_Click(object sender, EventArgs e)
        {
            SettingsViewFRM settings = new SettingsViewFRM();
            settings.ShowDialog();
        }

        #endregion


        #region StoreLocationCB

        private void StoreLocationCB_Click(object sender, EventArgs e)
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

        #endregion


        #region DeleteRepoBT

        private void DeleteRepoBT_Click(object sender, EventArgs e)
        {
            ListViewItem selected = ReposLV.SelectedItems[0];
            ReposLV.Items.Remove(selected);
            ReposLV.SelectedItems.Clear();

            // Actually Delete Repo

        }

        #endregion


        #region MoveRepoBT

        private void MoveRepoBT_Click(object sender, EventArgs e)
        {
            MoveRepoFRM MoveRepo = new MoveRepoFRM();
            MoveRepo.ShowDialog();
        }

        #endregion


        #region CloneRepoBT

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            CloneRepoFRM CloneRepo = new CloneRepoFRM(ManagerData.Selected_Repo.Path);
            CloneRepo.ShowDialog();
        }

        #endregion


        #region SaveRepoChangesBT

        private void SaveRepoChangesBT_Click(object sender, EventArgs e)
        {
            ManagerData.Selected_Repo.Current_Status = ManagerData.Selected_Repo_Copy.Current_Status;
            Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);
        }

        #endregion


        #region ClearRepoChangesBT

        private void ClearRepoChangesBT_Click(object sender, EventArgs e)
        {
            ManagerData.Copy_Selected_Repo();
            Populate_Info_List();

        }

        #endregion ClearRepoChangesBT
        

        #region AddRepoBT

        private void AddRepoBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region AddNoteBT

        private void AddNoteBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region NotesBT

        private void NotesBT_Click(object sender, EventArgs e)
        {
            if (ManagerData.Selected_Repo_Copy != null)
            {
                NoteEditor EditNotes = new NoteEditor();
                EditNotes.ShowDialog();
            }
        }

        #endregion


        #region LogsBT

        private void LogsBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region RefreshStoresBT

        private void RefreshStoresBT_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            MainStatusSSL.Text = "Refreshing ...";

            Refresh_Elements();

            this.Cursor = Cursors.Default;

        }

        #endregion
        
        #endregion
        

        #region Mouse Enter

        #region BrowseRepoSourceBT

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        #endregion


        #region SettingsBT

        private void SettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon_Hover;
            MainStatusSSL.Text = "Open the settings window.";
        }

        #endregion


        #region DeleteRepoBT

        private void DeleteRepoBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
            MainStatusSSL.Text = "Delete the current repository.";
        }

        #endregion


        #region MoveRepoBT

        private void MoveRepoBT_MouseEnter(object sender, EventArgs e)
        {
            MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon_Hover;
            MainStatusSSL.Text = "Move the current repository.";


        }

        #endregion


        #region CloneRepoBT

        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
            MainStatusSSL.Text = "Clone the current repository.";
        }

        #endregion


        #region SaveRepoChangesBT

        private void SaveRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            SaveRepoChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
            MainStatusSSL.Text = "Save all changes to the current repo.";
        }

        #endregion


        #region ClearRepoChangesBT

        private void ClearRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            ClearRepoChangesBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon_Hover;
            MainStatusSSL.Text = "Clear all changes to the current repo";
        }

        #endregion


        #region AddRepoBT

        private void AddRepoBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
            MainStatusSSL.Text = "Add a repository to the current store";
        }

        #endregion


        #region LogsBT

        private void LogsBT_MouseEnter(object sender, EventArgs e)
        {
            LogsBT.BackgroundImage = Properties.Resources.Log_Icon_Hover;
        }

        #endregion


        #region NotesBT

        private void NotesBT_MouseEnter(object sender, EventArgs e)
        {
            NotesBT.BackgroundImage = Properties.Resources.Notes_Icon_Hover;
        }

        #endregion


        #region RefreshStoresBT

        private void RefreshStoresBT_MouseEnter(object sender, EventArgs e)
        {
            RefreshStoresBT.BackgroundImage = Properties.Resources.RefreshIconHover;
            MainStatusSSL.Text = "Manually refresh all repository stores.";
        }

        #endregion

                
        #endregion Mouse Enter


        #region Mouse Leave
                
        #region SettingsBT

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

        #endregion


        #region DeleteRepoBT

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

        #endregion


        #region MoveRepoBT

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

        #endregion


        #region CloneRepoBT

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

        #endregion


        #region SaveRepoChangesBT

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

        #endregion


        #region ClearRepoChangesBT

        private void ClearRepoChangesBT_MouseLeave(object sender, EventArgs e)
        {
            ClearRepoChangesBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
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

        #endregion


        #region AddRepoBT

        private void AddRepoBT_MouseLeave(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
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

        #endregion


        #region RefreshStoresBT

        private void RefreshStoresBT_MouseLeave(object sender, EventArgs e)
        {
            RefreshStoresBT.BackgroundImage = Properties.Resources.RefreshIcon;

            if (ReposLV.SelectedItems.Count > 0)
            {
                MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
            }

            else if (StoreLocationCB.SelectedItem != null)
            {
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }

            else
            {
                MainStatusSSL.Text = "";
            }
        }

        #endregion


        #region NotesBT

        private void NotesBT_MouseLeave(object sender, EventArgs e)
        {
            NotesBT.BackgroundImage = Properties.Resources.Notes_Icon;
        }

        #endregion


        #region LogsBT

        private void LogsBT_MouseLeave(object sender, EventArgs e)
        {
            LogsBT.BackgroundImage = Properties.Resources.Log_Icon;
        }

        #endregion

        #endregion


        #region Index Changed

        #region StoreLocationCB

        private void StoreLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerData.Selected_Store = ManagerData.Stores[StoreLocationCB.SelectedItem.ToString()];
            ReposLV_Initialize();
            MainStatusSSL.Text = ManagerData.Selected_Store._Path;
        }

        #endregion


        #region ReposLV

        private void ReposLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!EditRepoBTP.Visible)
            {
                EditRepoBTP.Visible = true;
            }

            if (ReposLV.SelectedItems.Count > 0)
            {
                ManagerData.Selected_Repo = ManagerData.Selected_Store._Repos[ReposLV.SelectedItems[0].Name];

                ManagerData.Copy_Selected_Repo();

                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                    Populate_Info_List();
                }
            }
        }

        #endregion


        #region RepoStatusCB

        private void RepoStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerData.Selected_Repo_Copy.Current_Status = RepoCell.Status.ToType(RepoStatusCB.SelectedItem.ToString());
        }

        #endregion


        #endregion


        #region Main Form Methods

        public void SplashStart()
        {
            InitializationData.Initializer = new InitializationViewFRM();
            InitializationData.Initializer.ShowDialog();
        }






        private void Populate_Info_List()
        {
            if (ManagerData.Selected_Repo_Copy != null)
            {
                RepoPathTB.Text = ManagerData.Selected_Repo_Copy.Path;
                RepoStatusCB.SelectedIndex = (int)ManagerData.Selected_Repo_Copy.Current_Status;
                LastCommitTB.Text = ManagerData.Selected_Repo_Copy.Last_Commit.ToString();
                LastCommitMessageTB.Text = ManagerData.Selected_Repo_Copy.Last_Commit_Message;
            }

            else
            {
                StoreLocationCB.Focus();
            }
        }





        private void StoreLocationCB_Initialize()
        {
            StoreLocationCB.Items.Clear();

            foreach (string key in ManagerData.Stores.Keys)
            {
                StoreLocationCB.Items.Add(key);
            }

            if (ManagerData.Stores.Count > 0)
            {
                StoreLocationCB.SelectedItem = StoreLocationCB.Items[0];
                ManagerData.Selected_Store = ManagerData.Stores[StoreLocationCB.SelectedItem.ToString()];
                MainStatusSSL.Text = ManagerData.Selected_Store._Path;
            }

            else
            {
                ManagerData.Selected_Store = null;
                MainStatusSSL.Text = "No Store Selected";
            }
        }





        private void ReposLV_Initialize()
        {
            ReposLV.Items.Clear();

            if (ManagerData.Selected_Store != null)
            {
                try
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

                catch
                {
                }
            }
        }





        public void Refresh_Elements()
        {
            // Clear current data
            ManagerData.Selected_Repo = null;
            ManagerData.Selected_Store = null;
            ManagerData.Stores.Clear();

            // Clear elements that depend on current data
            ReposLV.Items.Clear();
            StoreLocationCB.Items.Clear();

            // Re-read from the file
            Configuration.Helpers.Deserialize_Condensed(Properties.Settings.Default.ConfigPath);

            // Repopulate elements with new data
            StoreLocationCB_Initialize();
            ReposLV_Initialize();
        }

        #endregion
    }
}
