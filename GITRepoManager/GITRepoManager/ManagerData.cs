using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    static class ManagerData
    {
        /// <summary>
        /// Dictionary where the key is the root name (directory name) and the value is a root cell which contains
        /// the full path to the root as well as a list of repos inside of the root.
        /// </summary>
        public static Dictionary<string, StoreCell> Stores { get; set; }

        /// <summary>
        /// Dictionary where the key is the repo name and the value is a repo cell which contains
        /// all the information needed to describe a repo.
        /// Full Path
        /// Current Status (None, New, Development, Production)
        /// DateTime of the last commit
        /// The last commit's message
        /// A list of notes
        /// A dictionary of logs where the key is the log id and the 
        /// </summary>

        public static StoreCell Selected_Store { get; set; }
        public static RepoCell Selected_Repo { get; set; }
        public static RepoCell Selected_Repo_Copy { get; set; }

        public static void Copy_Selected_Repo()
        {
            if (Selected_Repo != null)
            {
                Selected_Repo_Copy = new RepoCell();

                Selected_Repo_Copy.Name = Selected_Repo.Name;
                Selected_Repo_Copy.Path = Selected_Repo.Path;
                Selected_Repo_Copy.Current_Status = Selected_Repo.Current_Status;
                Selected_Repo_Copy.Last_Commit = Selected_Repo.Last_Commit;
                Selected_Repo_Copy.Last_Commit_Message = Selected_Repo.Last_Commit_Message;
                Selected_Repo_Copy.Notes = Selected_Repo.Notes;
                Selected_Repo_Copy.Logs = Selected_Repo.Logs;
            }

            else
            {
                Selected_Repo_Copy = null;
            }
        }
    }
}
