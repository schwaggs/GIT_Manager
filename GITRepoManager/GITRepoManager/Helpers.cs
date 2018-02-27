using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class RepoHelpers
    {
        public static string Exception_Message { get; set; }
        private static bool Is_Repo { get; set; }






        #region Is GIT Repo

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

        public static bool Is_Git_Repo(string dir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            if (dirInfo.Exists)
            {
                Is_Repo = true;
                Process cmd = Create_Process(dir, "git log");

                StringBuilder error = new StringBuilder();
                StringBuilder output = new StringBuilder();

                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                {
                    cmd.OutputDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            try
                            {
                                outputWaitHandle.Set();
                            }

                            catch
                            {
                            }
                        }

                        else
                        {
                            output.AppendLine(e.Data);
                        }
                    };

                    cmd.ErrorDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            try
                            {
                                errorWaitHandle.Set();
                            }

                            catch
                            {
                            }
                        }

                        else
                        {
                            error.AppendLine(e.Data);
                        }
                    };

                    cmd.Start();

                    cmd.BeginOutputReadLine();
                    cmd.BeginErrorReadLine();

                    if (cmd.WaitForExit(1000) && outputWaitHandle.WaitOne(1000) && errorWaitHandle.WaitOne(1000))
                    {
                        // Process completed, check cmd.ExitCode
                        if (cmd.ExitCode == 0)
                        {
                            if (string.IsNullOrEmpty(error.ToString()) || string.IsNullOrWhiteSpace(error.ToString()))
                            {
                                return true;
                            }

                            else
                            {
                                return false;
                            }
                        }

                        else
                        {
                            // Process exited with error
                            //MessageBox.Show("Unable verify if current directory is a repository", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    else
                    {
                        // Timed out
                        //MessageBox.Show("Checking if current directory is a repository has timed out.", "Timed Out", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }

            else
            {
                //Not a valid directory to check
                return false;
            }
        }

        private static void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
        }

        private static void Cmd_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
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

            if (dirInfo == null || !dirInfo.Exists)
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

        public static bool Clone(string Destination)
        {
            try
            {
                Process Cloner = Create_Process(Destination, string.Format(Properties.Resources.REPO_CLONE, "\"" + ManagerData.Selected_Repo.Path + "\""));

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

        public static DateTime Get_Last_Commit()
        {
            return DateTime.MinValue;
        }

        #endregion


        #region Last Commit Message

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

        public static string Get_Last_Commit_Message()
        {
            return string.Empty;
        }

        #endregion


        #region Log Parser

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


        #region Save Configuration

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

        public static bool Save_Config(List<string> paths)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ConfigPath) || !string.IsNullOrWhiteSpace(Properties.Settings.Default.ConfigPath))
            {
                // Make a copy of the file with .bak ext

                // Add store cells for all stringsin paths to managerdata.stores dictionary

                // call Serialize_Replace(Properties.Settings.Default.ConfigPath, ManagerData.Stores)
            }

            return false;
        }



        #endregion

        public static List<RepoCell> Get_Repositories(string dir)
        {
            List<RepoCell> Repos = new List<RepoCell>();

            foreach (string subdir in Directory.GetDirectories(dir))
            {
                DirectoryInfo subdirInfo = new DirectoryInfo(subdir);

                if (subdirInfo.Exists && Is_Git_Repo(subdirInfo.FullName))
                {
                    RepoCell newRepo = new RepoCell()
                    {
                        Name = subdirInfo.Name,
                        Path = subdirInfo.FullName,
                        Current_Status = RepoCell.Status.Type.NONE,
                        Last_Commit = DateTime.MinValue,
                        Last_Commit_Message = string.Empty,
                        Logs = new Dictionary<string, List<EntryCell>>(),
                        Notes = new Dictionary<string, string>()
                    };

                    Repos.Add(newRepo);
                }
            }

            return Repos;
        }
    }
}
