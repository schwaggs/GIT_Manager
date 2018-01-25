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

namespace GITRepoManager
{
    public partial class InitializationViewFRM : Form
    {
        public DialogResult GetFileResult { get; set; }
        public InitializationViewFRM()
        {
            InitializeComponent();
            ProgressCPB.Value = 0;
        }

        private void InitializationViewFRM_Load(object sender, EventArgs e)
        {
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

                Thread GetFile = new Thread(() =>
                {
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
                                DialogResult create;
                                create = MessageBox.Show("File doesnt exist, create?", "File Does Not Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                                if (create == DialogResult.Yes)
                                {
                                    try
                                    {
                                        fileInfo.Create();
                                        retry = false;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Unable to create file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
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
                });

                GetFile.TrySetApartmentState(ApartmentState.STA);
                GetFile.Start();

                GetFile.Join();
            }

            Configuration.Helpers.Deserialize(Properties.Settings.Default.ConfigPath);
            string result = Helpers.Stores_To_String();
            bool cont = true;

            cont = InitializationData.Initialize();

            if (cont)
            {
                //cont = InitializationData.Initialize_Roots(null);

                if (cont)
                {
                    InitializationData.Initialized = true;
                }

                else
                {
                    InitializationData.Initialized = false;
                    InitializationData.Abort = true;
                }
            }

            else
            {
                InitializationData.Initialized = false;
                InitializationData.Abort = true;
            }
        }

        private void ProgressBarIncrT_Tick(object sender, EventArgs e)
        {
            if (ProgressCPB.Value + InitializationData.Progress_Inc < 100)
            {
                ProgressCPB.Value += InitializationData.Progress_Inc;
            }

            else
            {
                ProgressCPB.Value = 100;
            }

            if (ProgressCPB.Value == ProgressCPB.Maximum)
            {
                ProgressBarIncrT.Stop();
                InitializationData.Initialized = true;
            }
        }

        

        private void InitializationViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InitializationData.Initialized)
            {
                ProgressBarIncrT.Stop();
            }
        }

        private void ReposBGW_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ReposBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void ReposBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void RootsBGW_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RootsBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void RootsBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
