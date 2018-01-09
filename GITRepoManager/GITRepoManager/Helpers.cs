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
    public static class Helpers
    {
        public static string Exception_Message { get; set; }
        private static bool Is_Repo { get; set; }

        #region Is GIT Repo

        public static bool Is_Git_Repo(string dir)
        {
            Is_Repo = true;

            Process cmd = Create_Process(dir, "git log");

            if (cmd != null)
            {
                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.WaitForExit();

                if (Is_Repo)
                {
                    return true;
                }
            }

            return false;
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

        public static Process Create_Process(string dir, string arguments)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            Process cmdProc = new Process();
            ProcessStartInfo cmdInfo = new ProcessStartInfo();

            if (!dirInfo.Exists)
            {
                Exception_Message = "DNE";
                return null;
            }

            cmdInfo.FileName = "cmd.exe";
            cmdInfo.Arguments = "/c " + arguments;
            cmdInfo.WorkingDirectory = dirInfo.FullName;
            cmdInfo.RedirectStandardInput = true;
            cmdInfo.RedirectStandardOutput = true;
            cmdInfo.RedirectStandardError = true;
            cmdInfo.UseShellExecute = false;
            cmdInfo.CreateNoWindow = true;

            try
            {
                cmdProc.StartInfo = cmdInfo;
                cmdProc.EnableRaisingEvents = true;
                cmdProc.Exited += CmdProc_Exited;
                cmdProc.OutputDataReceived += CmdProc_OutputDataReceived;
                cmdProc.ErrorDataReceived += CmdProc_ErrorDataReceived;

                return cmdProc;
            }

            catch (Exception ex)
            {
                Exception_Message = ex.Message;
                return null;
            }
        }

        private static void CmdProc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("Error:  " + e.Data);
            if (!string.IsNullOrEmpty(e.Data) || !string.IsNullOrWhiteSpace(e.Data))
            {
                Is_Repo = false;
            }
        }

        private static void CmdProc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("Output:  " + e.Data);
        }

        #endregion

        #region Process Exited

        private static void CmdProc_Exited(object sender, EventArgs e)
        {
            //MessageBox.Show("Process exited");
        }

        #endregion
    }
}
