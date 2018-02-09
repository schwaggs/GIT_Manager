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
        public static string Previous_Note { get; set; }
        public static Dictionary<string, string> Note_Changes { get; set; }

        public NoteEditor()
        {
            InitializeComponent();
        }

        private void NoteEditor_Load(object sender, EventArgs e)
        {
            NotesLV.Items.Clear();
            Note_Changes = new Dictionary<string, string>();

            foreach (string title in ManagerData.Selected_Repo_Copy.Notes.Keys)
            {
                ListViewItem temp = new ListViewItem()
                {
                    Name = title,
                    Text = title,
                };

                NotesLV.Items.Add(temp);

                Note_Changes.Add(temp.Name, string.Empty);
            }
        }

        private void NotesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentNote = NotesLV.SelectedItems[0];
                Previous_Note = CurrentNote.Name;
                NoteTitleTB.Text = CurrentNote.Name;
                NoteBodyTB.Text = ManagerData.Selected_Repo.Notes[CurrentNote.Name];
            }
            catch
            {
            }

            if (NotesLV.SelectedItems.Count > 0)
            {
                DeleteNoteBT.Visible = true;
                NoteTitleTB.Enabled = true;
                NoteBodyTB.Enabled = true;
            }

            else
            {
                DeleteNoteBT.Visible = false;
                NoteTitleTB.Enabled = false;
                NoteBodyTB.Enabled = false;
            }
        }

        private void AddNoteBT_Click(object sender, EventArgs e)
        {
            CurrentNote = new ListViewItem
            {
                Name = "blanknote",
                Text = "blanknote"
            };

            if (!Duplicate_Note(CurrentNote.Name))
            {
                NotesLV.Sorting = SortOrder.None;
                NotesLV.Items.Insert(0, CurrentNote);
                NotesLV.Items[NotesLV.Items.IndexOf(CurrentNote)].Selected = true;
                NotesLV.Select();
                NoteTitleTB.Enabled = true;
                NoteBodyTB.Enabled = true;
                NoteBodyTB.Clear();
            }

            else
            {
                MessageBox.Show("Please edit the note called \"blanknote\" before adding a new note.", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
                    CurrentNote = NotesLV.Items[Get_Blank_Note_Index()];
                    CurrentNote.Selected = true;
                }

                catch
                {
                    MessageBox.Show("Error selecting the blank note item in the list, please select it manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                NotesLV.Select();
            }
        }

        private void NoteTitleTB_TextChanged(object sender, EventArgs e)
        {
            if (CurrentNote != null)
            {
                NoteTitleTB.Enabled = true;
                CurrentNote.Name = NoteTitleTB.Text;
                CurrentNote.Text = NoteTitleTB.Text;

                Note_Changes.Remove(Previous_Note);
                Note_Changes.Add(CurrentNote.Name, NoteBodyTB.Text);
            }

            else
            {
                NoteTitleTB.Enabled = false;
            }
        }
        
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

        private void NoteTitleTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NotesLV.Sorting = SortOrder.Ascending;
            }
        }

        private void SaveChangesBT_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> kvp in Note_Changes)
            {
                if (ManagerData.Selected_Repo.Notes.Keys.Contains(kvp.Key))
                {
                    ManagerData.Selected_Repo.Notes[kvp.Key] = kvp.Value;
                }

                else
                {
                    ManagerData.Selected_Repo.Notes.Add(kvp.Key, kvp.Value);
                }
            }

            Clear_Deleted_Notes();

            // Write the changes to config file
            Configuration.Helpers.Serialize_Condensed_All(Properties.Settings.Default.ConfigPath);
        }

        private void Clear_Deleted_Notes()
        {
            List<string> ToDelete = new List<string>();

            foreach (string key in ManagerData.Selected_Repo.Notes.Keys)
            {
                if (!Note_Changes.Keys.Contains(key))
                {
                    ToDelete.Add(key);
                }
            }

            foreach (string ToRemove in ToDelete)
            {
                ManagerData.Selected_Repo.Notes.Remove(ToRemove);
            }
        }

        private void NoteBodyTB_TextChanged(object sender, EventArgs e)
        {
            if (CurrentNote != null)
            {
                Note_Changes[CurrentNote.Name] = NoteBodyTB.Text;
            }
        }

        private void AddNoteBT_MouseEnter(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon_Hover;
        }

        private void AddNoteBT_MouseLeave(object sender, EventArgs e)
        {
            AddNoteBT.BackgroundImage = Properties.Resources.Add_Tag_Icon;
        }

        private void DeleteNoteBT_MouseEnter(object sender, EventArgs e)
        {
            DeleteNoteBT.BackgroundImage = Properties.Resources.Delete_Tag_Icon_Hover;
        }

        private void DeleteNoteBT_MouseLeave(object sender, EventArgs e)
        {
            DeleteNoteBT.BackgroundImage = Properties.Resources.Delete_Tag_Icon;
        }

        private void SaveChangesBT_MouseEnter(object sender, EventArgs e)
        {
            SaveChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon_Hover;
        }

        private void SaveChangesBT_MouseLeave(object sender, EventArgs e)
        {
            SaveChangesBT.BackgroundImage = Properties.Resources.Save_Settings_Icon;
        }

        private void DeleteNoteBT_Click(object sender, EventArgs e)
        {
            if (Note_Changes.Keys.Contains(CurrentNote.Name))
            {
                Note_Changes.Remove(CurrentNote.Name);
            }

            NotesLV.Items.Remove(CurrentNote);
            CurrentNote = null;
        }
    }
}
