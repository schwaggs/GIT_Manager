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
            //string NewCommand = Properties.Resources.REPO_BASE_COMMAND + Properties.Resources.NEW_REPO_BASE_COMMAND;

            DirectoryInfo dirInfo = Create_Directories(false);

            while (dirInfo == null)
            {
                if (RepoIO.ExceptionMessage != string.Empty)
                {
                    MessageBox.Show(RepoIO.ExceptionMessage);
                    return;
                }

                else
                {
                    DialogResult dialogResult = MessageBox.Show("Directory Already Exists, Overwrite?", "Overwrite Existing Directory", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        dirInfo = Create_Directories(true);
                    }
                }
            }

            Process cmdProc = RepoIO.Create_Process(dirInfo.FullName);

            if (cmdProc == null)
            {
                if (RepoIO.ExceptionMessage != string.Empty || RepoIO.ExceptionMessage != null)
                {
                    MessageBox.Show(RepoIO.ExceptionMessage);
                }

                else
                {
                    MessageBox.Show("Unknown Error, could not create repository");
                }

                return;
            }
            
            cmdProc.Start();

            if(NewRepoData.Repository_Option_Bare)
            {
                //NewCommand += Properties.Resources.NEW_REPO_OPTION_BARE;
            }

            //cmdProc.StandardInput.WriteLine(NewCommand);
            cmdProc.StandardInput.WriteLine("Exit");
        }






        public static DirectoryInfo Create_Directories(bool overwrite)
        {
            string dir = NewRepoData.Repository_Setting_Location;
            string[] subdirs = { string.Empty };

            if (!NewRepoData.Repository_Setting_Use_Location)
            {
                subdirs[0] = NewRepoData.Repository_Setting_Name;
            }

            if (overwrite)
            {
                if (!RepoIO.Delete_Directory(dir, subdirs) && RepoIO.ExceptionMessage == string.Empty)
                {
                    return null;
                }

                else if(RepoIO.ExceptionMessage != string.Empty)
                {
                    return null;
                }

                while (!RepoIO.DirectoryDeleted)
                {
                    Task.Delay(25);
                }
            }

            return RepoIO.Create_Directory(dir, subdirs);
        }
    }
}
