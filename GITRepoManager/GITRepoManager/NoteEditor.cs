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
        public NoteEditor()
        {
            InitializeComponent();
        }

        private void NoteEditor_Load(object sender, EventArgs e)
        {
            NotesLV.Items.Clear();
            foreach (string title in ManagerData.Selected_Repo.Notes.Keys)
            {
                ListViewItem temp = new ListViewItem()
                {
                    Name = title,
                    Text = title
                };

                NotesLV.Items.Add(temp);
            }
        }
    }
}
