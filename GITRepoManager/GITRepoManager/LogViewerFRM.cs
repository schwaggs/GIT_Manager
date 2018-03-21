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
    public partial class LogViewerFRM : Form
    {
        private static Dictionary<string, string> Logs { get; set; }
        private static List<EntryCell> Found_Logs { get; set; }
        private static string Raw_Log { get; set; }
        private static string Repo_Path { get; set; }

        public LogViewerFRM(string _Repo_Path)
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
            CopiedMessageLB.Text = string.Empty;
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
                Logs = new Dictionary<string, string>();

                foreach (KeyValuePair<string, List<EntryCell>> kvp in ManagerData.Selected_Repo.Logs)
                {
                    foreach (EntryCell entry in kvp.Value)
                    {
                        string contents = string.Empty;
                        string s1 = @"{\rtf1\ansi\b ID: \b0 " + entry.ID + @" \line\line";
                        string s2 = @"\b Author: \b0 " + entry.Author + @" \line\line";
                        string s3 = @"\b Date: \b0 " + entry.Date.ToString("d") + @" \line\line ";
                        string s4 = entry.Message + @"}";
                        contents = s1 + s2 + s3 + s4;

                        Logs.Add(entry.ID.Substring(0, 8), contents);
                        ListViewItem.ListViewSubItem commitDate = new ListViewItem.ListViewSubItem()
                        {
                            Name = entry.Date.ToString("d"),
                            Text = entry.Date.ToString("d")
                        };

                        ListViewItem commitID = new ListViewItem()
                        {
                            Name = entry.ID.Substring(0, 8),
                            Text = entry.ID.Substring(0, 8)
                        };
                        
                        LogNamesLV.Items.Add(commitID);
                        LogNamesLV.Items[commitID.Name].SubItems.Add(commitDate);
                    }
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
                try
                {
                    CommitNumberLB.Text = LogNamesLV.SelectedItems[0].Name;
                    LogContentsTB.Rtf = Logs[LogNamesLV.SelectedItems[0].Name];
                }
                catch
                {
                }
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
            CopiedMessageLB.Text = string.Empty;
            Populate_Log_Details();
        }

        private void LogNamesLV_Click(object sender, EventArgs e)
        {
            if (LogNamesLV.SelectedItems.Count > 0)
            {
                Populate_Log_Details();
            }
        }

        private void CommitNumberLB_Click(object sender, EventArgs e)
        {
            CopiedMessageLB.Text = string.Empty;
            Clipboard.SetText(CommitNumberLB.Text);
            CopiedMessageLB.Text = "Copied to the clipboard!";
            //MessageBox.Show("Commit ID " + LogNamesLV.SelectedItems[0].SubItems[1].Name + " copied to the clipboard!", "ID Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogContentsTB_Click(object sender, EventArgs e)
        {
            CopiedMessageLB.Text = string.Empty;
        }

        private void LogNamesLV_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LogNamesLV_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
