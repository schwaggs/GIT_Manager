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

namespace GITRepoManager
{
    public partial class InitializationViewFRM : Form
    {
        public DialogResult Result { get; set; }

        

        public InitializationViewFRM()
        {
            InitializeComponent();
        }

        private void InitializationViewFRM_Load(object sender, EventArgs e)
        {
            VerifyConfigCheckPB.Image = Properties.Resources.ConfigCheck_Default;
            ReadConfigPB.Image = Properties.Resources.ConfigCheck_Default;
            ChangesPB.Image = Properties.Resources.ConfigCheck_Default;

            bool retry = true;

            while (retry)
            {
                retry = false;

                if (Config_Is_Empty_Path())
                {
                    if (!CreateConfig_Empty_Path(false))
                    {
                        if (!CreateConfig_Empty_Path(true))
                        {
                            MessageBox.Show("A configuration file is required, closing GIT Manager.", "Empty Configuration File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.ExitThread();
                            Application.Exit();
                            Environment.Exit(0);
                        }
                    }

                    retry = true;
                }

                if (!Config_Exists(Properties.Settings.Default.ConfigPath))
                {
                    if (!CreateConfig_File_DNE(false))
                    {
                        if (!CreateConfig_File_DNE(true))
                        {
                            MessageBox.Show("A configuration file is required, closing GIT Manager.", "Configuration File Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.ExitThread();
                            Application.Exit();
                            Environment.Exit(0);
                        }
                    }

                    retry = true;
                }

                else if (!Config_Is_Valid_XML(Properties.Settings.Default.ConfigPath))
                {
                    // Config is not a valid xml file, ask for a new one
                    if (!CreateConfig_Invalid_XML(false))
                    {
                        if (!CreateConfig_Invalid_XML(true))
                        {
                            MessageBox.Show("A configuration file is required, closing GIT Manager.", "Invalid Configuration File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.ExitThread();
                            Application.Exit();
                            Environment.Exit(0);
                        }
                    }

                    retry = true;
                }

                retry = false;
            }

            VerifyConfigCheckPB.BackgroundImage = Properties.Resources.ConfigCheck_Complete;

            Configuration.Helpers.Deserialize_Condensed(Properties.Settings.Default.ConfigPath);

            ReadConfigPB.BackgroundImage = Properties.Resources.ConfigCheck_Complete;

            if (RepoHelpers.Detect_Changes())
            {
                Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);

                ChangesPB.BackgroundImage = Properties.Resources.ConfigCheck_Complete;
            }

            InitializationData.Initialized = true;
        }

        private bool CreateConfig_Invalid_XML(bool required)
        {
            string message = string.Empty;
            string title = "Invalid Configuration File";
            MessageBoxButtons buttons;
            MessageBoxIcon icon;


            if (required)
            {
                message = "A valid configuration is required.";
                buttons = MessageBoxButtons.RetryCancel;
                icon = MessageBoxIcon.Exclamation;
            }

            else
            {
                message = "Configuration file is invalid, fix now?";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Question;
            }

            Result = MessageBox.Show(message, title, buttons, icon);

            if (Result == DialogResult.Yes || Result == DialogResult.Retry)
            {
                string filter = "Config Files|*.txt;*.gmc;*.xml;*.conf";

                SaveFileDialog FileDialog = new SaveFileDialog
                {
                    Title = "Select or Create Configuration File",
                    CheckFileExists = true,
                    SupportMultiDottedExtensions = true,
                    CreatePrompt = false,
                    OverwritePrompt = false,
                    Filter = filter,
                    DefaultExt = "gmc"
                };

                FileDialog.CheckFileExists = false;
                FileDialog.CheckPathExists = false;

                Thread GetFile = new Thread(() =>
                {
                    if (FileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfigPath = FileDialog.FileName;
                        Properties.Settings.Default.Save();
                    }
                });

                GetFile.SetApartmentState(ApartmentState.STA);
                GetFile.Start();
                GetFile.Join();
            }

            else
            {
                
                return false;
            }

            return true;
        }






        private bool CreateConfig_File_DNE(bool required)
        {
            string message = string.Empty;
            string title = "Configuration File Not Found";
            MessageBoxButtons buttons;
            MessageBoxIcon icon;


            if (required)
            {
                message = "A configuration file is required, fix now?";
                buttons = MessageBoxButtons.RetryCancel;
                icon = MessageBoxIcon.Exclamation;
            }

            else
            {
                message = "Configuration file was not found, setup now?";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Question;
            }

            Result = MessageBox.Show(message, title, buttons, icon);

            if (Result == DialogResult.Yes || Result == DialogResult.Retry)
            {
                string filter = "Config Files|*.txt;*.gmc;*.xml;*.conf";

                SaveFileDialog FileDialog = new SaveFileDialog
                {
                    Title = "Select or Create Configuration File",
                    CheckFileExists = true,
                    SupportMultiDottedExtensions = true,
                    CreatePrompt = false,
                    OverwritePrompt = false,
                    Filter = filter,
                    DefaultExt = "gmc"
                };

                FileDialog.CheckFileExists = false;
                FileDialog.CheckPathExists = false;

                Thread GetFile = new Thread(() =>
                {
                    if (FileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfigPath = FileDialog.FileName;
                        Properties.Settings.Default.Save();
                    }
                });

                GetFile.SetApartmentState(ApartmentState.STA);
                GetFile.Start();
                GetFile.Join();
            }

            else
            {
                // Not a valid path
                return false;
            }

            if (!File.Exists(Properties.Settings.Default.ConfigPath))
            {
                Create_Blank_Config(Properties.Settings.Default.ConfigPath);
            }

            return true;
        }






        private bool CreateConfig_Empty_Path(bool required)
        {
            string message = string.Empty;
            string title = "Configuration File";
            MessageBoxButtons buttons;
            MessageBoxIcon icon;


            if (required)
            {
                message = "A configuration file is required.";
                buttons = MessageBoxButtons.RetryCancel;
                icon = MessageBoxIcon.Exclamation;
            }

            else
            {
                message = "Configuration file path is empty, setup now?";
                buttons = MessageBoxButtons.YesNo;
                icon = MessageBoxIcon.Question;
            }

            Result = MessageBox.Show(message, title, buttons, icon);

            if (Result == DialogResult.Yes || Result == DialogResult.Retry)
            {
                string filter = "Config Files|*.txt;*.gmc;*.xml;*.conf";

                SaveFileDialog FileDialog = new SaveFileDialog
                {
                    Title = "Select or Create Configuration File",
                    CheckFileExists = true,
                    SupportMultiDottedExtensions = true,
                    CreatePrompt = false,
                    OverwritePrompt = false,
                    Filter = filter,
                    DefaultExt = "gmc"
                };

                FileDialog.CheckFileExists = false;
                FileDialog.CheckPathExists = false;

                Thread GetFile = new Thread(() =>
                {
                    if (FileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.ConfigPath = FileDialog.FileName;
                        Properties.Settings.Default.Save();
                    }
                });

                GetFile.SetApartmentState(ApartmentState.STA);
                GetFile.Start();
                GetFile.Join();

                return true;
            }

            else
            {
                return false;
            }
        }






        private bool Create_Blank_Config(string filename)
        {
            bool GetFileResult = true;

            Thread GetFile = new Thread(() =>
            {
                FileInfo fileInfo = new FileInfo(filename);
                try
                {
                    XmlDocument doc = new XmlDocument();
                    XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    doc.AppendChild(docNode);

                    XmlNode root = doc.CreateElement("root");
                    doc.AppendChild(root);
                    doc.Save(fileInfo.FullName);

                    GetFileResult = true;
                }

                catch (Exception ex)
                {
                    GetFileResult = false;
                }
            });

            GetFile.SetApartmentState(ApartmentState.STA);
            GetFile.Start();
            GetFile.Join();
            return GetFileResult;
        }





        private bool Config_Is_Empty_Path()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.ConfigPath) || string.IsNullOrWhiteSpace(Properties.Settings.Default.ConfigPath))
            {
                return true;
            }

            else
            {
                return false;
            }
        }






        private bool Config_Is_Valid_XML(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                return true;
            }

            catch (XmlException ex)
            {
                return false;
            }
        }






        private bool Config_Exists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            else
            {
                return false;
            }
        }






        private bool IsFileReady(string path)
        {
            try
            {
                using (FileStream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (inputStream.Length > 0)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        




        private void InitializationViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InitializationData.Initialized)
            {
                ProgressBarIncrT.Stop();
            }

            if (this.DialogResult == DialogResult.Cancel)
            {
                Application.ExitThread();
                Application.Exit();
                Environment.Exit(0);
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
