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
            Task.Run(() => Move_Repo()).ContinueWith(t => Delete_Directory(MoveRepoData.Repository_Source));
        }

        public static void Move_Repo()
        {
            string MoveCommand = ("mkdir " + "\"" + MoveRepoData.Repository_Destination + "\"");

            Process cmdProc = new Process();

            cmdProc.EnableRaisingEvents = true;

            cmdProc.Exited += (Sender, e) => { temp = true; };

            cmdProc.StartInfo.FileName = "cmd.exe";
            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.StartInfo.UseShellExecute = false;
            cmdProc.Start();

            // Create destination directory if it doesnt already exist
            cmdProc.StandardInput.WriteLine(MoveCommand);

            // Move into the destination directory
            MoveCommand = ("cd " + "\"" + MoveRepoData.Repository_Destination + "\"");
            cmdProc.StandardInput.WriteLine(MoveCommand);

            // Make a bare clone of the source repository into the destination directory
            MoveCommand = (Properties.Resources.REPO_BASE_COMMAND + Properties.Resources.MOVE_REPO_BASE_COMMAND);
            MoveCommand += ("\"" + MoveRepoData.Repository_Source + "\"");
            cmdProc.StandardInput.WriteLine(MoveCommand);

            // Mirror-push to the destination repository to make sure everything is up to date from the source repository
            MoveCommand = ("cd " + "\"" + MoveRepoData.Repository_Destination + "\"");
            cmdProc.StandardInput.WriteLine(MoveCommand);

            MoveCommand = (Properties.Resources.REPO_BASE_COMMAND + " push --mirror ");
            MoveCommand += ("\"" + MoveRepoData.Repository_Destination + "\"");
            cmdProc.StandardInput.WriteLine(MoveCommand);

            MoveCommand = "exit";
            cmdProc.StandardInput.WriteLine(MoveCommand);

            //cmdProc.StandardInput.Flush();
            //cmdProc.StandardInput.Close();
            //cmdProc.Close();


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
