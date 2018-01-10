using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class TagRepoData
    {
        public static int Selected_Repos_Count { get; set; }
        public static List<RepoCellOld> Selected_Repos { get; set; }
        public static List<RepoCellOld> All_Repos { get; set; }
        public static Panel CurrentView { get; set; }
        public static Dictionary<string, List<string>> Repo_Tags { get; set; }
        public static List<string> Temp_Tags { get; set; }
    }
}
