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
            InitializationViewFRM initialize = new InitializationViewFRM();
            initialize.Show();
            InitializeComponent();
        }

        private void NewRepoBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            AddRepoBT.BackgroundImage = Properties.Resources.NewIcon;
        }

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            if (Helpers.Is_Git_Repo(@"Z:\Engineering\Source Code\Firmware Files"))
            {
                MessageBox.Show("This is a repo");
            }

            else
            {
                MessageBox.Show("This is not a repo");
            }
        }

        private void Populate_List()
        {

        }

        private void MainViewFRM_Load(object sender, EventArgs e)
        {
            RepoProps repo = new RepoProps();

            RepoPG.SelectedObject = repo;
        }

        private void SettingsBT_Click(object sender, EventArgs e)
        {
            SettingsViewFRM settings = new SettingsViewFRM();
            settings.ShowDialog();
        }

        private void SettingsBT_MouseEnter(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon_Hover;
        }

        private void SettingsBT_MouseLeave(object sender, EventArgs e)
        {
            SettingsBT.BackgroundImage = Properties.Resources.Settings_Icon;
        }
    }
}
