using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class MainViewFRM : Form
    {
        public static Color LBPanelBackgroundColor = Color.FromArgb(240, 240, 245);
        public static Thread Splash { get; set; }

        public static bool Settings_Changed { get; set; }
        private static List<string> Refresh_Repo_Additions { get; set; }
        private static List<RepoCell> Refresh_Repo_Deletions { get; set; }

        private bool Refresh_Complete { get; set; }
        private string Refresh_Message { get; set; }

        private string Current_Status { get; set; }

        public MainViewFRM(string [] filepaths = null)
        {
            #region Normal Start

            #region Registry Stuff - Not Used

            //RegistryKey fileAssoc = Registry.ClassesRoot.OpenSubKey(@".gmc", true);

            //if (fileAssoc != null)
            //{
            //    RegistryKey iconSet = fileAssoc.OpenSubKey("DefaultIcon", true);

            //    if (iconSet != null)
            //    {
            //        string val = (string)iconSet.GetValue("", string.Empty);

            //        if (val != string.Empty)
            //        {

            //        }

            //        else
            //        {
            //            iconSet.SetValue("", @"Z:\Software Engineering\GIT Management Config\FileIcon.ico");
            //        }
            //    }

            //    else
            //    {
            //        MessageBox.Show("No Icon Set");
            //        fileAssoc.CreateSubKey("DefaultIcon");
            //        iconSet = fileAssoc.OpenSubKey("DefaultIcon");
            //        iconSet.SetValue("(Default)", @"Z:\Software Engineering\Published Applications\GIT Manager\FileIcon.ico");
            //        iconSet.Close();
            //        fileAssoc.Close();
            //    }
            //}

            //else
            //{

            //}

            #endregion Registry Stuff - Not Used

            if (filepaths == null)
            {
                Splash = new Thread(new ThreadStart(SplashStart));
                Splash.Start();

                while (!InitializationData.Initialized)
                {
                    Thread.Sleep(1000);

                    if (InitializationData.Abort)
                    {
                        Splash.Abort();

                        MessageBox.Show("Error loading configuration, closing GIT Manager.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.ExitThread();
                        Application.Exit();
                        Environment.Exit(1);
                    }
                }

                InitializeComponent();

                Splash.Abort();

                Refresh_Elements();

                //ReposLV.ShowItemToolTips = true;
                MainStatusSSL.Text = string.Empty;

                StoreLocationCB_Initialize();

                ReposLV_Initialize();
            }

            #endregion
        }

        #region Events

        #region Form Load

        #region MainViewFRM

        private void MainViewFRM_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion Form Load


        #region Mouse Click

        #region NewRepoBT

        private void NewRepoBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region SettingsBT

        private void SettingsBT_Click(object sender, EventArgs e)
        {
            string currStore = StoreLocationCB.SelectedItem.ToString();

            SettingsViewFRM settings = new SettingsViewFRM();
            settings.ShowDialog();

            if (Settings_Changed)
            {
                Configuration.Helpers.Deserialize_Condensed(Properties.Settings.Default.ConfigPath);
                MainStatusSSL.Text = string.Empty;
                StoreLocationCB_Initialize();
                ReposLV_Initialize();
            }

            int index = StoreLocationCB.FindStringExact(currStore);

            if (index != -1)
            {
                StoreLocationCB.SelectedIndex = index;
            }

            else
            {
                StoreLocationCB.SelectedIndex = 0;
            }
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


        #region CloneRepoBT

        private void CloneRepoBT_Click(object sender, EventArgs e)
        {
            try
            {
                CloneRepoFRM CloneRepo = new CloneRepoFRM(ManagerData.Selected_Repo.Path);
                CloneRepo.ShowDialog();
            }

            catch
            {

            }
        }

        #endregion


        #region SaveRepoChangesBT

        private void SaveRepoChangesBT_Click(object sender, EventArgs e)
        {
            ManagerData.Selected_Repo.Current_Status = ManagerData.Selected_Repo_Copy.Current_Status;
            Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);

            ReposLV.Select();
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
            AddRepoFRM New_Repo = new AddRepoFRM(ManagerData.Selected_Store._Path);
            New_Repo.ShowDialog();

            if (New_Repo.Repo_Added)
            {
                RefreshStoresBT_Click(null, null);
            }
        }

        #endregion


        #region AddNoteBT

        #endregion


        #region NotesBT

        private void NotesBT_Click(object sender, EventArgs e)
        {
            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo_Copy != null)
                {
                    NoteEditorFRM EditNotes = new NoteEditorFRM();
                    EditNotes.ShowDialog();

                    ReposLV.Select();
                }
            }
        }

        #endregion


        #region LogsBT

        private void LogsBT_Click(object sender, EventArgs e)
        {
            if (ReposLV.SelectedItems.Count > 0)
            {
                if (ManagerData.Selected_Repo != null)
                {
                    LogViewerFRM logs = new LogViewerFRM(ManagerData.Selected_Repo.Path);
                    logs.ShowDialog();
                }
            }
        }

        #endregion


        #region RefreshStoresBT

        private void RefreshStoresBT_Click(object sender, EventArgs e)
        {
            string currStore = StoreLocationCB.SelectedItem.ToString();

            this.Cursor = Cursors.WaitCursor;

            MainStatusSSL.Text = "Refreshing ...";

            // Need to rescan the current store for any new repos
            if (ManagerData.Selected_Store != null || !(string.IsNullOrEmpty(StoreLocationCB.SelectedItem.ToString()) && string.IsNullOrWhiteSpace(StoreLocationCB.SelectedItem.ToString())))
            {
                int instanceCount = ManagerData.Selected_Store._Repos.Count;
                int currCount = Get_Store_Count();

                if (RepoHelpers.Detect_Changes())
                {

                    Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);
                    Refresh_Elements();
                    MainStatusSSL.Text = "Refresh Complete - Changes Were Applied";
                    //MessageBox.Show("Changes were detected and applied.", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    //MessageBox.Show("No changes were detected\n\nIf you just added a repo you will need to commit at least once for it to be detected.", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainStatusSSL.Text = "Refresh Complete - No Changes Detected";
                }

                this.Cursor = Cursors.Default;

                Refresh_Complete = true;
            }

            else
            {
                Refresh_Complete = false;
            }


            StoreLocationCB.SelectedIndex = StoreLocationCB.FindStringExact(currStore);
        }

        #endregion


        #region RepoPathTB

        private void RepoPathTB_Click(object sender, EventArgs e)
        {
            RepoPathTB.SelectAll();
        }

        #endregion


        #region OpenStoreBT

        private void OpenStoreBT_Click(object sender, EventArgs e)
        {
            if (ManagerData.Selected_Store != null)
            {
                System.Diagnostics.Process.Start("explorer.exe", ManagerData.Selected_Store._Path);
            }
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


        #region CloneRepoBT

        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
        {
            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
            MainStatusSSL.Text = "Clone " + ManagerData.Selected_Repo.Name;
        }

        #endregion


        #region SaveRepoChangesBT

        private void SaveRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            SaveRepoChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
            MainStatusSSL.Text = "Save all changes to " + ManagerData.Selected_Repo.Name;
        }

        #endregion


        #region ClearRepoChangesBT

        private void ClearRepoChangesBT_MouseEnter(object sender, EventArgs e)
        {
            ClearRepoChangesBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon_Hover;
            MainStatusSSL.Text = "Clear all changes to " + ManagerData.Selected_Repo.Name;
        }

        #endregion


        #region AddRepoBT

        private void AddRepoBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
            MainStatusSSL.Text = "Add a repository to " + StoreLocationCB.SelectedItem.ToString();
        }

        #endregion


        #region LogsBT

        private void LogsBT_MouseEnter(object sender, EventArgs e)
        {
            LogsBT.BackgroundImage = Properties.Resources.Log_Icon_Hover;

            if (ManagerData.Selected_Repo != null)
            {
                Current_Status = MainStatusSSL.Text;
                MainStatusSSL.Text = "Open the logs for " + ManagerData.Selected_Repo.Name;
            }
        }

        #endregion


        #region NotesBT

        private void NotesBT_MouseEnter(object sender, EventArgs e)
        {
            NotesBT.BackgroundImage = Properties.Resources.Notes_Icon_Hover;

            if (ManagerData.Selected_Repo != null)
            {
                Current_Status = MainStatusSSL.Text;
                MainStatusSSL.Text = "Open notes for " + ManagerData.Selected_Repo.Name;
            }
        }

        #endregion


        #region RefreshStoresBT

        private void RefreshStoresBT_MouseEnter(object sender, EventArgs e)
        {
            RefreshStoresBT.BackgroundImage = Properties.Resources.RefreshIconHover;

            if (Refresh_Complete)
            {
                Refresh_Complete = false;
                Refresh_Message = MainStatusSSL.Text;
            }

            else
            {
                Refresh_Message = string.Empty;
            }

            MainStatusSSL.Text = "Manually refresh all repository stores.";
        }

        #endregion


        #region OpenStoreBT

        private void OpenStoreBT_MouseEnter(object sender, EventArgs e)
        {
            OpenStoreBT.BackgroundImage = Properties.Resources.OpenFolderIcon_Hover;

            MainStatusSSL.Text = "Open " + StoreLocationCB.SelectedItem.ToString() + " in explorer.";
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

            if (Refresh_Complete)
            {
                Refresh_Complete = false;
                Refresh_Message = MainStatusSSL.Text;
            }

            else
            {
                Refresh_Message = string.Empty;
            }

            if (Refresh_Message != string.Empty)
            {
                MainStatusSSL.Text = Refresh_Message;
            }

            else
            {
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
        }

        #endregion


        #region NotesBT

        private void NotesBT_MouseLeave(object sender, EventArgs e)
        {
            NotesBT.BackgroundImage = Properties.Resources.Notes_Icon;

            if (ManagerData.Selected_Repo != null)
            {
                MainStatusSSL.Text = Current_Status;
                Current_Status = string.Empty;
            }
        }

        #endregion


        #region LogsBT

        private void LogsBT_MouseLeave(object sender, EventArgs e)
        {
            LogsBT.BackgroundImage = Properties.Resources.Log_Icon;

            if (ManagerData.Selected_Repo != null)
            {
                MainStatusSSL.Text = Current_Status;
                Current_Status = string.Empty;
            }

        }

        #endregion


        #region OpenStoreBT

        private void OpenStoreBT_MouseLeave(object sender, EventArgs e)
        {
            OpenStoreBT.BackgroundImage = Properties.Resources.OpenFolderIcon;

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

        #endregion


        #region Index Changed

        #region StoreLocationCB

        private void StoreLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ManagerData.Stores.Keys.Contains(StoreLocationCB.SelectedItem.ToString()))
                {
                    ManagerData.Selected_Store = ManagerData.Stores[StoreLocationCB.SelectedItem.ToString()];
                    ReposLV_Initialize();
                    MainStatusSSL.Text = ManagerData.Selected_Store._Path;
                }
            }

            catch
            {
                RepoPathTB.Clear();
                LastCommitTB.Clear();
                LastCommitMessageTB.Clear();
            }
        }

        #endregion


        #region ReposLV

        private void ReposLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReposLV.SelectedItems.Count > 0)
            {
                ManagerData.Selected_Repo = ManagerData.Selected_Store._Repos[ReposLV.SelectedItems[0].Name];

                ManagerData.Copy_Selected_Repo();

                if (ManagerData.Selected_Repo != null)
                {
                    MainStatusSSL.Text = ManagerData.Selected_Repo.Path;
                }

                RepoStatusCB.Enabled = true;
                CloneRepoBT.Visible = true;

                if (!ManagerData.Selected_Repo.Logs_Parsed && Properties.Settings.Default.LogParseMethod == 0 || Properties.Settings.Default.LogParseMethod == 1)
                {
                    Process LogP = RepoHelpers.Create_Process(ManagerData.Selected_Repo.Path, " git --no-pager log");
                    LogP.Start();
                    string Raw_Log = LogP.StandardOutput.ReadToEnd();
                    LogP.StandardInput.WriteLine("exit");
                    LogP.WaitForExit();

                    if (Properties.Settings.Default.LogParseMethod == 1 && ManagerData.Selected_Repo.Logs != null)
                    {
                        ManagerData.Selected_Repo.Logs.Clear();
                    }

                    RepoHelpers.Parse_Logs(Raw_Log, ManagerData.Selected_Repo);
                    ManagerData.Selected_Repo.Logs_Parsed = true;

                    if (Properties.Settings.Default.LogParseMethod == 0)
                    {
                        ManagerData.Selected_Repo.Logs_Parsed = true;
                    }
                }

                Populate_Info_List();
            }

            else
            {
                RepoStatusCB.Enabled = false;
                RepoStatusCB.SelectedIndex = -1;
                RepoPathTB.Clear();
                LastCommitTB.Clear();
                LastCommitMessageTB.Clear();
                MainStatusSSL.Text = string.Empty;
                CloneRepoBT.Visible = false;
            }
        }

        #endregion


        #region RepoStatusCB

        private void RepoStatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RepoStatusCB.SelectedIndex > -1)
            {
                ManagerData.Selected_Repo_Copy.Current_Status = RepoCell.Status.ToType(RepoStatusCB.SelectedItem.ToString());
            }
        }

        #endregion


        #endregion

        #endregion Events


        #region Main Form Methods

        #region SplashStart

        public void SplashStart()
        {
            InitializationData.Initializer = new InitializationViewFRM();

            try
            {
                InitializationData.Initializer.ShowDialog();
            }

            catch
            {

            }
        }

        #endregion SplashStart


        #region Populate_Info_List

        private void Populate_Info_List()
        {
            if (ManagerData.Selected_Repo != null)
            {
                RepoPathTB.Text = ManagerData.Selected_Repo.Path;
                RepoStatusCB.SelectedIndex = (int)ManagerData.Selected_Repo.Current_Status;
                LastCommitTB.Text = ManagerData.Selected_Repo.Last_Commit.ToString();
                LastCommitMessageTB.Text = ManagerData.Selected_Repo.Last_Commit_Message;
            }

            else
            {
                StoreLocationCB.Focus();
            }
        }

        #endregion Populate_Info_List


        #region StoreLocationCB_Initialize

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

        #endregion StoreLocationCB_Initialize


        #region ReposLV_Initialize

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

            if (ReposLV.SelectedItems.Count == 0)
            {
                RepoStatusCB.SelectedIndex = -1;
                RepoStatusCB.Enabled = false;
                RepoPathTB.Clear();
                LastCommitTB.Clear();
                LastCommitMessageTB.Clear();
            }

            else
            {
                RepoStatusCB.Enabled = true;
            }
        }

        #endregion ReposLV_Initialize


        #region Refresh_Elements

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

        #endregion Refresh_Elements


        #region Get_Store_Count

        public static int Get_Store_Count()
        {
            List<string> temp = Directory.GetDirectories(ManagerData.Selected_Store._Path).ToList();

            int count = temp.Count;

            foreach (string path in temp)
            {
                if (!RepoHelpers.Is_Git_Repo(path))
                {
                    count--;
                }
            }

            return count;
        }

        #endregion Get_Store_Count


        #region Get_Store_Additions

        public void Get_Store_Additions()
        {
            List<string> temp = Directory.GetDirectories(ManagerData.Selected_Store._Path).ToList();

            if (Refresh_Repo_Additions != null)
            {
                Refresh_Repo_Additions.Clear();
            }

            else
            {
                Refresh_Repo_Additions = new List<string>();
            }

            foreach (string path in temp)
            {
                bool contains = false;

                foreach (RepoCell cell in ManagerData.Selected_Store._Repos.Values)
                {
                    if (path == cell.Path)
                    {
                        contains = true;
                        break;
                    }
                }

                if (!contains)
                {
                    // Addition
                    if (RepoHelpers.Is_Git_Repo(path))
                    {
                        Refresh_Repo_Additions.Add(path);
                    }
                }
            }
        }

        #endregion Get_Store_Additions


        #region Get_Store_Deletions

        public static void Get_Store_Deletions()
        {
            List<string> temp = Directory.GetDirectories(ManagerData.Selected_Store._Path).ToList();

            if (Refresh_Repo_Deletions != null)
            {
                Refresh_Repo_Deletions.Clear();
            }

            else
            {
                Refresh_Repo_Deletions = new List<RepoCell>();
            }

            foreach (RepoCell cell in ManagerData.Selected_Store._Repos.Values)
            {
                bool contains = false;

                foreach (string path in temp)
                {
                    if (path == cell.Path)
                    {
                        contains = true;
                        break;
                    }
                }

                if (!contains)
                {
                    // Deletion
                    Refresh_Repo_Deletions.Add(cell);
                }
            }
        }

        #endregion Get_Store_Deletions


        #region Refresh_Store_Dictionary

        public void Refresh_Store_Dictionary()
        {
            foreach (RepoCell cell in Refresh_Repo_Deletions)
            {
                ManagerData.Selected_Store._Repos.Remove(cell.Name);
            }

            foreach (string path in Refresh_Repo_Additions)
            {
                DirectoryInfo temp = new DirectoryInfo(path);

                RepoCell newCell = new RepoCell()
                {
                    Name = temp.Name,
                    Path = temp.FullName,
                    Current_Status = RepoCell.Status.Type.NONE,
                    Notes = new Dictionary<string, string>(),
                    Last_Commit = DateTime.MinValue,
                    Last_Commit_Message = string.Empty,
                    Logs = new Dictionary<string, List<EntryCell>>()
                };

                ManagerData.Selected_Store._Repos.Add(temp.Name, newCell);
            }

            Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);

            var selectedItem = StoreLocationCB.SelectedItem;
            Refresh_Elements();
            StoreLocationCB.SelectedItem = selectedItem;
        }

        #endregion Refresh_Store_Dictionary

        #endregion

    }
}
