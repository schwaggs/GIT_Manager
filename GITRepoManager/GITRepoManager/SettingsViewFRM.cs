using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GITRepoManager
{
    public partial class SettingsViewFRM : Form
    {
        public static List<string> TempPaths { get; set; }
        private string Clone_Path { get; set; }
        private int Store_Count { get; set; }

        public SettingsViewFRM()
        {
            InitializeComponent();
        }

        #region Events

        #region Form

        #region Load

        private void SettingsViewFRM_Load(object sender, EventArgs e)
        {
            TempPaths = new List<string>();

            FileInfo ConfigInfo = new FileInfo(Properties.Settings.Default.ConfigPath);

            if (ConfigInfo.Exists)
            {
                ConfigPathTB.Text = Properties.Settings.Default.ConfigPath;

                Populate_Stores();

                if (!string.IsNullOrEmpty(Properties.Settings.Default.CloneLocalSourcePath) || !string.IsNullOrWhiteSpace(Properties.Settings.Default.CloneLocalSourcePath))
                {
                    CloneDestinationTB.Text = Properties.Settings.Default.CloneLocalSourcePath;
                }
            }

            Clone_Path = CloneDestinationTB.Text;
            Store_Count = StoreLocationLV.Items.Count;
            TimeoutTB.Text = Properties.Settings.Default.LogProcessTimeout.ToString();
        }

        #endregion


        #region Closing

        private void SettingsViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion

        #endregion Form


        #region Mouse

        #region Click

        #region BrowseBT

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TempPathTB.Text = dialog.FileName;
            }
        }

        #endregion


        #region SaveSettingsBT

        private void SaveSettingsBT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TimeoutTB.Text) && !string.IsNullOrWhiteSpace(TimeoutTB.Text))
            {
                int temp = Properties.Settings.Default.LogProcessTimeout;

                int.TryParse(TimeoutTB.Text, out temp);
                Properties.Settings.Default.LogProcessTimeout = temp;
            }

            if (CloneDestinationTB.Text != Clone_Path || StoreLocationLV.Items.Count != Store_Count)
            {
                MainViewFRM.Settings_Changed = true;

                Add_Temp_Stores();
                Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);

                if (!string.IsNullOrEmpty(CloneDestinationTB.Text) || !string.IsNullOrWhiteSpace(CloneDestinationTB.Text))
                {
                    Properties.Settings.Default.CloneLocalSourcePath = CloneDestinationTB.Text;
                    Properties.Settings.Default.Save();
                }
            }

            else
            {
                MainViewFRM.Settings_Changed = false;
            }
        }

        #endregion


        #region BrowseClonePathBT

        private void BrowseClonePathBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CloneDestinationTB.Text = dialog.FileName;
            }
        }

        #endregion


        #region DeleteLocationBT

        private void DeleteLocationBT_Click(object sender, EventArgs e)
        {
            ListViewItem selected = StoreLocationLV.SelectedItems[0];

            if (!string.IsNullOrEmpty(selected.Text) || !string.IsNullOrWhiteSpace(selected.Text))
            {
                ManagerData.Stores.Remove(selected.Text);
            }

            StoreLocationLV.SelectedItems.Clear();
            StoreLocationLV.Items.Remove(selected);
        }

        #endregion


        #region ResetSettingsBT

        private void ResetSettingsBT_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show
            (
                "Are You Sure You Want To Clear All Config File Paths?\nYou will need to add at least one path for program to run.",
                "Reset Config Paths",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (reset == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();

                TempPathTB.Clear();
                TempPaths.Clear();
            }
        }

        #endregion


        #region AddPathBT

        private void AddPathBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TempPathTB.Text) || string.IsNullOrWhiteSpace(TempPathTB.Text))
            {
                MessageBox.Show("Path to add cannot be empty.", "Empty Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(TempPathTB.Text);

                if (dirInfo.Exists)
                {
                    ListViewItem Main = new ListViewItem
                    {
                        Name = dirInfo.Name,
                        Text = dirInfo.Name,
                    };

                    ListViewItem.ListViewSubItem Sub = new ListViewItem.ListViewSubItem
                    {
                        Name = dirInfo.FullName,
                        Text = dirInfo.FullName
                    };

                    Main.SubItems.Add(Sub);

                    StoreLocationLV.Items.Add(Main);

                    TempPathTB.Clear();
                    TempPathTB.Focus();

                    TempPaths.Add(dirInfo.FullName);
                }

                else
                {
                    MessageBox.Show("Could not find " + TempPathTB.Text);
                    TempPathTB.Focus();
                }
            }
        }

        #endregion


        #region ConfigPathTB

        private void ConfigPathTB_Click(object sender, EventArgs e)
        {
            ConfigPathTB.SelectAll();
        }

        #endregion


        #region TimeoutTB

        private void TimeoutTB_Click(object sender, EventArgs e)
        {
            TimeoutTB.SelectAll();
        }

        #endregion

        #endregion Click


        #region Enter

        #region BrowseBT

        private void BrowseBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            SettingsInfoSSSL.Text = "Browse to a store location.";
        }

        #endregion


        #region SaveSettingsBT

        private void SaveSettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
            SettingsInfoSSSL.Text = "Save this configuration.";
        }

        #endregion


        #region AddPathBT

        private void AddPathBT_MouseEnter(object sender, EventArgs e)
        {
            AddPathBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
            SettingsInfoSSSL.Text = "Add a store to the configuration.";
        }

        #endregion


        #region DeleteLocationBT

        private void DeleteLocationBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteLocationBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
            SettingsInfoSSSL.Text = "Remove the selected store(s) from the configuration.";
        }

        #endregion


        #region BrowseClonePathBT

        private void BrowseClonePathBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseClonePathBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            SettingsInfoSSSL.Text = "Browse for a default location to use when cloning.";
        }

        #endregion

        #endregion Enter


        #region Leave

        #region BrowseBT

        private void BrowseBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        #endregion


        #region SaveSettingsBT

        private void SaveSettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        #endregion


        #region AddPathBT

        private void AddPathBT_MouseLeave(object sender, EventArgs e)
        {
            AddPathBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        #endregion


        #region DeleteLocationBT

        private void DeleteLocationBT_MouseLeave(object sender, EventArgs e)
        {
            DeleteLocationBT.BackgroundImage = Properties.Resources.DeleteIcon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        #endregion


        #region BrowseClonePathBT

        private void BrowseClonePathBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseClonePathBT.BackgroundImage = Properties.Resources.Browse_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        #endregion

        #endregion Leave

        #endregion Mouse


        #region List View

        #region Selected Index Changed

        #region StoreLocationsLV

        private void StoreLocationsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StoreLocationLV.SelectedItems.Count > 0)
            {
                DeleteLocationBT.Visible = true;

                SettingsInfoSSSL.Text = StoreLocationLV.SelectedItems[0].SubItems[1].Text;
            }

            else
            {
                DeleteLocationBT.Visible = false;
            }
        }

        #endregion

        #endregion Selected Index Changed

        #endregion List View

        #endregion Events


        #region Methods

        #region Populate_Stores

        private void Populate_Stores()
        {
            if (ManagerData.Stores.Count > 0)
            {
                foreach (KeyValuePair<string, StoreCell> kvp in ManagerData.Stores)
                {
                    ListViewItem Main = new ListViewItem
                    {
                        Name = kvp.Key,
                        Text = kvp.Key,
                    };

                    ListViewItem.ListViewSubItem Sub = new ListViewItem.ListViewSubItem
                    {
                        Name = kvp.Value._Path,
                        Text = kvp.Value._Path
                    };

                    Main.SubItems.Add(Sub);

                    StoreLocationLV.Items.Add(Main);
                }
            }
        }

        #endregion


        #region Add_Temp_Stores

        private void Add_Temp_Stores()
        {
            foreach (string path in TempPaths)
            {
                DirectoryInfo pathInfo = new DirectoryInfo(path);

                if (pathInfo.Exists)
                {
                    StoreCell tempStore = new StoreCell(pathInfo.FullName)
                    {
                        _Path = pathInfo.FullName,
                        _Repos = Get_Repos(pathInfo)
                    };

                    tempStore._Count = tempStore._Repos.Count();

                    ManagerData.Stores.Add(pathInfo.Name, tempStore);
                }
            }

            TempPaths.Clear();
        }

        #endregion


        #region Get_Repos

        private Dictionary<string, RepoCell> Get_Repos(DirectoryInfo pathInfo)
        {
            Dictionary<string, RepoCell> Repos = new Dictionary<string, RepoCell>();

            foreach (string dir in Directory.GetDirectories(pathInfo.FullName))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);

                if (dirInfo.Exists)
                {
                    if (RepoHelpers.Is_Git_Repo(dir))
                    {
                        RepoCell tempRepo = new RepoCell()
                        {
                            Name = dirInfo.Name,
                            Path = dirInfo.FullName,
                            Current_Status = RepoCell.Status.Type.NEW,
                            Last_Commit = DateTime.MinValue,
                            Last_Commit_Message = "",
                            Notes = new Dictionary<string, string>(),
                            Logs = new Dictionary<string, List<EntryCell>>()
                        };

                        Repos.Add(dirInfo.Name, tempRepo);
                    }
                }
            }

            return Repos;
        }

        #endregion

        #endregion Methods

    }
}
