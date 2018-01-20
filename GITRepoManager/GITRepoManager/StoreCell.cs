using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public class StoreCell
    {
        #region Class Data

        private string Exception_Message { get; set; }

        private bool Exception_Occured { get; set; }

        public string _Path { get; set; }

        public int _Count { get; set; }

        public Dictionary<string, RepoCell> _Repos { get; set; }

        private bool _Valid_Path { get; set; }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path">The full path to the root folder. Cannot use UNC paths such as \\Server\Server Folder
        ///  Only drive paths can be used such as Z:\Server Folder</param>
        public StoreCell(string Path = "")
        {
            //_Repos = new Dictionary<string, RepoCell>();
            //if (Path != "")
            //{
            //    _Path = Path;
            //}

            //else
            //{
            //    _Path = string.Empty;
            //}

            //Check_Path();

            //if (_Valid_Path)
            //{
            //    Num_Repos();

            //    _Repos = new Dictionary<string, RepoCell>();
            //    Get_Repos();
            //}

            //else
            //{
            //    _Path = string.Empty;
            //}
        }

        /// <summary>
        /// Gets the number of repositories inside the root's path or the number of stored repositories inside the Repos dictionary.
        /// </summary>
        /// <param name="Use_Directory">If true will return the number of directories inside the root.
        /// Otherwise will return the number of repos stored inside the Repos dictionary</param>
        /// <returns>An integer representing the number of repos found either inside the path or the Repos dictionary</returns>
        public void Num_Repos()
        {
            try
            {
                _Count = Directory.GetDirectories(_Path).Length;
            }

            catch(Exception ex)
            {
                _Count = 0;

                // Can be used for logging just need to create a log file when this class is called and output to it
                Exception_Occured = true;
                Exception_Message = ex.Message;

                Append_Log();
            }
        }





        /// <summary>
        /// 
        /// </summary>
        public void Get_Repos()
        {
            try
            {
                foreach (string repo in Directory.GetDirectories(_Path))
                {
                    DirectoryInfo repoInfo = new DirectoryInfo(repo);

                    RepoCell cell = new RepoCell
                    {
                        Path = repo,
                        Current_Status = RepoCell.Status.Type.NONE,
                        Last_Commit = DateTime.MinValue,
                        Last_Commit_Message = string.Empty,
                        //Notes = new Dictionary<string, List<NoteCell>>(),
                        Logs = new Dictionary<string, List<EntryCell>>()
                    };

                    _Repos.Add(repoInfo.Name, cell);
                }
            }

            catch (Exception ex)
            {
                _Repos.Clear();

                // Can be used for logging just need to create a log file when this class is called and output to it
                Exception_Occured = true;
                Exception_Message = ex.Message;
            }
        }





        public void Check_Path()
        {
            _Valid_Path = true;

            try
            {
                _Valid_Path = Directory.Exists(_Path);
            }

            catch(Exception ex)
            {
                _Valid_Path = false;

                // Can be used for logging just need to create a log file when this class is called and output to it
                Exception_Occured = true;
                Exception_Message = ex.Message;
            }
        }

        private void Append_Log()
        {

        }
    }
}
