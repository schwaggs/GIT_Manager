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
        }

        private void InitializationViewFRM_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                ProgressCPB.PerformStep();
            }
        }
    }
}
