using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainViewFRM main;

            if (args.Length > 0)
            {
                main = new MainViewFRM(args);
            }

            else
            {
                main = new MainViewFRM();
            }

            Application.Run(main);
        }
    }
}
