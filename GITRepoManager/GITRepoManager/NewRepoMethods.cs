using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GITRepoManager
{
    public static class NewRepoMethods
    {
        public static void CreateNewRepository()
        {
            string cmd1 = "git init --bare " + NewRepoData.Repository_Setting_Location;

            Process cmdProc = new Process();
            cmdProc.StartInfo.FileName = "cmd.exe";
            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.StartInfo.UseShellExecute = false;
            cmdProc.Start();

            cmdProc.StandardInput.WriteLine(cmd1);
            cmdProc.StandardInput.Flush();
            cmdProc.StandardInput.Close();
            cmdProc.Close();
        }
    }
}
