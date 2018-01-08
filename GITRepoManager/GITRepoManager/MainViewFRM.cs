using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public partial class MainViewFRM : Form
    {
        public MainViewFRM()
        {
            InitializeComponent();
        }

        private void NewRepoBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.NewIcon;
        }
    }
}
