using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public static class CloneRepoMethods
    {
        public static void Clone_Repository()
        {
            Task.Run(() => Cloner());
        }

        public static void Cloner()
        {
           // string MoveRepoCommand = Properties.Resources.REPO_BASE_COMMAND + Properties.Resources.CLONE_REPO_BASE_COMMAND;
            //MoveRepoCommand += ("\"" + CloneRepoData.Repository_Source + "\"" + " ");

            Process cmdProc = new Process();
            cmdProc.StartInfo.FileName = "cmd.exe";
            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.StartInfo.UseShellExecute = false;
            cmdProc.Start();

            cmdProc.StandardInput.WriteLine("cd " + "\"" + CloneRepoData.Clone_Destination + "\"");
            //cmdProc.StandardInput.WriteLine(MoveRepoCommand);

            cmdProc.StandardInput.Flush();
            cmdProc.StandardInput.Close();
            cmdProc.Close();
        }
    }
}
