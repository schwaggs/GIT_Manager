﻿using System;
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


        #region Create Directory

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


        #region Delete Directory

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


        #region Move Directory

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


        #region List Directory

        /*
         *   ________________________________________________________________________________
         *   # Method:              List_Directory                                          #
         *   #                                                                              #
         *   # Usage:               Creates a list of directory info's for a given path     #
         *   #                                                                              #
         *   # Parameters:          Path - A string of the root path to search              #   
         *   #                                                                              #
         *   # Returns:             A list of directory info's containing all repos         #
         *   #                                                                              #
         *   # Last Date Modified:  12/29/17                                                #
         *   #                                                                              #
         *   # Last Modified By:    Josh                                                    #
         *   #                                                                              #
         *   ________________________________________________________________________________
         */

            public static List<DirectoryInfo> List_Directory(string path)
            {
                List<DirectoryInfo> dir = new List<DirectoryInfo>();

                if(path.Contains(".git"))
                {
                    dir.Add(new DirectoryInfo(path));
                }
                
                else
                {
                    try
                    {
                        foreach(string subdir in Directory.GetDirectories(path))
                        {
                            if (subdir.Contains(".git"))
                            {
                                dir.Add(new DirectoryInfo(subdir));
                            }
                        }
                    }

                    catch
                    {
                        dir.Clear();
                        return dir;
                    }
                }

                return dir.OrderBy(x => x.FullName).ToList();
            }

        #endregion


        #region Add Quotes

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


        #region Create Process

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


        #region Get Directory Name

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
            public static string Repo_Name(DirectoryInfo dir)
            {
                if(dir.FullName.Contains(".git"))
                {
                    return dir.Name.Substring(0, dir.Name.Length - 4);
                }

                else
                {
                    return dir.Name;
                }
            }

        #endregion

        #region Get Repo Log

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
            public static string Get_Repo_Log(DirectoryInfo SourceDirInfo)
            {
                string result = string.Empty;
                //DirectoryInfo SourceDirInfo = new DirectoryInfo(SourceDir);
                ExceptionMessage = string.Empty;

                //if (SourceDirInfo.Exists)
                //{
                    //if(SourceDirInfo.FullName.Contains(".git"))
                    //{
                        string date = DateTime.Today.Month.ToString() + @"-"
                                        + DateTime.Today.Day.ToString() + @"-"
                                        + DateTime.Today.Year.ToString();

                        string filename = Repo_Name(SourceDirInfo) + "_" + date + @".txt"; 
                        string outputFile = SourceDirInfo.FullName + @"\" + filename;

                        try
                        {
                            using (FileStream fs = File.Open(outputFile, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite))
                            {
                            }
                        }

                        catch(Exception ex)
                        {
                        }

                        try
                        {
                            Process logP = Create_Process(SourceDirInfo.FullName);
                            logP.Start();

                            logP.StandardInput.WriteLine(string.Format(Properties.Resources.LOG_REPO_COMMAND, filename));
                            logP.WaitForExit(1000);
                            logP.Close();
                        }

                        catch (Exception ex)
                        {
                            ExceptionMessage = ex.Message;
                            return @"Unable to execute git command.";
                        }
                        
                        try
                        {
                            using(StreamReader stream = new StreamReader(outputFile))
                            {
                                while(!stream.EndOfStream)
                                {
                                    result += (stream.ReadLine() + Environment.NewLine);
                                }
                            }

                            if(result == string.Empty)
                            {
                                result = "No logs found.";
                            }

                            return result;                            
                        }

                        catch(Exception ex)
                        {
                            ExceptionMessage = ex.Message;
                            return @"Unable to retrieve log.";
                        }

                    //}

                    return @"Not a valid repository.";
                //}

                return @"Invalid Location.";
            }

        #endregion
    }
}
