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
        public static InitializationViewFRM temp { get; set; }

        public MainViewFRM()
        {
            //InvalidPath();

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
            RootLocationCB_Initialize();
            ReposLV_Initialize();
        }

        public void InvalidPath()
        {
            Properties.Settings.Default.RepoBaseDir = @"Z:\Software Engineering";
            Properties.Settings.Default.Save();
        }

        public void SplashStart()
        {
            InitializationData.Initializer = new InitializationViewFRM();
            InitializationData.Initializer.ShowDialog();
        }

        private void NewRepoBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon;
        }

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            if (Helpers.Is_Git_Repo(@"Z:\Engineering\Source Code\Firmware Files"))
            {
                MessageBox.Show("This is a repo");
            }

            else
            {
                MessageBox.Show("This is not a repo");
            }
        }

        private void Populate_List()
        {

        }

        private void MainViewFRM_Load(object sender, EventArgs e)
        {
            RepoProps repo = new RepoProps();

            RepoPG.SelectedObject = repo;
        }

        private void SettingsBT_Click(object sender, EventArgs e)
        {
            SettingsViewFRM settings = new SettingsViewFRM();
            settings.ShowDialog();
        }

        private void SettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon_Hover;
        }

        private void SettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon;
        }

        private void RootLocationCB_Initialize()
        {
            RootLocationCB.Items.Clear();

            foreach (KeyValuePair<string, RootCell> kvp in ManagerData.Roots)
            {
                RootLocationCB.Items.Add(kvp.Key);
            }

            RootLocationCB.SelectedIndex = 0;
            RootLocationCB.Refresh();
        }

        private void RootLocationCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(RootLocationCB.SelectedItem.ToString());

            ReposLV_Initialize();
        }

        private void ReposLV_Initialize()
        {
            ReposLV.Items.Clear();

            foreach (string repo in ManagerData.Roots[RootLocationCB.SelectedItem.ToString()]._Repos)
            {
                DirectoryInfo repoInfo = new DirectoryInfo(repo);

                ReposLV.Items.Add(repoInfo.Name);
            }
        }
    }
}
