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
            int repoCount = 0;
            numericUpDown1.Visible = false;
            SearchResultsP.Visible = false;
            SelectAllBT.Visible = false;
            ClearAllBT.Visible = false;
            flowLayoutPanel1.Controls.Clear();

            if (string.IsNullOrEmpty(RepoSourceTB.Text) || string.IsNullOrWhiteSpace(RepoSourceTB.Text))
            {
                TagRepoStatusTB.Text = "Select directory to search for repositories.";
            }

            else
            {
                TagRepoStatusTB.Text = "0 repositories found.";

                foreach (DirectoryInfo dir in RepoIO.List_Directory(RepoSourceTB.Text))
                {
                    RepoCell temp = new RepoCell();
                    temp.RepoName = RepoIO.Repo_Name(dir);
                    temp.Checked = false;
                    temp.RepoDirInfo = dir;
                    temp.RepoControl = BlankLabel(temp.RepoName);
                    TagRepoData.All_Repos.Add(temp);
                    flowLayoutPanel1.Controls.Add(temp.RepoControl);
                    repoCount++;

                    if (!numericUpDown1.Visible && repoCount == 1)
                    {
                        numericUpDown1.Visible = true;
                        SearchResultsP.Visible = true;
                        SelectAllBT.Visible = true;
                        ClearAllBT.Visible = true;
                    }
                }

                TagRepoStatusTB.Text = (repoCount + " repositories found.");
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label tempLabel = sender as Label;
            RepoCell tempCell = null;
            tempLabel.Cursor = Cursors.Hand;


            foreach (RepoCell cell in TagRepoData.All_Repos)
            {
                if (cell.RepoControl == tempLabel)
                {
                    tempCell = cell;
                    break;
                }
            }

            if (tempCell != null)
            {
                if (!tempCell.Checked)
                {
                    tempLabel.BackColor = Color.Black;
                    tempLabel.ForeColor = Color.White;
                }
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label tempLabel = sender as Label;
            RepoCell tempCell = null;

            foreach (RepoCell cell in TagRepoData.All_Repos)
            {
                if (cell.RepoControl == tempLabel)
                {
                    tempCell = cell;
                    break;
                }
            }

            if (tempCell != null)
            {
                if (!tempCell.Checked)
                {
                    tempLabel.Cursor = Cursors.Default;
                    tempLabel.BackColor = Color.Transparent;
                    tempLabel.ForeColor = Color.Black;
                }
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label tempLabel = sender as Label;
            RepoCell tempCell = null;

            foreach(RepoCell cell in TagRepoData.All_Repos)
            {
                if(cell.RepoControl == tempLabel)
                {
                    tempCell = cell;
                    break;
                }
            }

            if(tempCell != null)
            {
                if(tempCell.Checked)
                {
                    tempCell.Checked = false;
                    tempLabel.BackColor = Color.Transparent;
                    tempLabel.ForeColor = Color.Black;
                    TagRepoData.Selected_Repos.Remove(tempCell);
                    TagRepoStatusTB.Text = (TagRepoData.Selected_Repos.Count + " repositories selected.");
                }

                else
                {
                    tempCell.Checked = true;
                    tempLabel.BackColor = Color.Black;
                    tempLabel.ForeColor = Color.White;
                    TagRepoData.Selected_Repos.Add(tempCell);
                    TagRepoStatusTB.Text = (TagRepoData.Selected_Repos.Count + " repositories selected.");
                }
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

            foreach(RepoCell rc in TagRepoData.All_Repos)
            {
                rc.Checked = true;
            }

            TagRepoData.Selected_Repos = TagRepoData.All_Repos;

            TagRepoStatusTB.Text = (TagRepoData.Selected_Repos.Count + " repositories selected.");
        }

        private void ClearAllBT_Click(object sender, EventArgs e)
        {
            foreach (Label lb in flowLayoutPanel1.Controls.OfType<Label>())
            {
                lb.BackColor = Color.Transparent;
                lb.ForeColor = Color.Black;
                lb.Refresh();
            }

            TagRepoData.Selected_Repos.Clear();

            foreach (RepoCell rc in TagRepoData.All_Repos)
            {
                rc.Checked = false;
            }

            TagRepoStatusTB.Text = (TagRepoData.Selected_Repos.Count + " repositories selected.");
        }
    }
}
