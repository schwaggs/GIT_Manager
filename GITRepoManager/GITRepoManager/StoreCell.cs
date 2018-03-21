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

        /// <summary>
        /// The exception messaged returned by several methods which can be used for debugging
        /// </summary>
        private string Exception_Message { get; set; }

        /// <summary>
        /// A boolean indicating if an exception has occured, can be used for logging or debugging.
        /// </summary>
        private bool Exception_Occured { get; set; }

        /// <summary>
        /// The full path of the store
        /// </summary>
        public string _Path { get; set; }

        /// <summary>
        /// The count of repositories inside the store
        /// </summary>
        public int _Count { get; set; }

        /// <summary>
        /// The temporary storage of repositories in the current store for use in the application.
        /// </summary>
        public Dictionary<string, RepoCell> _Repos { get; set; }

        /// <summary>
        /// A boolean indicating if the store has a valid path
        /// </summary>
        private bool _Valid_Path { get; set; }

        #endregion


        #region Class Methods

        /// <summary>
        /// The constructor for the class which sets the store path.
        /// </summary>
        /// <param name="Path">The full path to the root folder. Cannot use UNC paths such as \\Server\Server Folder
        ///  Only drive paths can be used such as Z:\Server Folder</param>
        public StoreCell(string Path = "")
        {
            if (Path != "")
            {
                _Path = Path;
            }

            else
            {
                _Path = string.Empty;
            }
        }

        #endregion
    }
}
