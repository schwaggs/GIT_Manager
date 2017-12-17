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
    public partial class NewRepoFRM : Form
    {
        public NewRepoFRM()
        {
            InitializeComponent();
        }

        private void NewRepoBT_Click(object sender, EventArgs e)
        {

        }

        private void NewRepoBT_MouseEnter(object sender, EventArgs e)
        {
            NewRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
        }

        private void NewRepoBT_MouseLeave(object sender, EventArgs e)
        {
            NewRepoBT.BackgroundImage = Properties.Resources.NewIcon;
        }

        private void NewRepoFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool StoreData = true;

            if(String.IsNullOrEmpty(RepoNameTB.Text) || String.IsNullOrWhiteSpace(RepoNameTB.Text))
            {
                StoreData = false;

                var Verify = MessageBox.Show
                            (
                                this,
                                "Repository name is empty, close window?",
                                "Close New Repo Window",
                                MessageBoxButtons.YesNo
                            );

                e.Cancel = (Verify == DialogResult.No);

            }

            else if (String.IsNullOrEmpty(RepoLocationTB.Text) || String.IsNullOrWhiteSpace(RepoLocationTB.Text))
            {
                StoreData = false;

                var Verify = MessageBox.Show
                            (
                                this,
                                "Repository location is empty, close window?",
                                "Close New Repo Window",
                                MessageBoxButtons.YesNo
                            );

                e.Cancel = (Verify == DialogResult.No);

            }

            if(StoreData)
            {
                NewRepoData.Repository_Setting_Name = RepoNameTB.Text;
                NewRepoData.Repository_Setting_Location = RepoLocationTB.Text;
                NewRepoData.Repository_Option_Bare = OptionBareCB.Checked;
                NewRepoData.Repository_Option_Readme = OptionReadmeCB.Checked;

                NewRepoMethods.CreateNewRepository();
            }

            else
            {
                NewRepoData.Repository_Setting_Name = String.Empty;
                NewRepoData.Repository_Setting_Location = String.Empty;
                NewRepoData.Repository_Option_Bare = false;
                NewRepoData.Repository_Option_Readme = false;
            }
        }
    }
}
