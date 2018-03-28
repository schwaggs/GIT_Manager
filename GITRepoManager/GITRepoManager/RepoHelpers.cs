using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        #region Class Data

        public static string Exception_Message { get; set; }
        public static string Redirected_Output { get; set; }
        private static bool Is_Repo { get; set; }

        #endregion Class Data


        #region Class Methods

        #region Is_Git_Repo

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
                            return false;
                        }
                    }

                    else
                    {
                        // Timed out
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

        #endregion Is_Git_Repo


        #region Create_Process

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

        #endregion Create_Process


        #region Clone_Repo

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

        public static bool Clone_Repo(string Destination, bool Use_Selected_Repo, string source = "")
        {
            try
            {
                Process Cloner = null;

                if (Use_Selected_Repo)
                {
                    Cloner = Create_Process(Destination, string.Format(Properties.Resources.REPO_CLONE, "\"" + ManagerData.Selected_Repo.Path + "\""));
                }

                else
                {
                    Cloner = Create_Process(Destination, string.Format(Properties.Resources.REPO_CLONE, "\"" + source + "\""));
                }

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
                //MessageBox.Show("Unsuccessful at cloning repository", "Cloning Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //MessageBox.Show("Repository cloned successfully", "Clone Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        #endregion Clone_Repo


        #region Get_Last_Commit

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
            if (ManagerData.Selected_Repo != null)
            {
                EntryCell commit = ManagerData.Selected_Repo.Logs.Values.First().First();

                return commit.Date;
            }

            else
            {
                return DateTime.MinValue;
            }
        }

        #endregion Get_Last_Commit


        #region Get_Last_Commit_Message

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
            if (ManagerData.Selected_Repo != null)
            {
                EntryCell commit = ManagerData.Selected_Repo.Logs.Values.First().First();

                return commit.Message;
            }

            else
            {
                return string.Empty;
            }
        }

        #endregion Get_Last_Commit_Message


        #region Parse_Logs

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

        public static List<EntryCell> Parse_Logs(string Full_Log, RepoCell currRepo = null)
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

            bool first = true;

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

                currDate = currDate.Trim();

                temp = DateTime.ParseExact(currDate, "ddd MMM d HH:mm:ss yyyy zz00", null); 

                entry.Date = temp;
                Entries.Add(entry);

                string shortID = currID.Substring(0, 8);

                if (first)
                {
                    first = false;

                    if (currRepo.Last_Commit == DateTime.MinValue && currRepo.Last_Commit != null || Properties.Settings.Default.LogParseMethod == 1)
                    {
                        currRepo.Last_Commit = entry.Date;
                    }

                    if (currRepo.Last_Commit_Message == string.Empty || currRepo.Last_Commit_Message == null || Properties.Settings.Default.LogParseMethod == 1)
                    {
                        currRepo.Last_Commit_Message = entry.Message;
                    }
                }

                if (currRepo != null)
                {
                    if (currRepo.Logs != null)
                    {
                        if (currRepo.Logs.Keys.Contains(currID.Substring(0, 8)))
                        {
                            currRepo.Logs[shortID].Add(entry);
                        }

                        else
                        {
                            currRepo.Logs.Add(shortID, new List<EntryCell>());
                            currRepo.Logs[shortID].Add(entry);
                        }
                    }

                    else
                    {
                        currRepo.Logs = new Dictionary<string, List<EntryCell>>();
                        currRepo.Logs.Add(shortID, new List<EntryCell>());
                        currRepo.Logs[shortID].Add(entry);
                    }
                }
            }

            return Entries;
        }

        #endregion Parse_Logs


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


        #region Detect_Changes

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

                try
                {
                    foreach (string path in Directory.GetDirectories(kvp.Key, "*", SearchOption.TopDirectoryOnly))
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

                catch (Exception ex)
                {
                    
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

                    try
                    {
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

                    catch (Exception ex)
                    {
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

        #endregion Detect_Changes


        #region Create_Blank_Repository

        public static bool Create_Blank_Repository(string source, string name)
        {
            string Full_Path = source + @"\" + name + ".git";

            if (!Directory.GetDirectories(source).Contains(name))
            {
                DirectoryInfo fullInfo = new DirectoryInfo(Full_Path);
                fullInfo.Create();

                // Any output and error from the processes used during this operation
                List<string> temp = Initialize_Blank_Repository(fullInfo.FullName);

                if (temp == null)
                {
                    if (Is_Git_Repo(fullInfo.FullName))
                    {
                        return true;
                    }

                    else
                    {
                        try
                        {
                            fullInfo.Delete();
                        }

                        catch
                        {
                        }

                        return false;
                    }
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        #region Initialize_Blank_Repository

        public static List<string> Initialize_Blank_Repository(string path)
        {
            DirectoryInfo pathInfo = new DirectoryInfo(path);
            List<string> response = new List<string>();

            // First we need to do an init --bare inside the repo
            try
            {
                Process Init = Create_Process(path, Properties.Resources.REPO_BLANK);

                if (Init != null)
                {
                    response = Process_Output(Init, "Init");

                    if (!(response[1] == "Init Error:\n\n"))
                    {
                        return response;
                    }
                }

                else
                {
                    response.Add("Init Process Error");
                    return response;
                }
            }

            catch(Exception ex)
            {
                response.Add("Init Exception:\n\n" + ex.Message);
                return response;
            }

            string localPath = Properties.Settings.Default.CloneLocalSourcePath + @"\" + pathInfo.Name.Substring(0, pathInfo.Name.Length - 4);

            // Then we need to clone the repo down to the source folder and add a readme
            Clone_Repo(Properties.Settings.Default.CloneLocalSourcePath, false, path);
            File.CreateText(localPath + @"\ReadMe.txt").Close();

            // Then we need to add, commit, and push the changes

            response.Clear();

            try
            {
                Process add = Create_Process(localPath, Properties.Resources.REPO_ADD);

                if (add != null)
                {
                    response = Process_Output(add, "Add");

                    if (!(response[1] == "Add Error:\n\n"))
                    {
                        return response;
                    }
                }

                else
                {
                    response.Add("Add Process Error");
                    return response;
                }
            }

            catch(Exception ex)
            {
                response.Add("Add Exception:\n\n" + ex.Message);
                return response;
            }

            response.Clear();

            try
            {
                response.Clear();
                Process Committer = Create_Process(localPath, Properties.Resources.REPO_COMMIT_BLANK);

                if (Committer != null)
                {
                    response = Process_Output(Committer, "Commit");

                    if (!(response[1] == "Commit Error:\n\n"))
                    {
                        return response;
                    }
                }

                else
                {
                    response.Add("Commit Process Error");
                    return response;
                }
            }

            catch(Exception ex)
            {
                response.Add("Commit Exception:\n\n" + ex.Message);
                return response;
            }

            response.Clear();

            try
            {
                Process Pusher = Create_Process(localPath, Properties.Resources.REPO_PUSH);

                if (Pusher != null)
                {
                    response = Process_Output(Pusher, "Push");

                    if (!(response[1] == "Push Error:\n\n"))
                    {
                        //return response;
                    }
                }

                else
                {
                    response.Add("Push Process Error");
                    return response;
                }
            }

            catch(Exception ex)
            {
                response.Add("Push Exception:\n\n" + ex.Message);
                return response;
            }

            response.Clear();

            // Then we need to delete the local repo
            try
            {
                Delete_Directory(localPath);
            }

            catch (Exception ex)
            {
                response.Add("Delete Exception:\n\n" + ex.Message);
                return response;
            }

            return null;
        }

        #endregion Initialize_Blank_Repository


        #region Process_Output

        public static List<string> Process_Output(Process cmd, string designator = "")
        {
            //Process LogP = RepoHelpers.Create_Process(ManagerData.Selected_Repo.Path, " git --no-pager log");
            cmd.Start();
            string output = string.Empty;
            string error = string.Empty;
            output = cmd.StandardOutput.ReadToEnd();
            error = cmd.StandardError.ReadToEnd();
            cmd.StandardInput.WriteLine("exit");
            cmd.WaitForExit();

            List<string> returns = new List<string>();

            if (designator == "")
            {
                returns.Add(output);
                returns.Add(error);
            }

            else
            {
                returns.Add(designator + " Output:\n\n" + output);
                returns.Add(designator + " Error:\n\n" + error);
            }

            return returns;
        }

        #endregion Process_Output


        #region Delete_Directory

        public static void Delete_Directory(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                Delete_Directory(dir);
            }

            Directory.Delete(path, true);
        }

        #endregion Delete_Directory

        #endregion Create_Blank_Repository

        #endregion Class Methods
    }
}
