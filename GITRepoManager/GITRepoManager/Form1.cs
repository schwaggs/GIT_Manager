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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Mouse Click Events

            private void CloneRepoBT_Click(object sender, EventArgs e)
            {
                TitleLB.Focus();


            }

            private void NewRepoBT_Click(object sender, EventArgs e)
            {
                TitleLB.Focus();


            }

            private void DeleteRepoBT_Click(object sender, EventArgs e)
            {
                TitleLB.Focus();


            }

            private void MoveRepoBT_Click(object sender, EventArgs e)
            {
                TitleLB.Focus();


            }

            private void LabelRepoBT_Click(object sender, EventArgs e)
            {
                TitleLB.Focus();


            }

        #endregion

        #region Mouse Hover Events

        private void NewRepoBT_MouseEnter(object sender, EventArgs e)
            {
                NewRepoBT.BackgroundImage = Properties.Resources.NewIcon_Hover;
                CommandInfoTB.Text = Properties.Resources.NEW_REPO_COMMAND_INFO;


            }

            private void NewRepoBT_MouseLeave(object sender, EventArgs e)
            {
                NewRepoBT.BackgroundImage = Properties.Resources.NewIcon;
                CommandInfoTB.Clear();


            }

            private void DeleteRepoBT_MouseEnter(object sender, EventArgs e)
            {
                DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon_Hover;
                CommandInfoTB.Text = Properties.Resources.DELETE_REPO_COMMAND_INFO;


            }

            private void DeleteRepoBT_MouseLeave(object sender, EventArgs e)
            {
                DeleteRepoBT.BackgroundImage = Properties.Resources.DeleteIcon;
                CommandInfoTB.Clear();


            }

            private void MoveRepoBT_MouseEnter(object sender, EventArgs e)
            {
                MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon_Hover;
                CommandInfoTB.Text = Properties.Resources.MOVE_REPO_COMMAND_INFO;


            }

            private void MoveRepoBT_MouseLeave(object sender, EventArgs e)
            {
                MoveRepoBT.BackgroundImage = Properties.Resources.MoveIcon;
                CommandInfoTB.Clear();


            }

            private void CloneRepoBT_MouseEnter(object sender, EventArgs e)
            {
                CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon_Hover;
                CommandInfoTB.Text = Properties.Resources.CLONE_REPO_COMMAND_INFO;


            }

            private void CloneRepoBT_MouseLeave(object sender, EventArgs e)
            {
                CloneRepoBT.BackgroundImage = Properties.Resources.CloneIcon;
                CommandInfoTB.Clear();


            }

            private void LabelRepoBT_MouseEnter(object sender, EventArgs e)
            {
                LabelRepoBT.BackgroundImage = Properties.Resources.TagIcon_Hover;
                CommandInfoTB.Text = Properties.Resources.TAG_REPO_COMMAND_INFO;


            }

            private void LabelRepoBT_MouseLeave(object sender, EventArgs e)
            {
                LabelRepoBT.BackgroundImage = Properties.Resources.TagIcon;
                CommandInfoTB.Clear();


            }

        #endregion

        #region Remove Selection Rectangel From Buttons

        private void Form1_Load(object sender, EventArgs e)
            {
                TitleLB.Focus();
            }

            private void NewRepoBT_Paint(object sender, PaintEventArgs e)
            {
                TitleLB.Focus();
            }

            private void DeleteRepoBT_Paint(object sender, PaintEventArgs e)
            {
                TitleLB.Focus();
            }

            private void MoveRepoBT_Paint(object sender, PaintEventArgs e)
            {
                TitleLB.Focus();
            }

            private void CloneRepoBT_Paint(object sender, PaintEventArgs e)
            {
                TitleLB.Focus();
            }

        #endregion
    }
}
