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
using static System.Windows.Forms.ListViewItem;

namespace GITRepoManager
{
    public partial class SettingsViewFRM : Form
    {
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
            FileInfo ConfigInfo = new FileInfo(Properties.Settings.Default.ConfigPath);
            MainViewFRM.Settings_Changed = false;

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

            if (Properties.Settings.Default.LogParseMethod == 0)
            {
                SingleParseRB.Checked = true;
            }

            else
            {
                DynamicParseRB.Checked = true;
            }
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
            SaveMessageLB.Text = string.Empty;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (string.IsNullOrEmpty(dialog.FileName) || string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    MessageBox.Show("Path to add cannot be empty.", "Empty Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dialog.FileName);

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
                    }

                    else
                    {
                        MessageBox.Show("Could not find " + dialog.FileName);
                    }
                }
            }
        }

        #endregion


        #region SaveSettingsBT

        private void SaveSettingsBT_Click(object sender, EventArgs e)
        {
            bool changed = false;

            SaveMessageLB.Text = string.Empty;

            if (!string.IsNullOrEmpty(CloneDestinationTB.Text) && !string.IsNullOrWhiteSpace(CloneDestinationTB.Text))
            {
                if (CloneDestinationTB.Text != Properties.Settings.Default.CloneLocalSourcePath)
                {
                    Properties.Settings.Default.CloneLocalSourcePath = CloneDestinationTB.Text;
                    changed = true;
                }
            }

            if (Store_List_Changed())
            {
                changed = true;
                MainViewFRM.Settings_Changed = true;

                // Add new items
                foreach (ListViewItem lvi in StoreLocationLV.Items)
                {
                    if (!ManagerData.Stores.Keys.Contains(lvi.Name))
                    {
                        StoreCell temp = null;
                        temp = new StoreCell(lvi.SubItems[1].Name);
                        temp._Repos = Get_Repos(new DirectoryInfo(lvi.SubItems[1].Name));

                        if (temp != null)
                        {
                            DirectoryInfo tempInfo = new DirectoryInfo(temp._Path);
                            ManagerData.Stores.Add(tempInfo.Name, temp);
                        }
                    }
                }

                List<string> DeletedKeys = new List<string>();

                foreach (string key in ManagerData.Stores.Keys)
                {
                    if (StoreLocationLV.Items.Count > 0)
                    {
                        bool removeKey = true;

                        foreach (ListViewItem lvi in StoreLocationLV.Items)
                        {
                            if (lvi.Name == key)
                            {
                                removeKey = false;
                            }
                        }

                        if (removeKey)
                        {
                            DeletedKeys.Add(key);
                        }
                    }
                }

                if (StoreLocationLV.Items.Count == 0 && ManagerData.Stores.Count != 0)
                {
                    ManagerData.Stores.Clear();
                }

                else
                {
                    foreach (string key in DeletedKeys)
                    {
                        ManagerData.Stores.Remove(key);
                    }
                }
            }

            // Singular Parse
            int selected = 0;

            if (DynamicParseRB.Checked)
            {
                // Dynamic Parse
                selected = 1;
            }

            if (selected != Properties.Settings.Default.LogParseMethod)
            {
                Properties.Settings.Default.LogParseMethod = selected;
                changed = true;
            }

            if (changed)
            {
                changed = false;

                Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Reload();
                SaveMessageLB.Text = "Settings successfully saved.";
            }
        }

        #endregion


        #region BrowseClonePathBT

        private void BrowseClonePathBT_Click(object sender, EventArgs e)
        {
            SaveMessageLB.Text = string.Empty;

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
            SaveMessageLB.Text = string.Empty;

            ListViewItem selected = StoreLocationLV.SelectedItems[0];

            StoreLocationLV.SelectedItems.Clear();
            StoreLocationLV.Items.Remove(selected);
        }

        #endregion


        #region AddPathBT

        private void AddPathBT_Click(object sender, EventArgs e)
        {
            
        }

        #endregion


        #region ConfigPathTB

        private void ConfigPathTB_Click(object sender, EventArgs e)
        {
            ConfigPathTB.SelectAll();
        }

        #endregion

        #endregion Click


        #region Enter

        #region BrowseBT

        private void BrowseBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
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


        #region DeleteLocationBT

        private void DeleteLocationBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteLocationBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
            SettingsInfoSSSL.Text = "Remove the selected store from the configuration.";
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
            BrowseBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
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


        #region Text Box

        private void CloneDestinationTB_TextChanged(object sender, EventArgs e)
        {
            SaveMessageLB.Text = string.Empty;
        }

        #endregion Text Box

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


        #region Store_List_Changed

        private bool Store_List_Changed()
        {
            foreach (ListViewItem lvi in StoreLocationLV.Items)
            {
                if (!ManagerData.Stores.Keys.Contains(lvi.Name))
                {
                    return true;
                }
            }

            if (StoreLocationLV.Items.Count != ManagerData.Stores.Count)
            {
                return true;
            }

            return false;
        }

        #endregion

        #endregion Methods
    }
}
