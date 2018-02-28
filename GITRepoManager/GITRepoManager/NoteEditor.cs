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
    public partial class NoteEditor : Form
    {
        public static ListViewItem CurrentNote { get; set; }
        public static ListViewItem Previous_Note { get; set; }
        public static bool FirstSelection { get; set; }
        public static bool IncrementPrevious { get; set; }

        public static System.Drawing.Font BoldFont = null;
        public static System.Drawing.Font RegularFont = null;


        public NoteEditor()
        {
            InitializeComponent();
        }

        #region Events

        #region Form

        #region Load

        private void NoteEditor_Load(object sender, EventArgs e)
        {
            FirstSelection = true;

            NotesLV.Items.Clear();

            if (ManagerData.Selected_Repo_Copy.Notes.Count > 0)
            {
                foreach (string title in ManagerData.Selected_Repo_Copy.Notes.Keys)
                {
                    ListViewItem temp = new ListViewItem()
                    {
                        Name = title,
                        Text = title,
                    };

                    NotesLV.Items.Add(temp);
                }

                //NotesLV.Items[0].Selected = true;
                NotesLV.Select();

                BoldFont = new System.Drawing.Font(NotesLV.Items[0].Font.FontFamily, NotesLV.Items[0].Font.Size, FontStyle.Bold);
                RegularFont = NotesLV.Items[0].Font;

                NotesLV.Items[0].Selected = true;

                CurrentNote = NotesLV.SelectedItems[0];
                Previous_Note = CurrentNote;

                CurrentNote.Font = BoldFont;
            }

            else
            {
                ListViewItem temp = new ListViewItem();
                BoldFont = new System.Drawing.Font(temp.Font.FontFamily, temp.Font.Size, FontStyle.Bold);
                RegularFont = temp.Font;
            }
        }

        #endregion

        #endregion


        #region List View

        private void NotesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Previous_Note = CurrentNote;
                CurrentNote = NotesLV.SelectedItems[0];

                Previous_Note.Font = RegularFont;
                CurrentNote.Font = BoldFont;
            }

            catch
            {
            }

            NoteTitleTB.Text = CurrentNote.Text;
            //NoteBodyTB.Text = ManagerData.Selected_Repo.Notes[CurrentNote.Name];

            NotesLV.Sort();
        }

        #endregion


        #region Mouse

        #region Click

        private void AddNoteBT_Click(object sender, EventArgs e)
        {
            bool cont = true;
            // If a current note is selected, save it's changes
            if (NotesLV.SelectedItems.Count > 0)
            {
                if (NotesLV.Items.Count > 1)
                {
                    if (NoteTitleTB.Text != NotesLV.SelectedItems[0].Text)
                    {
                        if (!Duplicate_Note(NoteTitleTB.Text))
                        {
                            NotesLV.Sorting = SortOrder.None;
                            NotesLV.SelectedItems[0].Name = NoteTitleTB.Text;
                            NotesLV.SelectedItems[0].Text = NoteTitleTB.Text;
                            NotesLV.Sorting = SortOrder.Ascending;
                            NotesLV.Sort();
                        }

                        else
                        {
                            MessageBox.Show("Duplicate note titles are not allowed, either change this note's title or delete it to continue.", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NoteTitleTB.Focus();
                            cont = false;
                        }
                    }
                }
            }

            if(cont)
            {
                if (!Duplicate_Note("blanknote"))
                {
                    ListViewItem temp = new ListViewItem()
                    {
                        Name = "blanknote",
                        Text = "blanknote",
                        Selected = true,
                        Font = BoldFont
                    };

                    NotesLV.Sorting = SortOrder.None;
                    NotesLV.Items.Insert(0, temp);
                    NotesLV.Select();
                    NoteTitleTB.Enabled = true;
                    NoteBodyTB.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Duplicate notes are not allowed, please rename \"blanknote\".", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NotesLV.Select();
                    NoteTitleTB.Enabled = true;
                    NoteBodyTB.Enabled = true;
                }
            }
        }






        private void SaveChangesBT_Click(object sender, EventArgs e)
        {

            // Write the changes to config file
            Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);
        }






        private void DeleteNoteBT_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Enter

        private void AddNoteBT_MouseEnter(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
        }

        private void DeleteNoteBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteNoteBT.BackgroundImage = Properties.Resources.Delete_Tag_Icon_Hover;
        }

        private void SaveChangesBT_MouseEnter(object sender, EventArgs e)
        {
            SaveChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
        }

        #endregion


        #region Leave

        private void AddNoteBT_MouseLeave(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
        }
        





        private void DeleteNoteBT_MouseLeave(object sender, EventArgs e)
        {
            DeleteNoteBT.BackgroundImage = Properties.Resources.Delete_Tag_Icon;
        }






        private void SaveChangesBT_MouseLeave(object sender, EventArgs e)
        {
            SaveChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;
        }

        #endregion

        #endregion


        #region Text Box

        #region Text Changed

        private void NoteTitleTB_TextChanged(object sender, EventArgs e)
        {

        }





        private void NoteBodyTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        #endregion


        #region Keys

        #region Down

        private void NoteTitleTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!Duplicate_Note(NoteTitleTB.Text))
                {
                    NotesLV.Sorting = SortOrder.None;

                    NotesLV.SelectedItems[0].Name = NoteTitleTB.Text;
                    NotesLV.SelectedItems[0].Text = NoteTitleTB.Text;

                    NotesLV.Sorting = SortOrder.Ascending;

                    NotesLV.Sort();
                }

                else
                {
                    MessageBox.Show("Duplicate note titles are not allowed, please edit" + NoteTitleTB.Text + "'s body instead.", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NoteTitleTB.Focus();

                }

                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #endregion

        #endregion


        #region Methods

        #region Determine if a duplicate node exists

        public bool Duplicate_Note(string title)
        {
            title = title.ToLower();

            foreach (ListViewItem temp in NotesLV.Items)
            {
                if (temp.Name.ToLower() == title || temp.Text.ToLower() == title)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Get the index of the blanknote in the list view

        public int Get_Blank_Note_Index()
        {
            foreach (ListViewItem lvi in NotesLV.Items)
            {
                if (lvi.Name == "blanknote" && lvi.Text == "blanknote")
                {
                    return lvi.Index;
                }
            }

            return -1;
        }

        #endregion

        #endregion

    }
}
