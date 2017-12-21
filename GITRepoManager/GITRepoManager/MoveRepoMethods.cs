using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class MoveRepoMethods
    {
        static bool temp = false;

        public static void MoveRepository()
        {
            Task.Run(() => Move_Repo());
        }

        public static void Move_Repo()
        {
            if (RepoIO.Move_Directory(MoveRepoData.Repository_Source, MoveRepoData.Repository_Destination) == null)
            {
                MessageBox.Show(RepoIO.ExceptionMessage);

                if (RepoIO.ExceptionMessage == "")
                {
                }
            }
        }

        public static void Delete_Directory(string directory)
        {
            while (temp == false) { Task.Delay(100); };

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
