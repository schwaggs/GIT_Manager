namespace GITRepoManager
{
    partial class NoteEditor
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNoteBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DeleteNoteBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SaveChangesBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SuspendLayout();
            // 
            // NotesLV
            // 
            this.NotesLV.FullRowSelect = true;
            this.NotesLV.GridLines = true;
            this.NotesLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.NotesLV.Location = new System.Drawing.Point(13, 46);
            this.NotesLV.MultiSelect = false;
            this.NotesLV.Name = "NotesLV";
            this.NotesLV.Size = new System.Drawing.Size(221, 332);
            this.NotesLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.NotesLV.TabIndex = 0;
            this.NotesLV.UseCompatibleStateImageBehavior = false;
            this.NotesLV.View = System.Windows.Forms.View.Details;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(260, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(507, 211);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(260, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 24);
            this.textBox1.TabIndex = 5;
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
            this.SaveChangesBT.Visible = false;
            // 
            // NoteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(778, 390);
            this.Controls.Add(this.SaveChangesBT);
            this.Controls.Add(this.DeleteNoteBT);
            this.Controls.Add(this.AddNoteBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotesLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NoteEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Note Editor";
            this.Load += new System.EventHandler(this.NoteEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView NotesLV;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private NoFocusSelectionRectangleButton AddNoteBT;
        private NoFocusSelectionRectangleButton DeleteNoteBT;
        private NoFocusSelectionRectangleButton SaveChangesBT;
    }
}