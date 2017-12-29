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
    public partial class TagRepoFRM : Form
    {
        public static string[] butts = { "button1", "button2", "button3", "button4", "button5",
                                         "button6", "button7", "button8", "button9", "button10",
                                         "button11", "button12", "button13", "button14", "button15",
                                         "button16", "button17", "button18", "button19", "button20",
                                         "button21", "button22", "button23", "button24", "button25",
                                         "button26", "button27", "button28", "button29", "button30",
                                         "button31", "button32", "button33", "button34", "button35",
                                         "button36", "button37", "button38", "button39", "button40",
                                         "button41", "button42", "button43", "button44", "button45",
                                         "button46", "button47", "button48", "button49", "button50",
                                         "button51", "button52", "button53", "button54", "button55",
                                         "button56", "button57", "button58", "button59", "button60",
                                         "button61", "button62", "button63", "button64", "button65",
                                         "button66", "button67", "button68", "button69", "button70",
                                         "button71", "button72", "button73", "button74", "button75",
                                         "button76", "button77", "button78", "button79", "button80",
                                         "button81", "button82", "button83", "button84", "button85",
                                         "button86", "button87", "button88", "button89", "button90",
                                         "button91", "button92", "button93", "button94", "button95",
                                         "button96", "button97", "button98", "button99", "button100"
                                       };

        public TagRepoFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string temp in butts)
            {
                flowLayoutPanel1.Controls.Add(BlankButton(temp));
            }
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
    }
}
