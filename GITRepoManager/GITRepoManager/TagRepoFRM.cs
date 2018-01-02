﻿using Microsoft.WindowsAPICodePack.Dialogs;
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

        private FlowLayoutPanel Found_Repo_Cell(Label name, NoFocusSelectionRectangleButton item)
        {
            FlowLayoutPanel temp = new FlowLayoutPanel();
            temp.FlowDirection = FlowDirection.TopDown;
            temp.WrapContents = true;

            temp.WrapContents = false;
            temp.Controls.Add(item);
            temp.Controls.Add(name);

            temp.AutoSize = true;


            return temp;
        }

        private Label BlankButtonLabel(string name)
        {
            Label temp = new Label();
            temp.Text = name;
            temp.ForeColor = Color.Black;
            temp.TextAlign = ContentAlignment.MiddleCenter;
            temp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            temp.AutoSize = true;
            temp.MaximumSize = temp.Size;
            return temp;
        }

        private CheckBox BlankCheckbox(string name)
        {
            CheckBox temp = new CheckBox();
            temp.Name = name;
            temp.Text = name;
            temp.AutoSize = true;
            temp.Padding = new Padding(5);

            return temp;
        }

        private Label BlankLabel(string name)
        {
            Label temp = new Label();
            temp.Name = name;
            temp.Text = name;
            temp.AutoSize = true;
            temp.Padding = new Padding(5);
            temp.Font = new Font(temp.Font.FontFamily, 5, FontStyle.Regular);

            temp.MouseEnter += Label_MouseEnter;
            temp.MouseLeave += Label_MouseLeave;
            temp.Click += Label_Click;

            return temp;
        }

        private NoFocusSelectionRectangleButton BlankButton(string name)
        {
            NoFocusSelectionRectangleButton temp = new NoFocusSelectionRectangleButton();
            temp.Name = name;
            temp.Click += Temp_Click;
            temp.MouseEnter += Temp_MouseEnter;
            temp.MouseLeave += Temp_MouseLeave;
            temp.BackgroundImage = Properties.Resources.RepositoryIcon;
            temp.BackgroundImageLayout = ImageLayout.Center;
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
            temp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

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
            TagRepoData.Selected_Repos_Count = 0;
            numericUpDown1.Visible = false;
            SearchResultsP.Visible = false;
            SelectAllBT.Visible = false;
            SelectNoneBT.Visible = false;
            EditSelectedBT.Visible = false;
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(RepoSourceTB.Text) || string.IsNullOrWhiteSpace(RepoSourceTB.Text))
            {
                TagRepoStatusTB.Text = "Select directory to search for repositories.";
            }

            else
            {
                TagRepoStatusTB.Text = "0 repositories found."; 
                TagRepoData.All_Repos.Clear();

                foreach (DirectoryInfo dir in RepoIO.List_Directory(RepoSourceTB.Text))
                {
                    RepoCell temp = new RepoCell();
                    temp.RepoName = RepoIO.Repo_Name(dir);
                    temp.Checked = false;
                    temp.RepoDirInfo = dir;
                    temp.RepoControl = BlankLabel(temp.RepoName);

                    TagRepoData.All_Repos.Add(temp);
                    flowLayoutPanel1.Controls.Add(temp.RepoControl);

                    if (!numericUpDown1.Visible && TagRepoData.All_Repos.Count == 1)
                    {
                        numericUpDown1.Visible = true;
                        SearchResultsP.Visible = true;
                        SelectAllBT.Visible = true;
                        SelectNoneBT.Visible = true;
                    }
                }

                TagRepoStatusTB.Text = (TagRepoData.All_Repos.Count + " repositories found.");
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label tempLabel = sender as Label;

            tempLabel.Cursor = Cursors.Hand;
            tempLabel.BackColor = Color.Black;
            tempLabel.ForeColor = Color.White;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label tempLabel = sender as Label;

            if (!TagRepoMethods.Checked(sender))
            {
                tempLabel.Cursor = Cursors.Default;
                tempLabel.BackColor = Color.Transparent;
                tempLabel.ForeColor = Color.Black;
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            TagRepoMethods.Toggle_Selection(sender);
            TagRepoStatusTB.Text = (TagRepoData.Selected_Repos_Count + " repositories selected.");

            if (TagRepoData.Selected_Repos_Count > 0)
            {
                EditSelectedBT.Visible = true;
            }

            else
            {
                EditSelectedBT.Visible = false;
            }
        }

        private void TagRepoFRM_Load(object sender, EventArgs e)
        {
            TagRepoData.All_Repos = new List<RepoCell>();
            TagRepoData.Selected_Repos = new List<RepoCell>();
            TagRepoStatusTB.Text = "Select directory to search for repositories.";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Label lb in flowLayoutPanel1.Controls.OfType<Label>())
            {
                lb.Font = new Font(lb.Font.FontFamily, (float)numericUpDown1.Value, FontStyle.Regular);
                lb.Refresh();
            }
        }

        private void SelectAllBT_Click(object sender, EventArgs e)
        {
            foreach (Label lb in flowLayoutPanel1.Controls.OfType<Label>())
            {
                lb.BackColor = Color.Black;
                lb.ForeColor = Color.White;
                lb.Refresh();
            }

            TagRepoMethods.Select_All_Repos();

            TagRepoStatusTB.Text = (TagRepoData.All_Repos.Count + " repositories selected.");

            EditSelectedBT.Visible = true;
        }

        private void ClearAllBT_Click(object sender, EventArgs e)
        {
            foreach (Label lb in flowLayoutPanel1.Controls.OfType<Label>())
            {
                lb.BackColor = Color.Transparent;
                lb.ForeColor = Color.Black;
                lb.Refresh();
            }

            TagRepoMethods.Deselect_All_Repos();

            TagRepoStatusTB.Text = (TagRepoData.Selected_Repos_Count + " repositories selected.");

            EditSelectedBT.Visible = false;
        }

        private void EditSelectedBT_Click(object sender, EventArgs e)
        {
            if (TagRepoMethods.Populate_Selected_List())
            {
                MainViewP.Visible = false;
                EditViewP.Visible = true;

                RepositoriesLV.Items.Clear();

                TagRepoData.Repo_Tags = new Dictionary<string, List<string>>();

                // Populate dictionary with tags from tag file
                int i = 1;

                foreach (RepoCell rc in TagRepoData.Selected_Repos)
                {
                    List<string> temp = new List<string>()
                    {
                        "test " + i,
                        "test"
                    };

                    TagRepoData.Repo_Tags.Add(rc.RepoName, temp);

                    ListViewItem lvi = new ListViewItem
                    {
                        Name = rc.RepoName,
                        Text = rc.RepoName
                    };

                    RepositoriesLV.Items.Add(lvi);
                    i++;
                }

                TagRepoData.CurrentView = EditViewP;
                EditViewP.Refresh();
            }
        }

        private void EditSelectedBT_MouseEnter(object sender, EventArgs e)
        {
            EditSelectedBT.BackgroundImage = Properties.Resources.Edit_Icon_Hover;
            Cursor = Cursors.Hand;
        }

        private void EditSelectedBT_MouseLeave(object sender, EventArgs e)
        {
            EditSelectedBT.BackgroundImage = Properties.Resources.Edit_Icon;
            Cursor = Cursors.Default;
        }

        private void SelectAllBT_MouseEnter(object sender, EventArgs e)
        {
            SelectAllBT.BackgroundImage = Properties.Resources.Select_All_Icon_Hover;
            Cursor = Cursors.Hand;
        }

        private void SelectAllBT_MouseLeave(object sender, EventArgs e)
        {
            SelectAllBT.BackgroundImage = Properties.Resources.Select_All_Icon;
            Cursor = Cursors.Default;
        }

        private void SelectNoneBT_MouseEnter(object sender, EventArgs e)
        {
            SelectNoneBT.BackgroundImage = Properties.Resources.Select_None_Icon_Hover;
            Cursor = Cursors.Hand;
        }

        private void SelectNoneBT_MouseLeave(object sender, EventArgs e)
        {
            SelectNoneBT.BackgroundImage = Properties.Resources.Select_None_Icon;
            Cursor = Cursors.Default;
        }

        private void MainViewBT_Click(object sender, EventArgs e)
        {
            EditViewP.Visible = false;
            MainViewP.Visible = true;
            TagRepoData.CurrentView = MainViewP;
        }

        private void MainViewBT_MouseEnter(object sender, EventArgs e)
        {
            MainViewBT.BackgroundImage = Properties.Resources.Back_Icon_Hover;
        }

        private void MainViewBT_MouseLeave(object sender, EventArgs e)
        {
            MainViewBT.BackgroundImage = Properties.Resources.Back_Icon;
        }

        private void Control1BT_Click(object sender, EventArgs e)
        {
            if (TagsLV.Items.Count == 0 || TagsLV.SelectedItems.Count == 0)
            {
                foreach (ListViewItem lvi in RepositoriesLV.SelectedItems)
                {
                    MessageBox.Show("Add tag to " + lvi.Name);

                }
            }

            else if (TagsLV.SelectedItems.Count > 0)
            {
                string tagName = "";
                string repoName = "";

                foreach (ListViewItem lvi in TagsLV.SelectedItems)
                {
                    tagName = lvi.Name;
                }

                foreach (ListViewItem lvi in RepositoriesLV.SelectedItems)
                {
                    repoName = lvi.Name;
                }


                TagRepoData.Repo_Tags[repoName].Remove(tagName);
                TagsLV.Refresh();
            }
        }

        private void EditViewP_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void RepositoriesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            TagsLV.Items.Clear();
            Control1BT.BackgroundImage = Properties.Resources.Add_Tag_Icon;

            RepoCell tempCell = null;

            foreach (ListViewItem lvi in RepositoriesLV.SelectedItems)
            {
                tempCell = TagRepoMethods.Find_Repo_Cell(lvi.Name);
            }

            if (tempCell != null)
            {
                foreach (string tag in TagRepoData.Repo_Tags[tempCell.RepoName])
                {
                    ListViewItem lvi = new ListViewItem
                    {
                        Name = tag,
                        Text = tag
                    };

                    TagsLV.Items.Add(lvi);
                }
            }
        }

        private void TagsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TagsLV.SelectedItems.Count > 0)
            {
                Control1BT.BackgroundImage = Properties.Resources.Delete_Tag_Icon;
            }

            else
            {
                Control1BT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            }
        }

        private void Control1BT_MouseEnter(object sender, EventArgs e)
        {
            if (TagsLV.Items.Count == 0 || TagsLV.SelectedItems.Count == 0)
            {
                Control1BT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
            }

            else if (TagsLV.SelectedItems.Count > 0)
            {
                Control1BT.BackgroundImage = Properties.Resources.Delete_Tag_Icon_Hover;
            }
        }

        private void Control1BT_MouseLeave(object sender, EventArgs e)
        {
            if (TagsLV.Items.Count == 0 || TagsLV.SelectedItems.Count == 0)
            {
                Control1BT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
            }

            else if (TagsLV.SelectedItems.Count > 0)
            {
                Control1BT.BackgroundImage = Properties.Resources.Delete_Tag_Icon;
            }
        }
    }
}
