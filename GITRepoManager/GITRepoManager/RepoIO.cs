using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public static class RepoIO
    {
        public static string ExceptionMessage { get; set; }






        public static DirectoryInfo Create_Directory(string DirToCreate, string[] Subdirectories = null)
        {
            DirectoryInfo DirToCreateInfo;

            if(Subdirectories != null)
            {
                if (Subdirectories != null)
                {
                    foreach (string subdir in Subdirectories)
                    {
                        DirToCreate += (@"\" + subdir);
                    }
                }
            }

            DirToCreateInfo = new DirectoryInfo(DirToCreate + Properties.Resources.REPO_FOLDER_EXTENSION);

            if (DirToCreateInfo.Exists)
            {
                return null;
            }

            else
            {
                DirToCreateInfo.Create();
                return DirToCreateInfo;
            }
        }






        public static bool Delete_Directory(string DirToDelete)
        {
            //string[] files = Directory.GetFiles(DirToDelete.FullName);
            //string[] dirs = Directory.GetDirectories(DirToDelete.FullName);

            //foreach (string file in files)
            //{
            //    File.SetAttributes(file, FileAttributes.Normal);
            //    File.Delete(file);
            //}

            //foreach (string dir in dirs)
            //{
            //    Delete_Directory(new FileInfo(dir));
            //}

            //try
            //{
            //    Directory.Delete(DirToDelete.FullName, false);
            //}

            //catch (UnauthorizedAccessException ex)
            //{
            //    ExceptionMessage = ex.Message;
            //}

            DirectoryInfo DirToDeleteInfo = new DirectoryInfo(DirToDelete);

            if (DirToDeleteInfo.Exists)
            {
                DirToDeleteInfo.Delete(true);
                return true;
            }

            else
            {
                return false;
            }
        }






        public static DirectoryInfo Move_Directory(string SourceDir, string DestinationDir)
        {
            // If this doesnt work need to use cmd calls

            //string MoveCommand = ("mkdir " + "\"" + MoveRepoData.Repository_Destination + "\"");

            //Process cmdProc = new Process();

            //cmdProc.EnableRaisingEvents = true;

            //cmdProc.Exited += (Sender, e) => { temp = true; };

            //cmdProc.StartInfo.FileName = "cmd.exe";
            //cmdProc.StartInfo.RedirectStandardInput = true;
            //cmdProc.StartInfo.RedirectStandardOutput = true;
            //cmdProc.StartInfo.CreateNoWindow = true;
            //cmdProc.StartInfo.UseShellExecute = false;
            //cmdProc.Start();

            //// Create destination directory if it doesnt already exist
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            //// Move into the destination directory
            //MoveCommand = ("cd " + "\"" + MoveRepoData.Repository_Destination + "\"");
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            //// Make a bare clone of the source repository into the destination directory
            //MoveCommand = (Properties.Resources.REPO_BASE_COMMAND + Properties.Resources.MOVE_REPO_BASE_COMMAND);
            //MoveCommand += ("\"" + MoveRepoData.Repository_Source + "\"");
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            //// Mirror-push to the destination repository to make sure everything is up to date from the source repository
            //MoveCommand = ("cd " + "\"" + MoveRepoData.Repository_Destination + "\"");
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            //MoveCommand = (Properties.Resources.REPO_BASE_COMMAND + " push --mirror ");
            //MoveCommand += ("\"" + MoveRepoData.Repository_Destination + "\"");
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            //MoveCommand = "exit";
            //cmdProc.StandardInput.WriteLine(MoveCommand);

            DirectoryInfo SourceDirInfo = new DirectoryInfo(SourceDir);
            DirectoryInfo DestinationDirInfo = new DirectoryInfo(DestinationDir);
            DirectoryInfo DestinationFromSource = new DirectoryInfo(DestinationDir + @"\" + SourceDirInfo.Name);

            if (DestinationFromSource.Exists)
            {
                // Destination cannot exist, either just delete or prompt user and ask what to do

                Delete_Directory(DestinationFromSource.FullName);
                return null;
            }

            else
            {
                SourceDirInfo.MoveTo(DestinationFromSource.FullName);
                return DestinationFromSource;
            }
        }






        public static string Add_Quotes(string dir)
        {
            return ("\"" + dir + "\"");
        }
    }
}
