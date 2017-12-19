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
            string NewRepoCMD = Properties.Resources.REPO_BASE_COMMAND
                              + Properties.Resources.NEW_REPO_BASE_COMMAND;

            if(NewRepoData.Repository_Option_Bare)
            {
                NewRepoCMD += Properties.Resources.NEW_REPO_OPTION_BARE;
            }

            NewRepoCMD += NewRepoData.Repository_Setting_Location;

            if (!NewRepoData.Repository_Setting_Use_Location)
            {
                NewRepoCMD += @"\" + NewRepoData.Repository_Setting_Name;
            }

            Process cmdProc = new Process();
            cmdProc.StartInfo.FileName = "cmd.exe";
            cmdProc.StartInfo.RedirectStandardInput = true;
            cmdProc.StartInfo.RedirectStandardOutput = true;
            cmdProc.StartInfo.CreateNoWindow = true;
            cmdProc.StartInfo.UseShellExecute = false;
            cmdProc.Start();

            cmdProc.StandardInput.WriteLine(NewRepoCMD);

            //if(NewRepoData.Repository_Option_Readme)
            //{
            //    NewRepoCMD = Properties.Resources.REPO_BASE_COMMAND
            //               + Properties.Resources.CLONE_REPO_BASE_COMMAND
            //               + NewRepoData.Repository_Setting_Location
            //               + " "
            //               + @"C:\Test_Repo";

            //    cmdProc.StandardInput.WriteLine(NewRepoCMD);
            //    cmdProc.StandardInput.WriteLine("cd " + @"C:\Test_Repo");

            //    NewRepoCMD = Properties.Resources.NEW_REPO_OPTION_README_TOUCH;
            //    cmdProc.StandardInput.WriteLine(NewRepoCMD);

            //    NewRepoCMD = Properties.Resources.REPO_BASE_COMMAND
            //               + Properties.Resources.NEW_REPO_OPTION_README_ADD;
            //    cmdProc.StandardInput.WriteLine(NewRepoCMD);

            //    NewRepoCMD = Properties.Resources.REPO_BASE_COMMAND
            //               + Properties.Resources.REPO_PUSH_ORIGIN_MASTER;
            //    cmdProc.StandardInput.WriteLine(NewRepoCMD);
            //}
            
            cmdProc.StandardInput.Flush();
            cmdProc.StandardInput.Close();
            cmdProc.Close();
        }
    }
}
