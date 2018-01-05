namespace GITRepoManager
{
    partial class LogViewFRM
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
            this.RepoLocationTB = new System.Windows.Forms.TextBox();
            this.RepoLocationGB = new System.Windows.Forms.GroupBox();
            this.LogResultsTB = new System.Windows.Forms.RichTextBox();
            this.BrowseRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoLocationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepoLocationTB
            // 
            this.RepoLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationTB.Location = new System.Drawing.Point(10, 29);
            this.RepoLocationTB.Name = "RepoLocationTB";
            this.RepoLocationTB.Size = new System.Drawing.Size(402, 29);
            this.RepoLocationTB.TabIndex = 0;
            this.RepoLocationTB.TextChanged += new System.EventHandler(this.RepoLocationTB_TextChanged);
            this.RepoLocationTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RepoLocationTB_KeyDown);
            // 
            // RepoLocationGB
            // 
            this.RepoLocationGB.Controls.Add(this.RepoLocationTB);
            this.RepoLocationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationGB.Location = new System.Drawing.Point(12, 12);
            this.RepoLocationGB.Name = "RepoLocationGB";
            this.RepoLocationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoLocationGB.TabIndex = 19;
            this.RepoLocationGB.TabStop = false;
            this.RepoLocationGB.Text = "Repository Location";
            // 
            // LogResultsTB
            // 
            this.LogResultsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogResultsTB.Location = new System.Drawing.Point(12, 91);
            this.LogResultsTB.Name = "LogResultsTB";
            this.LogResultsTB.ReadOnly = true;
            this.LogResultsTB.Size = new System.Drawing.Size(481, 250);
            this.LogResultsTB.TabIndex = 21;
            this.LogResultsTB.Text = "";
            this.LogResultsTB.Visible = false;
            // 
            // BrowseRepoBT
            // 
            this.BrowseRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseRepoBT.FlatAppearance.BorderSize = 0;
            this.BrowseRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseRepoBT.Location = new System.Drawing.Point(439, 22);
            this.BrowseRepoBT.Name = "BrowseRepoBT";
            this.BrowseRepoBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseRepoBT.TabIndex = 20;
            this.BrowseRepoBT.UseVisualStyleBackColor = false;
            this.BrowseRepoBT.Click += new System.EventHandler(this.BrowseRepoBT_Click);
            this.BrowseRepoBT.MouseEnter += new System.EventHandler(this.BrowseRepoBT_MouseEnter);
            this.BrowseRepoBT.MouseLeave += new System.EventHandler(this.BrowseRepoBT_MouseLeave);
            // 
            // LogViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(505, 353);
            this.Controls.Add(this.LogResultsTB);
            this.Controls.Add(this.BrowseRepoBT);
            this.Controls.Add(this.RepoLocationGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogViewFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogViewFRM";
            this.RepoLocationGB.ResumeLayout(false);
            this.RepoLocationGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NoFocusSelectionRectangleButton BrowseRepoBT;
        private System.Windows.Forms.TextBox RepoLocationTB;
        private System.Windows.Forms.GroupBox RepoLocationGB;
        private System.Windows.Forms.RichTextBox LogResultsTB;
    }
}