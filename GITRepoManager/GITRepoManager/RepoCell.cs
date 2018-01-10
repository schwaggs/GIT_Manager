using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public class RepoCell
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Status_Type Status { get; set; }
        public DateTime Last_Commit { get; set; }               
        public string Last_Commit_Message { get; set; }         

        public List<string> Notes { get; set; }                 
        public Dictionary<string, string> Logs { get; set; }    

        public enum Status_Type
        {
            NONE = 0,
            NEW = 1,
            DEVELOPMENT = 2,
            PRODUCTION = 3
        }
    }
}
