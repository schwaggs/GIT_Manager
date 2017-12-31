using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public class RepoCell
    {
        public Label RepoControl { get; set; }
        public DirectoryInfo RepoDirInfo { get; set; }
        public bool Checked { get; set; }
        public static List<string> Tags { get; set; }
        public string RepoName { get; set; }
    }
}
