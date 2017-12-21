using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class NewRepoMethods
    {
        public static void CreateNewRepository()
        {
            string NewCommand = Properties.Resources.REPO_BASE_COMMAND + Properties.Resources.NEW_REPO_BASE_COMMAND;
            DirectoryInfo dirInfo = Create_Directories();

            Process cmdProc = new Process();

            cmdProc.StartInfo.FileName = "cmd.exe";

            try
            {
                cmdProc.StartInfo.WorkingDirectory = dirInfo.FullName;
            }

            catch(Exception ex)
            {
                return;
            }

            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.StartInfo.UseShellExecute = false;
            cmdProc.Start();

            if(NewRepoData.Repository_Option_Bare)
            {
                NewCommand += Properties.Resources.NEW_REPO_OPTION_BARE;
            }

            cmdProc.StandardInput.WriteLine(NewCommand);
        }






        public static DirectoryInfo Create_Directories()
        {
            string dir = NewRepoData.Repository_Setting_Location;
            string[] subdirs = { string.Empty };

            if (!NewRepoData.Repository_Setting_Use_Location)
            {
                subdirs[0] = NewRepoData.Repository_Setting_Name;
            }

            return RepoIO.Create_Directory(dir, subdirs);
        }
    }
}
