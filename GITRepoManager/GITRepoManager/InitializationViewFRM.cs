using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public partial class InitializationViewFRM : Form
    {
        public InitializationViewFRM()
        {
            InitializeComponent();
            ProgressCPB.Value = 0;
        }

        private void InitializationViewFRM_Load(object sender, EventArgs e)
        {
            Configuration.Helpers.Deserialize(@"C:\Temp\config.gmc");
            string result = Helpers.Stores_To_String();
            bool cont = true;

            cont = InitializationData.Initialize();

            if (cont)
            {
                //cont = InitializationData.Initialize_Roots(null);

                if (cont)
                {
                    InitializationData.Initialized = true;
                }

                else
                {
                    InitializationData.Initialized = false;
                    InitializationData.Abort = true;
                }
            }

            else
            {
                InitializationData.Initialized = false;
                InitializationData.Abort = true;
            }
        }

        private void ProgressBarIncrT_Tick(object sender, EventArgs e)
        {
            if (ProgressCPB.Value + InitializationData.Progress_Inc < 100)
            {
                ProgressCPB.Value += InitializationData.Progress_Inc;
            }

            else
            {
                ProgressCPB.Value = 100;
            }

            if (ProgressCPB.Value == ProgressCPB.Maximum)
            {
                ProgressBarIncrT.Stop();
                InitializationData.Initialized = true;
            }
        }

        

        private void InitializationViewFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InitializationData.Initialized)
            {
                ProgressBarIncrT.Stop();
            }
        }

        private void ReposBGW_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ReposBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void ReposBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void RootsBGW_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RootsBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void RootsBGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
