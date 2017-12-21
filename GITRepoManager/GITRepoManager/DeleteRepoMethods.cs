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
            if (DeleteRepoData.Delete_Local_Clone)
            {
                Task.Run(() => Delete_Directory(DeleteRepoData.Repository_Setting_Location));
                Task.Run(() => Delete_Directory(DeleteRepoData.Clone_Setting_Location));
            }

            else if (DeleteRepoData.Is_Local_Clone)
            {
                Task.Run(() => RepoIO.Delete_Directory(DeleteRepoData.Repository_Setting_Location));
            }

            else
            {
                Task.Run(() => RepoIO.Delete_Directory(DeleteRepoData.Repository_Setting_Location));
            }
        }

        public static void Delete_Directory(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                Delete_Directory(dir);
            }

            try
            {
                Directory.Delete(directory, false);
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access Exception");
            }
        }
    }
}
