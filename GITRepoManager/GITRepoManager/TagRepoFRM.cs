using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    public partial class TagRepoFRM : Form
    {
        public TagRepoFRM()
        {
            InitializeComponent();
        }

        private NoFocusSelectionRectangleButton BlankButton(string name)
        {
            NoFocusSelectionRectangleButton temp = new NoFocusSelectionRectangleButton();
            temp.Name = name;
            temp.Click += Temp_Click;
            temp.MouseEnter += Temp_MouseEnter;
            temp.MouseLeave += Temp_MouseLeave;
            temp.BackgroundImage = Properties.Resources.RepositoryIcon;
            temp.BackgroundImageLayout = ImageLayout.Stretch;
            temp.Width = 70;
            temp.Height = 79;
            temp.AutoSize = true;
            temp.BackColor = Color.Transparent;
            temp.UseVisualStyleBackColor = false;
            temp.FlatStyle = FlatStyle.Flat;
            temp.FlatAppearance.BorderColor = Color.White;
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            temp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            return temp;
        }

        private void Temp_MouseLeave(object sender, EventArgs e)
        {
            NoFocusSelectionRectangleButton temp = sender as NoFocusSelectionRectangleButton;
            temp.BackgroundImage = Properties.Resources.RepositoryIcon;
        }

        private void Temp_MouseEnter(object sender, EventArgs e)
        {
            NoFocusSelectionRectangleButton temp = sender as NoFocusSelectionRectangleButton;
            temp.BackgroundImage = Properties.Resources.RepositoryIcon_Hover;
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            NoFocusSelectionRectangleButton temp = sender as NoFocusSelectionRectangleButton;
            MessageBox.Show(temp.Name);
        }

        private void BrowseRepoSourceBT_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = @"C:\",

                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                RepoSourceTB.Text = dialog.FileName;
            }
        }

        private void BrowseRepoSourceBT_MouseEnter(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon_Hover;
        }

        private void BrowseRepoSourceBT_MouseLeave(object sender, EventArgs e)
        {
            BrowseRepoSourceBT.BackgroundImage = Properties.Resources.Browse_Icon;
        }

        private void RepoSourceTB_TextChanged(object sender, EventArgs e)
        {
            foreach(DirectoryInfo dir in RepoIO.List_Directory(RepoSourceTB.Text))
            {
                flowLayoutPanel1.Controls.Add(BlankButton(dir.FullName.Substring(0, dir.FullName.Length - 3)));
            }
        }
    }
}
