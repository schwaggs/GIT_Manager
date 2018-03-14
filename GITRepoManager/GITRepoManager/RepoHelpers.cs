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
        public static string Redirected_Output { get; set; }
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

                return cmdProc;
            }

            catch (Exception ex)
            {
                Exception_Message = ex.Message;
                return null;
            }
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

            Regex rgx = new Regex(Properties.Resources.REGEX_LOG_PATTERN, RegexOptions.IgnoreCase | RegexOptions.Multiline);

            List<EntryCell> Entries = new List<EntryCell>();
            var matches = rgx.Matches(Full_Log);
            foreach (Match commit in matches)
            {
                currID = commit.Groups[1].Value;
                currAuthor = commit.Groups[2].Value;
                currDate = commit.Groups[3].Value;
                currMessage = commit.Groups[4].Value;

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

        #endregion


        #region Stores_To_String

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


        #region Detect Changes

        public static bool Detect_Changes()
        {
            #region Initialization

            Dictionary<string, List<string>> currRepos = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> currRepos_Deletions = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> currRepos_Additions = new Dictionary<string, List<string>>();

            bool changes = false;
            

            foreach (StoreCell store in ManagerData.Stores.Values)
            {
                foreach (RepoCell repo in store._Repos.Values)
                {
                    if (currRepos.Keys.Contains(store._Path))
                    {
                        if (currRepos[store._Path] == null)
                        {
                            currRepos[store._Path] = new List<string>();
                            currRepos[store._Path].Add(repo.Path);
                        }

                        else
                        {
                            currRepos[store._Path].Add(repo.Path);
                        }
                    }

                    else
                    {
                        currRepos.Add(store._Path, new List<string>());
                        currRepos[store._Path].Add(repo.Path);
                    }
                }
            }

            #endregion Initialization


            #region Find Changes

            currRepos_Additions = Detect_Additions(currRepos);
            currRepos_Deletions = Detect_Deletions(currRepos);

            if (currRepos_Additions.Count > 0 || currRepos_Deletions.Count > 0)
            {
                changes = true;
            }

            #endregion Find Changes


            #region Apply Changes

            if (changes)
            {
                string response = string.Empty;

                if (currRepos_Additions.Count > 0)
                {
                    response = Add_Repos(currRepos_Additions);

                    if (response != string.Empty)
                    {
                        MessageBox.Show(response, "Error Adding Repo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (currRepos_Deletions.Count > 0)
                {
                    response = Remove_Repos(currRepos_Deletions);

                    if (response != string.Empty)
                    {
                        MessageBox.Show(response, "Error Removing Repo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            #endregion Apply Changes


            #region Return

            return changes;

            #endregion Return
        }

        #region Get_Store_Count

        public static int Get_Store_Count(List<string> stores, ref List<string> validStores)
        {
            int count = stores.Count;
            foreach (string path in stores)
            {
                if (!Directory.Exists(path))
                {
                    count--;
                }
            }

            return count;
        }

        #endregion Get_Store_Count


        #region Get_Repo_Count

        public static int Get_Repo_Count(Dictionary<string, List<string>> stores)
        {
            int count = 0;

            foreach (List<string> repos in stores.Values)
            {
                count += repos.Count;
            }

            return count;
        }

        #endregion Get_Repo_Count


        #region Detect_Additions

        public static Dictionary<string, List<string>> Detect_Additions(Dictionary<string, List<string>> currList)
        {
            Dictionary<string, List<string>> additions = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<string, List<string>> kvp in currList)
            {
                // Outer = dir inner = repo => Addition

                foreach (string path in Directory.GetDirectories(kvp.Key))
                {
                    bool contains = false;

                    foreach (string currRepo in kvp.Value)
                    {
                        if (path == currRepo)
                        {
                            contains = true;
                            break;
                        }
                    }

                    if (!contains)
                    {
                        if (Is_Git_Repo(path))
                        {
                            if (additions.Keys.Contains(kvp.Key))
                            {
                                additions[kvp.Key].Add(path);
                            }

                            else
                            {
                                additions.Add(kvp.Key, new List<string>());
                                additions[kvp.Key].Add(path);
                            }
                        }
                    }
                }
            }

            return additions;
        }

        #endregion Detect_Additions


        #region Detect_Deletions

        public static Dictionary<string, List<string>> Detect_Deletions(Dictionary<string, List<string>> currList)
        {
            Dictionary<string, List<string>> deletions = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<string, List<string>> kvp in currList)
            {
                // Outer = repo inner = dir => Deletion
                foreach (string repoPath in kvp.Value)
                {
                    bool contains = false;

                    foreach (string path in Directory.GetDirectories(kvp.Key))
                    {
                        if (repoPath == path)
                        {
                            contains = true;
                            break;
                        }
                    }

                    if (!contains)
                    {
                        if (deletions.Keys.Contains(kvp.Key))
                        {
                            deletions[kvp.Key].Add(repoPath);
                        }

                        else
                        {
                            deletions.Add(kvp.Key, new List<string>());
                            deletions[kvp.Key].Add(repoPath);
                        }
                    }
                }
            }

            return deletions;
        }

        #endregion Detect_Deletions


        #region Add_Repos

        public static string Add_Repos(Dictionary<string, List<string>> additions)
        {
            string response = string.Empty;

            foreach (KeyValuePair<string, List<string>> kvp in additions)
            {
                DirectoryInfo storeInfo = new DirectoryInfo(kvp.Key);

                foreach (string path in kvp.Value)
                {
                    DirectoryInfo repoInfo = new DirectoryInfo(path);

                    RepoCell repo = new RepoCell()
                    {
                        Name = repoInfo.Name,
                        Path = repoInfo.FullName,
                        Current_Status = RepoCell.Status.Type.NONE,
                        Last_Commit = DateTime.MinValue,
                        Last_Commit_Message = string.Empty,
                        Notes = new Dictionary<string, string>(),
                        Logs = new Dictionary<string, List<EntryCell>>()
                    };

                    try
                    {
                        ManagerData.Stores[storeInfo.Name]._Repos.Add(repoInfo.Name, repo);
                    }

                    catch (Exception ex)
                    {
                        response += ex.Message + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return response;
        }

        #endregion Add_Repos


        #region Remove_Repos

        public static string Remove_Repos(Dictionary<string, List<string>> deletions)
        {
            string response = string.Empty;

            foreach (KeyValuePair<string, List<string>> kvp in deletions)
            {
                DirectoryInfo storeInfo = new DirectoryInfo(kvp.Key);

                foreach (string path in kvp.Value)
                {
                    DirectoryInfo repoInfo = new DirectoryInfo(path);

                    try
                    {
                        ManagerData.Stores[storeInfo.Name]._Repos.Remove(repoInfo.Name);
                    }

                    catch(Exception ex)
                    {
                        response += ex.Message + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return response;
        }

        #endregion Remove_Repos

        #endregion
    }
}
