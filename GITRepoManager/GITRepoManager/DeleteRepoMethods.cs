using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class DeleteRepoMethods
    {
        public static void DeleteRepository()
        {
            if(DeleteRepoData.Delete_Local_Clone)
            {
                // Delete both
            }

            else if(DeleteRepoData.Is_Local_Clone)
            {
                // Find the repo it's attached to and update info after deleting clone
            }

            else
            {
                // Just delete repo
            }
        }

        public static async void Delete_Everything(string directory)
        {
            Directory.Delete(directory, true);
        }
    }
}
