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
        private bool Deleting_Item { get; set; }
        private static int Current_Count { get; set; }
        private static int Previous_Count { get; set; }

        public static Dictionary<string, string> Note_Changes { get; set; }

        private Variable_Change_Event Selection_Changed;

        public static System.Drawing.Font BoldFont = null;
        public static System.Drawing.Font RegularFont = null;

        private bool _lock;


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
            _lock = false;
            Deleting_Item = false;
            Current_Count = 1;
            Previous_Count = 1;

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

                NoteTitleTB.Text = Current_Note.Name;
                NoteBodyTB.Text = Note_Changes[Current_Note.Name];
                NoteTitleTB.Enabled = true;
                NoteBodyTB.Enabled = true;

                DeleteNoteBT.Visible = true;
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

        #region Selected Index Changed

        private void NotesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Deleting_Item)
            {
            }

            else
            {
                Previous_Count = Current_Count;
                Current_Count = NotesLV.SelectedItems.Count;

                Selection_Changed.Selection_Changed = true;
            }
        }

        #endregion


        #region Selection Changed Event Handler

        private void Selection_Changed_Selection_Changed_EventHandler(object sender, EventArgs e)
        {
            if (Selection_Changed.Selection_Changed)
            {
                if (_lock)
                {
                }

                else if (!_lock)
                {
                    _lock = true;

                    // Going from selected to deselected
                    // Happens when selecting another item after an already selected one or selecting nothing after a selected item
                    if (Current_Count == 0 && Previous_Count == 1)
                    {
                        DeleteNoteBT.Visible = false;

                        if (!string.IsNullOrEmpty(NoteTitleTB.Text) && !string.IsNullOrWhiteSpace(NoteTitleTB.Text))
                        {
                            if (NoteTitleTB.Text != Current_Note.Name)
                            {
                                if (!Duplicate_Note(NoteTitleTB.Text))
                                {
                                    Note_Changes.Remove(Current_Note.Name);
                                    Note_Changes.Add(NoteTitleTB.Text, NoteBodyTB.Text);
                                    Current_Note.Name = NoteTitleTB.Text;
                                    Current_Note.Text = NoteTitleTB.Text;
                                }

                                else
                                {
                                    MessageBox.Show("Duplicate note titles are not allowed.", "Duplicate Note Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Note_Changes[Current_Note.Name] = NoteBodyTB.Text;
                                }
                            }

                            else
                            {
                                Note_Changes[Current_Note.Name] = NoteBodyTB.Text;
                            }
                        }

                        // Cant differentiate easily so just assume a safe general case of the following
                        // Set the previous to current and the current to null
                        if (Previous_Note != null)
                        {
                            Previous_Note.Font = RegularFont;
                        }

                        if (Current_Note != null)
                        {
                            Current_Note.Font = RegularFont;
                        }

                        Previous_Note = Current_Note;
                        Current_Note = null;

                        NoteTitleTB.Clear();
                        NoteTitleTB.Enabled = false;
                        NoteBodyTB.Clear();
                        NoteBodyTB.Enabled = false;
                    }

                    // Going from deselected to selected
                    // Happens when selecting another item after the last item is deselected or going from nothing to selecting an item.
                    else if (Current_Count == 1 && Previous_Count == 0)
                    {
                        DeleteNoteBT.Visible = true;

                        // Cant differentiate easily so just assume a safe general case of the following
                        // Set the previous to null and the current to the selected item

                        if (Previous_Note != null)
                        {
                            Previous_Note.Font = RegularFont;
                        }

                        Previous_Note = null;

                        Current_Note = NotesLV.SelectedItems[0];
                        Current_Note.Font = BoldFont;

                        NoteTitleTB.Text = Current_Note.Name;
                        NoteTitleTB.Enabled = true;

                        try
                        {
                            NoteBodyTB.Text = Note_Changes[Current_Note.Name];
                        }
                        catch
                        {
                        }

                        NoteBodyTB.Enabled = true;
                    }

                    _lock = false;
                }
            }
        }

        #endregion Selection Changed Event Handler

        #endregion List View


        #region Mouse

        #region Click

        private void AddNoteBT_Click(object sender, EventArgs e)
        {
            ListViewItem temp = new ListViewItem()
            {
                Name = "blanknote",
                Text = "blanknote"
            };

            if (NotesLV.Items.Contains(temp))
            {
                MessageBox.Show("A blank note already exists, please edit this note before adding another.", "Duplicate Blank Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotesLV.SelectedItems.Clear();
                NotesLV.Items[NotesLV.Items.IndexOf(temp)].Selected = true;
                NotesLV.Select();
                NoteTitleTB.Focus();
            }

            else
            {
                NotesLV.Sorting = SortOrder.None;
                NotesLV.Items.Insert(0, temp);
                NotesLV.SelectedItems.Clear();
                NotesLV.Items[0].Selected = true;
                NotesLV.Select();
                NoteTitleTB.Focus();

                if (NotesLV.Items.Count == 1)
                {
                    Current_Note = NotesLV.SelectedItems[0];
                    Current_Note.Font = BoldFont;
                    NoteTitleTB.Enabled = true;
                    NoteBodyTB.Enabled = true;

                    NoteTitleTB.Text = Current_Note.Name;
                    NoteBodyTB.Text = string.Empty;
                    NotesLV.Select();
                }
            }
        }






        private void SaveChangesBT_Click(object sender, EventArgs e)
        {
            if (NoteTitleTB.Text != Current_Note.Name)
            {
                if (!string.IsNullOrEmpty(NoteTitleTB.Text) && !string.IsNullOrWhiteSpace(NoteTitleTB.Text))
                {
                    if (!Duplicate_Note(NoteTitleTB.Text))
                    {
                        Deleting_Item = true;

                        Note_Changes.Remove(Current_Note.Name);
                        Note_Changes.Add(NoteTitleTB.Text, NoteBodyTB.Text);

                        NotesLV.Sorting = SortOrder.None;
                        Current_Note.Name = NoteTitleTB.Text;
                        Current_Note.Text = NoteTitleTB.Text;
                        NotesLV.Sorting = SortOrder.Ascending;
                        NotesLV.Sort();

                        Deleting_Item = false;
                    }

                    else
                    {
                        MessageBox.Show("Duplicate note titles are not allowed, saving as previous title", "Duplicate Note Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NoteTitleTB.Text = Current_Note.Name;
                        Note_Changes[Current_Note.Name] = NoteBodyTB.Text;
                    }
                }
            }

            else
            {
                Note_Changes[Current_Note.Name] = NoteBodyTB.Text;
            }

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
            if (Current_Note != null)
            {
                DialogResult delete;

                delete = MessageBox.Show("Are you sure you want to delete \"" + Current_Note.Name + "\"?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    Deleting_Item = true;
                    Note_Changes.Remove(Current_Note.Name);
                    NotesLV.Items.Remove(Current_Note);
                    Deleting_Item = false;

                    NotesLV.SelectedItems.Clear();
                    NotesLV.Items[0].Selected = true;
                    NotesLV.Select();

                    Current_Note = NotesLV.SelectedItems[0];
                    Previous_Note = null;

                    Current_Note.Font = BoldFont;
                    NoteTitleTB.Text = Current_Note.Name;
                    NoteBodyTB.Text = Note_Changes[Current_Note.Name];
                }
            }
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
            //NoteTitleTB.Focus();
            //NoteTitleTB.SelectAll();
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
                if (!string.IsNullOrEmpty(NoteTitleTB.Text) && !string.IsNullOrWhiteSpace(NoteTitleTB.Text))
                {
                    if (NoteTitleTB.Text != Current_Note.Name)
                    {
                        if (!Duplicate_Note(NoteTitleTB.Text))
                        {
                            NotesLV.Sorting = SortOrder.None;

                            Note_Changes.Remove(Current_Note.Name);
                            Note_Changes.Add(NoteTitleTB.Text, NoteBodyTB.Text);

                            Current_Note.Name = NoteTitleTB.Text;
                            Current_Note.Text = NoteTitleTB.Text;

                            NotesLV.Sorting = SortOrder.Ascending;
                            NotesLV.Sort();
                        }

                        else
                        {
                            MessageBox.Show("Duplicate note titles are not allowed.", "Duplicate Note Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NoteTitleTB.Text = Current_Note.Name;
                            NoteTitleTB.Focus();
                            NoteTitleTB.SelectAll();
                        }
                    }
                }

                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #endregion

        #endregion Events

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

        #endregion Methods

        private void NoteTitleTB_Click(object sender, EventArgs e)
        {
            NoteTitleTB.SelectAll();
        }
    }
}