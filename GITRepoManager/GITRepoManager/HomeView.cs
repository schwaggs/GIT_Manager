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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        #region Form Events

            private void Form1_Load(object sender, EventArgs e)
            {
            
            }

        #endregion

        #region Form Control Events

            #region New Repo Button

                #region Mouse Events

                    #region Enter

                        private void NewRepoBT_MouseEnter(object sender, EventArgs e)
                        {
                            NewRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
                            ButtonDescriptionSSLB.Text = Properties.Resources.NEW_REPO_COMMAND_INFO;
                        }

                    #endregion

                    #region Leave

                        private void NewRepoBT_MouseLeave(object sender, EventArgs e)
                        {
                            NewRepoBT.BackgroundImage = Properties.Resources.NewIcon;
                            ButtonDescriptionSSLB.Text = String.Empty;
                        }

                    #endregion

                    #region Click

                        private void NewRepoBT_Click(object sender, EventArgs e)
                        {
                            NewRepoFRM NewRepo = new NewRepoFRM();
                            NewRepo.ShowDialog();
                        }

                    #endregion

                #endregion
        
            #endregion

            #region Delete Repo Button

                #region Mouse Events

                    #region Enter

                        private void DeleteRepoBT_MouseEnter(object sender, EventArgs e)
                        {
                            DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
                            ButtonDescriptionSSLB.Text = Properties.Resources.DELETE_REPO_COMMAND_INFO;
                        }

                    #endregion

                    #region Leave

                        private void DeleteRepoBT_MouseLeave(object sender, EventArgs e)
                        {
                            DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon;
                            ButtonDescriptionSSLB.Text = String.Empty;
                        }

                    #endregion

                    #region Click

                        private void DeleteRepoBT_Click(object sender, EventArgs e)
                        {
                            DeleteRepoFRM DeleteRepo = new DeleteRepoFRM();
                            DeleteRepo.ShowDialog();
                        }

                    #endregion

                #endregion
        
            #endregion

            #region Move Repo Button

                #region Mouse Events

                    #region Enter

                        private void MoveRepoBT_MouseEnter(object sender, EventArgs e)
                        {
                            MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon_Hover;
                            ButtonDescriptionSSLB.Text = Properties.Resources.MOVE_REPO_COMMAND_INFO;
                        }

                    #endregion

                    #region Leave

                        private void MoveRepoBT_MouseLeave(object sender, EventArgs e)
                        {
                            MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon;
                            ButtonDescriptionSSLB.Text = String.Empty;
                        }

                    #endregion

                    #region Click

                        private void MoveRepoBT_Click(object sender, EventArgs e)
                        {
                            MoveRepoFRM MoveRepo = new MoveRepoFRM();
                            MoveRepo.ShowDialog();
                        }

                    #endregion

                #endregion
        
            #endregion

            #region Clone Repo Button

                #region Mouse Events

                    #region Enter

                        private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
                        {
                            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
                            ButtonDescriptionSSLB.Text = Properties.Resources.CLONE_REPO_COMMAND_INFO;
                        }

                    #endregion

                    #region Leave

                        private void CloneRepoBT_MouseLeave(object sender, EventArgs e)
                        {
                            CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon;
                            ButtonDescriptionSSLB.Text = String.Empty;
                        }

                    #endregion

                    #region Click

                        private void CloneRepoBT_Click(object sender, EventArgs e)
                        {
                            CloneRepoFRM CloneRepo = new CloneRepoFRM();
                            CloneRepo.ShowDialog();
                        }

                    #endregion

                #endregion
        
            #endregion

            #region Tag Repo Button

                #region Mouse Events

                    #region Enter

                        private void TagRepoBT_MouseEnter(object sender, EventArgs e)
                        {
                            TagRepoBT.BackgroundImage = Properties.Resources.TagIcon_Hover;
                            ButtonDescriptionSSLB.Text = Properties.Resources.TAG_REPO_COMMAND_INFO;
                        }

                    #endregion

                    #region Leave

                        private void TagRepoBT_MouseLeave(object sender, EventArgs e)
                        {
                            TagRepoBT.BackgroundImage = Properties.Resources.TagIcon;
                            ButtonDescriptionSSLB.Text = String.Empty;
                        }

                    #endregion

                    #region Click

                        private void TagRepoBT_Click(object sender, EventArgs e)
                        {
                            TagRepoFRM TagRepo = new TagRepoFRM();
                            TagRepo.ShowDialog();
                        }

                    #endregion

                #endregion
        
            #endregion

        #endregion
    }
}
