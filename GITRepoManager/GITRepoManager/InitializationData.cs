using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public static class InitializationData
    {
        public static bool Initialized { get; set; }
        public static bool Abort { get; set; }
        public static bool Retry { get; set; }
        public static InitializationViewFRM Initializer { get; set; }
        public static int Total_Directories { get; set; }
        public static int Progress_Inc { get; set; }
        public static string Exception_Message { get; set; }



        /// <summary>
        /// Initializes all class variables and data structures to default states.
        /// </summary>
        public static bool Initialize()
        {
            Initialized = false;
            Abort = false;

            Initializer = new InitializationViewFRM();

            ManagerData.Stores = new Dictionary<string, StoreCell>();
            
            return true;
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="roots">Background worker used to report progress.</param>
        /// <returns></returns>
        public static bool Initialize_Roots(BackgroundWorker roots)
        {
            try
            {
                string dir = Properties.Settings.Default.RepoBaseDir;

                DirectoryInfo temp = new DirectoryInfo(dir);

                foreach (string root in Directory.GetDirectories(dir))
                {
                    DirectoryInfo rootInfo = new DirectoryInfo(root);
                    StoreCell rootCell = new StoreCell(rootInfo.FullName);

                    ManagerData.Stores.Add(rootInfo.Name, rootCell);
                }

                return true;
            }

            catch(Exception ex)
            {
                ManagerData.Stores.Clear();
                Exception_Message = ex.Message;
                return false;
            }
        }
        





        public static int Get_Percentage(float den)
        {
            int ret = 0;

            try
            {
                ret = Convert.ToInt32(Math.Round(Convert.ToDecimal(1 / den * 100), 0, MidpointRounding.AwayFromZero));
            }

            catch
            {
                ret = 0;
            }

            return ret;
        }






        public static bool Get_Total()
        {
            Total_Directories = 0;

            try
            {
                Total_Directories = Directory.GetDirectories(Properties.Settings.Default.RepoBaseDir).Length;
            }

            catch
            {
                MessageBox.Show("Invalid Base Directory");
                return false;
            }

            foreach (string root in Directory.GetDirectories(Properties.Settings.Default.RepoBaseDir))
            {
                try
                {
                    Total_Directories += Directory.GetDirectories(root).Length;
                }

                catch
                {
                    continue;
                }
            }

            return true;
        }
    }
}
