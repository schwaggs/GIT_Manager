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

        public SettingsViewFRM()
        {
            InitializeComponent();
        }

        private void SettingsViewFRM_Load(object sender, EventArgs e)
        {
            TempPaths = new List<string>();

            FileInfo ConfigInfo = new FileInfo(Properties.Settings.Default.ConfigPath);

            if (string.IsNullOrEmpty(Properties.Settings.Default.ConfigPath) || string.IsNullOrWhiteSpace(Properties.Settings.Default.ConfigPath)
                || !ConfigInfo.Exists)
            {
                string filter = "Config Files|*.txt;*.gmc;*.xml;*.conf";
                bool retry = true;

                MessageBox.Show("You must specify a configuration file.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveFileDialog FileDialog = new SaveFileDialog
                {
                    Title = "Select Configuration File",
                    CheckFileExists = true,
                    SupportMultiDottedExtensions = true,
                    CreatePrompt = false,
                    OverwritePrompt = false,
                    Filter = filter,
                    DefaultExt = "gmc",
                    InitialDirectory = @"C:\"
                };

                FileDialog.CheckFileExists = false;
                FileDialog.CheckPathExists = false;

                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(FileDialog.FileName) || !string.IsNullOrWhiteSpace(FileDialog.FileName))
                    {
                        FileInfo fileInfo = new FileInfo(FileDialog.FileName);

                        if (fileInfo.Exists)
                        {
                            Properties.Settings.Default.ConfigPath = FileDialog.FileName;
                            Properties.Settings.Default.Save();

                            retry = false;
                        }

                        else
                        {
                            try
                            {
                                fileInfo.Create();
                                retry = false;
                            }
                            catch
                            {
                            }
                        }
                    }
                }

                while (retry)
                {
                    DialogResult res;
                    res = MessageBox.Show("You must specify a valid configuration file.", "Invalid Config File", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (res == DialogResult.Cancel)
                    {
                        Application.ExitThread();
                        Application.Exit();
                        Environment.Exit(1);
                    }

                    if (FileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(FileDialog.FileName) || !string.IsNullOrWhiteSpace(FileDialog.FileName))
                        {
                            FileInfo fileInfo = new FileInfo(FileDialog.FileName);

                            if (fileInfo.Exists)
                            {
                                Properties.Settings.Default.ConfigPath = FileDialog.FileName;
                                Properties.Settings.Default.Save();

                                retry = false;
                            }
                        }
                    }
                }
            }

            ConfigPathTB.Text = Properties.Settings.Default.ConfigPath;

            Populate_Stores();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.CloneLocalSourcePath) || !string.IsNullOrWhiteSpace(Properties.Settings.Default.CloneLocalSourcePath))
            {
                CloneDestinationTB.Text = Properties.Settings.Default.CloneLocalSourcePath;
            }
        }






        private void Populate_Stores()
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

        private void BrowseBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
            SettingsInfoSSSL.Text = "Browse to a store location.";
        }

        private void BrowseBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        private void SettingsViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SaveSettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
            SettingsInfoSSSL.Text = "Save any modifications to the configuration.";
        }

        private void SaveSettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        private void SaveSettingsBT_Click(object sender, EventArgs e)
        {
            Add_Temp_Stores();
            Configuration.Helpers.Serialize_Replace(Properties.Settings.Default.ConfigPath, ManagerData.Stores);

            if (!string.IsNullOrEmpty(CloneDestinationTB.Text) || !string.IsNullOrWhiteSpace(CloneDestinationTB.Text))
            {
                Properties.Settings.Default.CloneLocalSourcePath = CloneDestinationTB.Text;
                Properties.Settings.Default.Save();
            }
        }

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

        private void AddPathBT_MouseEnter(object sender, EventArgs e)
        {
            AddPathBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
            SettingsInfoSSSL.Text = "Add a store to the configuration.";
        }

        private void AddPathBT_MouseLeave(object sender, EventArgs e)
        {
            AddPathBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            SettingsInfoSSSL.Text = string.Empty;
        }

        private void DeleteLocationBT_Click(object sender, EventArgs e)
        {

        }

        private void DeleteLocationBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteLocationBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
            SettingsInfoSSSL.Text = "Remove the selected store(s) from the configuration.";
        }

        private void DeleteLocationBT_MouseLeave(object sender, EventArgs e)
        {
            DeleteLocationBT.BackgroundImage = Properties.Resources.DeleteIcon;
            SettingsInfoSSSL.Text = string.Empty;
        }

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
    }
}
