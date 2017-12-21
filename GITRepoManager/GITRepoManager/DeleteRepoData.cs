using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public static class DeleteRepoData
    {
        public static string Repository_Setting_Location { get; set; }
        public static string Clone_Setting_Location { get; set; }
        public static bool Is_Local_Clone { get; set; }
        public static bool Delete_Local_Clone { get; set; }
    }
}
