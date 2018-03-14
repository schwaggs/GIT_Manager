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

namespace GITRepoManager
{
    public partial class LogViewer : Form
    {
        private static Dictionary<string, string> Logs { get; set; }
        private static List<EntryCell> Found_Logs { get; set; }
        private static string Raw_Log { get; set; }
        private static string Repo_Path { get; set; }

        public LogViewer(string _Repo_Path)
        {
            InitializeComponent();

            Repo_Path = _Repo_Path;
        }

        #region Events

        #region Form

        #region Load

        private void LogViewer_Load(object sender, EventArgs e)
        {
            Populate_Logs();
        }

        #endregion

        #endregion Form


        #region List View

        #region Selection Changed



        #endregion Selection Changed

        #endregion List View


        #region Mouse

        #region Click

        #region RawLogBT

        private void RawLogBT_Click(object sender, EventArgs e)
        {
            CommitNumberLB.Text = "Raw Log Output";
            LogContentsTB.Text = Raw_Log;
        }

        #endregion

        #endregion Click


        #region Enter

        #region RawLogBT

        private void RawLogBT_MouseEnter(object sender, EventArgs e)
        {
            RawLogBT.BackgroundImage = Properties.Resources.Select_All_Icon_Hover;
        }

        #endregion

        #endregion Enter


        #region Leave

        #region RawLogBT

        private void RawLogBT_MouseLeave(object sender, EventArgs e)
        {
            RawLogBT.BackgroundImage = Properties.Resources.Select_All_Icon;
        }

        #endregion

        #endregion Leave

        #endregion Mouse

        #endregion Events


        #region Methods

        #region Populate_Logs

        private void Populate_Logs()
        {
            if (!string.IsNullOrEmpty(Repo_Path) && !string.IsNullOrWhiteSpace(Repo_Path))
            {
                RepoHelpers.Redirected_Output = string.Empty;
                Process LogP = RepoHelpers.Create_Process(Repo_Path, " git --no-pager log");
                LogP.Start();
                Raw_Log = LogP.StandardOutput.ReadToEnd();
                LogP.StandardInput.WriteLine("exit");
                LogP.WaitForExit();

                RawLogBT.Visible = true;

                Found_Logs = RepoHelpers.Parse_Logs(Raw_Log);
                Logs = new Dictionary<string, string>();

                foreach (EntryCell entry in Found_Logs)
                {
                    string contents = string.Empty;

                    contents = ("Author: " + entry.Author) + Environment.NewLine
                            + ("Date: " + entry.Date.ToString("d")) + Environment.NewLine + Environment.NewLine
                            + entry.Message;

                    Logs.Add(entry.ID, contents);

                    ListViewItem newLog = new ListViewItem()
                    {
                        Name = entry.ID,
                        Text = entry.ID
                    };

                    LogNamesLV.Items.Add(newLog);
                }

                if (LogNamesLV.Items.Count > 0)
                {
                    LogNamesLV.Items[0].Selected = true;
                    LogNamesLV.Select();
                }
            }
        }

        #endregion

        #region Populate_Log_Details

        private void Populate_Log_Details()
        {
            if (LogNamesLV.SelectedItems.Count > 0)
            {
                CommitNumberLB.Text = LogNamesLV.SelectedItems[0].Name;
                LogContentsTB.Text = Logs[LogNamesLV.SelectedItems[0].Name];
            }

            else
            {
                CommitNumberLB.Text = string.Empty;
                LogContentsTB.Clear();
            }
        }

        #endregion

        #endregion Methods

        private void LogNamesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Populate_Log_Details();
        }

        private void LogNamesLV_Click(object sender, EventArgs e)
        {
            if (LogNamesLV.SelectedItems.Count > 0)
            {
                Populate_Log_Details();
            }
        }
    }
}
