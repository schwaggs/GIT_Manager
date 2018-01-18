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
        public static string Username { get; set; }
        public static List<string> TempPaths { get; set; }

        public SettingsViewFRM()
        {
            InitializeComponent();
        }

        private void SettingsViewFRM_Load(object sender, EventArgs e)
        {
            TempPaths = new List<string>();

            if (string.IsNullOrEmpty(Properties.Settings.Default.ConfigPath) || string.IsNullOrWhiteSpace(Properties.Settings.Default.ConfigPath))
            {
                string filter = "Config Files|*.txt;*.gmc;*.xml;*.conf";
                bool retry = true;

                MessageBox.Show("You must specify a configuration file.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog FileDialog = new OpenFileDialog
                {
                    Title = "Select Configuration File",
                    CheckFileExists = true,
                    SupportMultiDottedExtensions = true,
                    Filter = filter,
                    InitialDirectory = @"C:\"
                };

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

                // Parse file and check if any stores exist, if not display a message to add some.
                MessageBox.Show("Saved config file path: " + Properties.Settings.Default.ConfigPath);
            }

            else
            {
                // Parse file and check if any stores exist, if not display a message to add some.
                MessageBox.Show("Using config file path: " + Properties.Settings.Default.ConfigPath);
            }
        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            
        }

        private void BrowseBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
        }

        private void BrowseBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseBT.BackgroundImage = Properties.Resources.Browse_Icon;
        }

        private void SettingsViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SaveSettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
        }

        private void SaveSettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SaveSettingsBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;
        }

        private void ResetSettingsBT_MouseEnter(object sender, EventArgs e)
        {
            ResetSettingsBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon_Hover;
        }

        private void ResetSettingsBT_MouseLeave(object sender, EventArgs e)
        {
            ResetSettingsBT.BackgroundImage = Properties.Resources.Reset_Settings_Icon;
        }

        private void SaveSettingsBT_Click(object sender, EventArgs e)
        {

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
                FileAttributes attr = File.GetAttributes(TempPathTB.Text);

                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {

                }

                else
                {

                }
            }
        }

        private void AddPathBT_MouseEnter(object sender, EventArgs e)
        {

        }

        private void AddPathBT_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
