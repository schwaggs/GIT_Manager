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
    public partial class NoteEditor : Form
    {
        public static ListViewItem Current_Note { get; set; }
        public static ListViewItem Previous_Note { get; set; }

        public static Dictionary<string, string> Note_Changes { get; set; }

        private Variable_Change_Event Selection_Changed;

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
            Note_Changes = new Dictionary<string, string>();

            Selection_Changed = new Variable_Change_Event(false);
            Selection_Changed.Selection_Changed_EventHandler += Selection_Changed_Selection_Changed_EventHandler;

            foreach (KeyValuePair<string, string> kvp in ManagerData.Selected_Repo.Notes)
            {
                Note_Changes.Add(kvp.Key, kvp.Value);
            }

            NotesLV.Items.Clear();

            if (Note_Changes.Count > 0)
            {
                foreach (string title in Note_Changes.Keys)
                {
                    ListViewItem temp = new ListViewItem()
                    {
                        Name = title,
                        Text = title,
                    };

                    NotesLV.Items.Add(temp);
                }
                NotesLV.Select();

                BoldFont = new System.Drawing.Font(NotesLV.Items[0].Font.FontFamily, NotesLV.Items[0].Font.Size, FontStyle.Bold);
                RegularFont = NotesLV.Items[0].Font;

                NotesLV.Items[0].Selected = true;

                Current_Note = NotesLV.SelectedItems[0];
                Previous_Note = Current_Note;

                Current_Note.Font = BoldFont;
            }

            else
            {
                ListViewItem temp = new ListViewItem();
                BoldFont = new System.Drawing.Font(temp.Font.FontFamily, temp.Font.Size, FontStyle.Bold);
                RegularFont = temp.Font;
            }
        }

        private void Selection_Changed_Selection_Changed_EventHandler(object sender, EventArgs e)
        {
            if (Selection_Changed.Selection_Changed && NotesLV.SelectedItems.Count > 0)
            {
                Selection_Changed.Selection_Changed = false;
                MessageBox.Show("changed");
            }
        }

        #endregion

        #endregion


        #region List View

        private void NotesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection_Changed.Selection_Changed = true;
        }

        #endregion


        #region Mouse

        #region Click

        private void AddNoteBT_Click(object sender, EventArgs e)
        {
            
        }






        private void SaveChangesBT_Click(object sender, EventArgs e)
        {
            ManagerData.Selected_Repo.Notes.Clear();

            foreach (KeyValuePair<string, string> kvp in Note_Changes)
            {
                ManagerData.Selected_Repo.Notes.Add(kvp.Key, kvp.Value);
            }

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

        #region Up

        private void NotesLV_MouseUp(object sender, MouseEventArgs e)
        {
            NoteTitleTB.Focus();
            NoteTitleTB.SelectAll();
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
                if (!Store_Note())
                {
                    NotesLV.SelectedItems.Clear();
                    Current_Note.Selected = true;
                    NotesLV.Select();
                    NoteTitleTB.Text = Current_Note.Text;
                    NoteBodyTB.Text = Note_Changes[Current_Note.Text];

                    Duplicate_Message();

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

        #region Store Previous Note

        private bool Store_Note()
        {
            if (Current_Note == null)
            {
                return true;
            }

            // Previously selected note's title has been modified
            if (Current_Note.Text != NoteTitleTB.Text)
            {
                if (!Duplicate_Note(NoteTitleTB.Text))
                {
                    // Delete old entry in dictionary and add new
                    if (Note_Changes.Keys.Contains(Current_Note.Text))
                    {
                        Note_Changes.Remove(Current_Note.Text);
                    }

                    Note_Changes.Add(NoteTitleTB.Text, NoteBodyTB.Text);

                    // Modify list view
                    NotesLV.Sorting = SortOrder.None;
                    Current_Note.Name = NoteTitleTB.Text;
                    Current_Note.Text = NoteTitleTB.Text;
                    NotesLV.Sorting = SortOrder.Ascending;
                    NotesLV.Sort();

                    return true;
                }

                else
                {
                    return false;
                }
            }

            // No Change to title just store body
            else
            {
                Note_Changes[Current_Note.Text] = NoteBodyTB.Text;
                return true;
            }
        }

        #endregion

        private void Duplicate_Message()
        {
            string message = "Duplicate titles are not allowed, please edit the body of the duplicate note or change this notes title.";
            MessageBox.Show(message, "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
