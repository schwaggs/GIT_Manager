using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        public SettingsViewFRM()
        {
            InitializeComponent();
        }

        private void SettingsViewFRM_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RepoListDirIsImpty)
            {
                TagsFileLocationTB.Text = Properties.Settings.Default.TagListDir;
                StatusFileLocationTB.Text = Properties.Settings.Default.StatusListDir;
            }

            else if (Properties.Settings.Default.TagListDirIsEmpty)
            {
                RepoFileLocationTB.Text = Properties.Settings.Default.RepoListDir;
                StatusFileLocationTB.Text = Properties.Settings.Default.StatusListDir;
            }

            else if (Properties.Settings.Default.StatusListDirIsEmpty)
            {
                RepoFileLocationTB.Text = Properties.Settings.Default.RepoListDir;
                TagsFileLocationTB.Text = Properties.Settings.Default.TagListDir;
            }

            else
            {
                RepoFileLocationTB.Text = Properties.Settings.Default.RepoListDir;
                TagsFileLocationTB.Text = Properties.Settings.Default.TagListDir;
                StatusFileLocationTB.Text = Properties.Settings.Default.StatusListDir;
            }

            RepoFileLocationTB.Focus();
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
                NoFocusSelectionRectangleButton tempBT = sender as NoFocusSelectionRectangleButton;

                if (sender == BrowseRepoBT)
                {
                    RepoFileLocationTB.Text = dialog.FileName;
                }

                else if (sender == BrowseTagsBT)
                {
                    TagsFileLocationTB.Text = dialog.FileName;
                }

                else if (sender == BrowseStatusBT)
                {
                    StatusFileLocationTB.Text = dialog.FileName;
                }
            }
        }

        private void BrowseBT_MouseEnter(object sender, EventArgs e)
        {
            NoFocusSelectionRectangleButton bt = sender as NoFocusSelectionRectangleButton;
            bt.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
        }

        private void BrowseBT_MouseLeave(object sender, EventArgs e)
        {
            NoFocusSelectionRectangleButton bt = sender as NoFocusSelectionRectangleButton;
            bt.BackgroundImage = Properties.Resources.Browse_Icon;
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
            Properties.Settings.Default.RepoListDir = RepoFileLocationTB.Text;
            Properties.Settings.Default.TagListDir = TagsFileLocationTB.Text;
            Properties.Settings.Default.StatusListDir = StatusFileLocationTB.Text;

            Properties.Settings.Default.Save();

            Properties.Settings.Default.RepoListDirIsImpty = false;
            Properties.Settings.Default.TagListDirIsEmpty = false;
            Properties.Settings.Default.StatusListDirIsEmpty = false;

            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.FirstRun = false;

                if (string.IsNullOrEmpty(Properties.Settings.Default.RepoListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.RepoListDir))
                {
                    Properties.Settings.Default.FirstRun = true;
                    Properties.Settings.Default.RepoListDirIsImpty = true;
                }

                if (string.IsNullOrEmpty(Properties.Settings.Default.TagListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.TagListDir))
                {
                    Properties.Settings.Default.FirstRun = true;
                    Properties.Settings.Default.TagListDirIsEmpty = true;
                }

                if (string.IsNullOrEmpty(Properties.Settings.Default.StatusListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.StatusListDir))
                {
                    Properties.Settings.Default.FirstRun = true;
                    Properties.Settings.Default.StatusListDirIsEmpty = true;
                }

                Properties.Settings.Default.Save();
            }

            else
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.RepoListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.RepoListDir))
                {
                    Properties.Settings.Default.RepoListDirIsImpty = true;
                }

                else if (string.IsNullOrEmpty(Properties.Settings.Default.TagListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.TagListDir))
                {
                    Properties.Settings.Default.TagListDirIsEmpty = true;
                }

                else if (string.IsNullOrEmpty(Properties.Settings.Default.StatusListDir) || string.IsNullOrWhiteSpace(Properties.Settings.Default.StatusListDir))
                {
                    Properties.Settings.Default.StatusListDirIsEmpty = true;
                }

                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.RepoListDirIsImpty || Properties.Settings.Default.TagListDirIsEmpty || Properties.Settings.Default.StatusListDirIsEmpty)
            {
                DialogResult close = MessageBox.Show
                (
                    "Directories cannot be blank. Close Window?",
                    "Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );

                if (close == DialogResult.Yes)
                {
                    Close();
                }
            }

            else
            {
                MessageBox.Show
                (
                    "Settings were successfully saved.",
                    "Saved Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void ResetSettingsBT_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show
            (
                "Are You Sure You Want To Reset All Settings?",
                "Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (close == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();

                RepoFileLocationTB.Text = string.Empty;
                TagsFileLocationTB.Text = string.Empty;
                StatusFileLocationTB.Text = string.Empty;

                Close();
            }
        }
    }
}
