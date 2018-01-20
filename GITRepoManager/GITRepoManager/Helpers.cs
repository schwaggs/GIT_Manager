using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class Helpers
    {
        public static string Exception_Message { get; set; }
        private static bool Is_Repo { get; set; }






        #region Is GIT Repo

        public static bool Is_Git_Repo(string dir)
        {
            Is_Repo = true;

            Process cmd = Create_Process(dir, "git log");

            if (cmd != null)
            {
                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.WaitForExit();

                if (Is_Repo)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion


        #region Create Process

        /*
         *   ________________________________________________________________________________
         *   # Method:              #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   # Parameters:          #   
         *   #                                                                              #
         *   # Returns:             #
         *   #                                                                              #
         *   # Last Date Modified:  #
         *   #                                                                              #
         *   # Last Modified By:    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

        public static Process Create_Process(string dir, string arguments)
        {
            DirectoryInfo dirInfo = null;

            try
            {
                dirInfo = new DirectoryInfo(dir);
            }

            catch
            {
                return null;
            }

            Process cmdProc = new Process();
            ProcessStartInfo cmdInfo = new ProcessStartInfo();

            if (dirInfo != null || !dirInfo.Exists)
            {
                Exception_Message = "DNE";
                return null;
            }

            cmdInfo.FileName = "cmd.exe";
            cmdInfo.Arguments = "/c " + arguments;
            cmdInfo.WorkingDirectory = dirInfo.FullName;
            cmdInfo.RedirectStandardInput = true;
            cmdInfo.RedirectStandardOutput = true;
            cmdInfo.RedirectStandardError = true;
            cmdInfo.UseShellExecute = false;
            cmdInfo.CreateNoWindow = true;

            try
            {
                cmdProc.StartInfo = cmdInfo;
                cmdProc.EnableRaisingEvents = true;
                cmdProc.OutputDataReceived += CmdProc_OutputDataReceived;
                cmdProc.ErrorDataReceived += CmdProc_ErrorDataReceived;

                return cmdProc;
            }

            catch (Exception ex)
            {
                Exception_Message = ex.Message;
                return null;
            }
        }

        private static void CmdProc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data) || !string.IsNullOrWhiteSpace(e.Data))
            {
                Is_Repo = false;
            }
        }

        private static void CmdProc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            
        }

        #endregion


        #region Clone Repository

        public static bool Clone(string Destination)
        {
            try
            {
                Process Cloner = Create_Process(Destination, string.Format(Properties.Resources.REPO_CLONE, ManagerData.Selected_Repo.Path));

                if (Cloner != null)
                {
                    Cloner.Start();
                    Cloner.WaitForExit();
                }

                else
                {
                    return false;
                }
            }

            catch
            {
                MessageBox.Show("Unsuccessful at cloning repository", "Cloning Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("Repository cloned successfully", "Clone Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        #endregion


        #region Last Commit

        public static DateTime Get_Last_Commit()
        {
            return DateTime.MinValue;
        }

        #endregion


        #region Last Commit Message

        public static string Get_Last_Commit_Message()
        {
            return string.Empty;
        }

        #endregion


        #region Log Parser

        public static List<EntryCell> Parse_Logs(string Full_Log)
        {
            // Get a list of matches that match the log format
            // There will probably be two sets, one for the ID and one for the message
            // Each should align with the other in seperate lists i.e. index 0 in the id list aligns with index 0 in the message list

            string currID = "";
            string currAuthor = "";
            string currDate = "";
            string currMessage = "";

            Regex rgx = new Regex(Properties.Resources.REGEX_LOG_PATTERN, RegexOptions.IgnoreCase);

            List<EntryCell> Entries = new List<EntryCell>();
            Entries.Clear();

            foreach (Match commit in rgx.Matches(Full_Log))
            {
                currID = commit.Groups[1].ToString();
                currAuthor = commit.Groups[2].ToString();
                currDate = commit.Groups[3].ToString();
                currMessage = commit.Groups[4].ToString();

                EntryCell entry = new EntryCell
                {
                    ID = currID,
                    Author = currAuthor,
                    Message = currMessage
                };

                DateTime temp = DateTime.MinValue;
                DateTime.TryParse(currDate, out temp);

                entry.Date = temp;
                Entries.Add(entry);
            }

            return Entries;
        }

        public static string Stores_To_String()
        {
            string message = string.Empty;

            if (ManagerData.Stores != null)
            {
                foreach (KeyValuePair<string, StoreCell> kvp in ManagerData.Stores)
                {
                    message += kvp.Key + Environment.NewLine + Environment.NewLine;

                    StoreCell Store = kvp.Value;

                    foreach (KeyValuePair<string, RepoCell> repokvp in Store._Repos)
                    {
                        message += repokvp.Key + Environment.NewLine;
                        message += RepoCell.Status.ToString(repokvp.Value.Current_Status) + Environment.NewLine;
                        message += repokvp.Value.Last_Commit.ToString() + Environment.NewLine;
                        message += repokvp.Value.Last_Commit_Message + Environment.NewLine + Environment.NewLine;

                        foreach (KeyValuePair<string, string> notekvp in repokvp.Value.Notes)
                        {
                            message += notekvp.Key + Environment.NewLine;
                            message += notekvp.Value + Environment.NewLine + Environment.NewLine;
                        }

                        message += Environment.NewLine;

                        foreach (KeyValuePair<string, List<EntryCell>> logkvp in repokvp.Value.Logs)
                        {
                            message += logkvp.Key + Environment.NewLine;

                            foreach (EntryCell entry in logkvp.Value)
                            {
                                message += entry.ID + Environment.NewLine;
                                message += entry.Date + Environment.NewLine;
                                message += entry.Author + Environment.NewLine;
                                message += entry.Message + Environment.NewLine + Environment.NewLine;
                            }
                        }

                        message += Environment.NewLine;
                    }

                    message += Environment.NewLine;
                }

                message += Environment.NewLine + Environment.NewLine;

                return message;
            }

            else
            {
                return string.Empty;
            }
        }

        #endregion
    }
}
