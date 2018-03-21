namespace GITRepoManager
{
    partial class NoteEditorFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotesLV = new System.Windows.Forms.ListView();
            this.NoteTitleCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoteBodyTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteTitleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveChangesBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DeleteNoteBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.AddNoteBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SuspendLayout();
            // 
            // NotesLV
            // 
            this.NotesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoteTitleCH});
            this.NotesLV.FullRowSelect = true;
            this.NotesLV.GridLines = true;
            this.NotesLV.Location = new System.Drawing.Point(13, 46);
            this.NotesLV.MultiSelect = false;
            this.NotesLV.Name = "NotesLV";
            this.NotesLV.Size = new System.Drawing.Size(221, 332);
            this.NotesLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.NotesLV.TabIndex = 0;
            this.NotesLV.UseCompatibleStateImageBehavior = false;
            this.NotesLV.View = System.Windows.Forms.View.Details;
            this.NotesLV.SelectedIndexChanged += new System.EventHandler(this.NotesLV_SelectedIndexChanged);
            this.NotesLV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotesLV_MouseUp);
            // 
            // NoteTitleCH
            // 
            this.NoteTitleCH.Text = "Title";
            this.NoteTitleCH.Width = 217;
            // 
            // NoteBodyTB
            // 
            this.NoteBodyTB.Enabled = false;
            this.NoteBodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBodyTB.Location = new System.Drawing.Point(260, 127);
            this.NoteBodyTB.Name = "NoteBodyTB";
            this.NoteBodyTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NoteBodyTB.Size = new System.Drawing.Size(507, 211);
            this.NoteBodyTB.TabIndex = 7;
            this.NoteBodyTB.Text = "";
            this.NoteBodyTB.TextChanged += new System.EventHandler(this.NoteBodyTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Body";
            // 
            // NoteTitleTB
            // 
            this.NoteTitleTB.AcceptsReturn = true;
            this.NoteTitleTB.Enabled = false;
            this.NoteTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTitleTB.Location = new System.Drawing.Point(260, 69);
            this.NoteTitleTB.Name = "NoteTitleTB";
            this.NoteTitleTB.Size = new System.Drawing.Size(357, 24);
            this.NoteTitleTB.TabIndex = 5;
            this.NoteTitleTB.Click += new System.EventHandler(this.NoteTitleTB_Click);
            this.NoteTitleTB.TextChanged += new System.EventHandler(this.NoteTitleTB_TextChanged);
            this.NoteTitleTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteTitleTB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "* Duplicate Titles Are Not Allowed";
            // 
            // SaveChangesBT
            // 
            this.SaveChangesBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveChangesBT.BackColor = System.Drawing.Color.Transparent;
            this.SaveChangesBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Save_Settings_Icon;
            this.SaveChangesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveChangesBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveChangesBT.FlatAppearance.BorderSize = 0;
            this.SaveChangesBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveChangesBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveChangesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesBT.Location = new System.Drawing.Point(731, 344);
            this.SaveChangesBT.Name = "SaveChangesBT";
            this.SaveChangesBT.Size = new System.Drawing.Size(35, 35);
            this.SaveChangesBT.TabIndex = 30;
            this.SaveChangesBT.UseVisualStyleBackColor = false;
            this.SaveChangesBT.Click += new System.EventHandler(this.SaveChangesBT_Click);
            this.SaveChangesBT.MouseEnter += new System.EventHandler(this.SaveChangesBT_MouseEnter);
            this.SaveChangesBT.MouseLeave += new System.EventHandler(this.SaveChangesBT_MouseLeave);
            // 
            // DeleteNoteBT
            // 
            this.DeleteNoteBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteNoteBT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteNoteBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Delete_Tag_Icon;
            this.DeleteNoteBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteNoteBT.FlatAppearance.BorderSize = 0;
            this.DeleteNoteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteNoteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteNoteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteBT.Location = new System.Drawing.Point(301, 344);
            this.DeleteNoteBT.Name = "DeleteNoteBT";
            this.DeleteNoteBT.Size = new System.Drawing.Size(35, 35);
            this.DeleteNoteBT.TabIndex = 29;
            this.DeleteNoteBT.UseVisualStyleBackColor = false;
            this.DeleteNoteBT.Visible = false;
            this.DeleteNoteBT.Click += new System.EventHandler(this.DeleteNoteBT_Click);
            this.DeleteNoteBT.MouseEnter += new System.EventHandler(this.DeleteNoteBT_MouseEnter);
            this.DeleteNoteBT.MouseLeave += new System.EventHandler(this.DeleteNoteBT_MouseLeave);
            // 
            // AddNoteBT
            // 
            this.AddNoteBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNoteBT.BackColor = System.Drawing.Color.Transparent;
            this.AddNoteBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Add_Tag_Icon;
            this.AddNoteBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddNoteBT.FlatAppearance.BorderSize = 0;
            this.AddNoteBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddNoteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddNoteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteBT.Location = new System.Drawing.Point(260, 344);
            this.AddNoteBT.Name = "AddNoteBT";
            this.AddNoteBT.Size = new System.Drawing.Size(35, 35);
            this.AddNoteBT.TabIndex = 28;
            this.AddNoteBT.UseVisualStyleBackColor = false;
            this.AddNoteBT.Click += new System.EventHandler(this.AddNoteBT_Click);
            this.AddNoteBT.MouseEnter += new System.EventHandler(this.AddNoteBT_MouseEnter);
            this.AddNoteBT.MouseLeave += new System.EventHandler(this.AddNoteBT_MouseLeave);
            // 
            // NoteEditorFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveChangesBT);
            this.Controls.Add(this.DeleteNoteBT);
            this.Controls.Add(this.AddNoteBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoteBodyTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteTitleTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotesLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NoteEditorFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Note Editor";
            this.Load += new System.EventHandler(this.NoteEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView NotesLV;
        private System.Windows.Forms.RichTextBox NoteBodyTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoteTitleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private NoFocusSelectionRectangleButton AddNoteBT;
        private NoFocusSelectionRectangleButton DeleteNoteBT;
        private NoFocusSelectionRectangleButton SaveChangesBT;
        private System.Windows.Forms.ColumnHeader NoteTitleCH;
        private System.Windows.Forms.Label label4;
    }
}