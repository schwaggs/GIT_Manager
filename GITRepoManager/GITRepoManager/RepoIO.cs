using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITRepoManager
{
    public static class RepoIO
    {
        #region Data

        /*
         *   ________________________________________________________________________________
         *   # Variable:            #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
        public static string ExceptionMessage { get; set; }


        /*
         *   ________________________________________________________________________________
         *   # Variable:            #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
        public static bool DirectoryDeleted { get; set; }


        /*
         *   ________________________________________________________________________________
         *   # Variable:            #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
        public static bool DirectoryCreated { get; set; }


        /*
         *   ________________________________________________________________________________
         *   # Variable:            #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */
        public static bool DirectoryMoved { get; set; }



        #endregion


        #region Create_Directory

        /*
         *   ________________________________________________________________________________
         *   # Method:              #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   # Parameters:          #   
         *   #                                                                              #
         *   # Returns:             #
         *   #                                                                              #
         *   # Last Date Modified:  #
         *   #                                                                              #
         *   # Last Modified By:    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

        public static DirectoryInfo Create_Directory(string DirToCreate, string[] Subdirectories = null)
            {
                ExceptionMessage = string.Empty;

                if(Subdirectories != null)
                {
                    foreach (string subdir in Subdirectories)
                    {
                        DirToCreate += (@"\" + subdir);
                    }
                }

                DirectoryInfo DirToCreateInfo = new DirectoryInfo(DirToCreate + Properties.Resources.REPO_FOLDER_EXTENSION);

                if (DirToCreateInfo.Exists)
                {
                    DirectoryCreated = false;
                    return null;
                }

                else
                {
                    try
                    {
                        DirToCreateInfo.Create();
                        DirectoryCreated = true;
                        return DirToCreateInfo;
                    }

                    catch (Exception ex)
                    {
                        ExceptionMessage = ex.Message;
                        DirectoryCreated = false;
                        return null;
                    }
                }
            }

        #endregion


        #region Delete_Directory

        /*
         *   ________________________________________________________________________________
         *   # Method:                                                                      #
         *   #                                                                              #
         *   # Usage:                                                                       #
         *   #                                                                              #
         *   # Parameters:                                                                  #   
         *   #                                                                              #
         *   # Returns:                                                                     #
         *   #                                                                              #
         *   # Last Date Modified:                                                          #
         *   #                                                                              #
         *   # Last Modified By:                                                            #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

            public static bool Delete_Directory(string DirToDelete, string [] Subdirectories = null)
            {
                ExceptionMessage = string.Empty;

                if(Subdirectories != null)
                {
                    foreach (string subdir in Subdirectories)
                    {
                        DirToDelete += (subdir + @"\");
                    }
                }

                //DirToDelete = DirToDelete.Substring(0, DirToDelete.Length);

                //if(!DeleteRepoData.Is_Local_Clone)
                //{
                //    DirToDelete += Properties.Resources.REPO_FOLDER_EXTENSION;
                //}

                DirectoryInfo DirToDeleteInfo = new DirectoryInfo(DirToDelete){ Attributes = FileAttributes.Normal };



                if (DirToDeleteInfo.Exists)
                {
                    try
                    {
                        foreach (var info in DirToDeleteInfo.GetFileSystemInfos("*", SearchOption.AllDirectories))
                        {
                            info.Attributes = FileAttributes.Normal;
                        }

                        DirToDeleteInfo.Delete(true);
                        DirectoryDeleted = true;
                        return true;
                    }

                    catch (Exception ex)
                    {
                        ExceptionMessage = ex.Message;
                        DirectoryDeleted = false;
                        return false;
                    }
                }

                else
                {
                    DirectoryDeleted = false;
                    return false;
                }
            }

        #endregion


        #region Move_Directory

        /*
         *   ________________________________________________________________________________
         *   # Method:              #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   # Parameters:          #   
         *   #                                                                              #
         *   # Returns:             #
         *   #                                                                              #
         *   # Last Date Modified:  #
         *   #                                                                              #
         *   # Last Modified By:    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

            public static DirectoryInfo Move_Directory(string SourceDir, string DestinationDir)
            {
                DirectoryInfo SourceDirInfo = new DirectoryInfo(SourceDir);
                DirectoryInfo DestinationDirInfo = new DirectoryInfo(DestinationDir);
                DirectoryInfo DestinationFromSource = new DirectoryInfo(DestinationDir + @"\" + SourceDirInfo.Name);
                ExceptionMessage = string.Empty;

                if (DestinationFromSource.Exists)
                {
                    // Destination cannot exist, either just delete or prompt user and ask what to do
                    try
                    {
                        Delete_Directory(DestinationFromSource.FullName);
                    }

                    catch(Exception ex)
                    {
                        ExceptionMessage = ex.Message; 
                    }
                    
                    DirectoryMoved = false;
                    return null;
                }

                else
                {
                    try
                    {
                        SourceDirInfo.MoveTo(DestinationFromSource.FullName);

                        DirectoryMoved = true;
                        return DestinationFromSource;
                    }

                    catch(Exception ex)
                    {
                        ExceptionMessage = ex.Message;
                        DirectoryMoved = false;
                        return null;
                    }
                }
            }

        #endregion


        #region Add_Quotes

        /*
         *   ________________________________________________________________________________
         *   # Method:              #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   # Parameters:          #   
         *   #                                                                              #
         *   # Returns:             #
         *   #                                                                              #
         *   # Last Date Modified:  #
         *   #                                                                              #
         *   # Last Modified By:    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

            public static string Add_Quotes(string dir)
            {
                return ("\"" + dir + "\"");
            }

        #endregion


        #region Create_Process

        /*
         *   ________________________________________________________________________________
         *   # Method:              #
         *   #                                                                              #
         *   # Usage:               #
         *   #                                                                              #
         *   # Parameters:          #   
         *   #                                                                              #
         *   # Returns:             #
         *   #                                                                              #
         *   # Last Date Modified:  #
         *   #                                                                              #
         *   # Last Modified By:    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

            public static Process Create_Process(string dir)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                Process cmdProc = new Process();
                ExceptionMessage = string.Empty;

                cmdProc.StartInfo.FileName = "cmd.exe";

                try
                {
                    cmdProc.StartInfo.WorkingDirectory = dirInfo.FullName;
                }

                catch (Exception ex)
                {
                    ExceptionMessage = ex.Message;
                    return null;
                }

                cmdProc.StartInfo.RedirectStandardInput = true;
                cmdProc.StartInfo.RedirectStandardOutput = true;
                cmdProc.StartInfo.CreateNoWindow = true;
                cmdProc.StartInfo.UseShellExecute = false;

                return cmdProc;
            }

        #endregion
    }
}
