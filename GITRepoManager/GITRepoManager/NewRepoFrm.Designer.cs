namespace GITRepoManager
{
    partial class NewRepoFRM
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
            this.RepoNameTB = new System.Windows.Forms.TextBox();
            this.RepoNameGB = new System.Windows.Forms.GroupBox();
            this.RepoLocationGB = new System.Windows.Forms.GroupBox();
            this.RepoLocationTB = new System.Windows.Forms.TextBox();
            this.OptionBareCB = new System.Windows.Forms.CheckBox();
            this.OptionReadmeCB = new System.Windows.Forms.CheckBox();
            this.BrowseLocationBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NewRepoDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RepoNameGB.SuspendLayout();
            this.RepoLocationGB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepoNameTB
            // 
            this.RepoNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoNameTB.Location = new System.Drawing.Point(10, 29);
            this.RepoNameTB.Multiline = true;
            this.RepoNameTB.Name = "RepoNameTB";
            this.RepoNameTB.Size = new System.Drawing.Size(402, 29);
            this.RepoNameTB.TabIndex = 0;
            // 
            // RepoNameGB
            // 
            this.RepoNameGB.Controls.Add(this.RepoNameTB);
            this.RepoNameGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoNameGB.Location = new System.Drawing.Point(12, 12);
            this.RepoNameGB.Name = "RepoNameGB";
            this.RepoNameGB.Size = new System.Drawing.Size(421, 73);
            this.RepoNameGB.TabIndex = 1;
            this.RepoNameGB.TabStop = false;
            this.RepoNameGB.Text = "Name";
            // 
            // RepoLocationGB
            // 
            this.RepoLocationGB.Controls.Add(this.RepoLocationTB);
            this.RepoLocationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationGB.Location = new System.Drawing.Point(12, 104);
            this.RepoLocationGB.Name = "RepoLocationGB";
            this.RepoLocationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoLocationGB.TabIndex = 2;
            this.RepoLocationGB.TabStop = false;
            this.RepoLocationGB.Text = "Location";
            // 
            // RepoLocationTB
            // 
            this.RepoLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationTB.Location = new System.Drawing.Point(10, 29);
            this.RepoLocationTB.Multiline = true;
            this.RepoLocationTB.Name = "RepoLocationTB";
            this.RepoLocationTB.Size = new System.Drawing.Size(402, 29);
            this.RepoLocationTB.TabIndex = 0;
            // 
            // OptionBareCB
            // 
            this.OptionBareCB.AutoSize = true;
            this.OptionBareCB.Location = new System.Drawing.Point(3, 3);
            this.OptionBareCB.Name = "OptionBareCB";
            this.OptionBareCB.Size = new System.Drawing.Size(48, 17);
            this.OptionBareCB.TabIndex = 3;
            this.OptionBareCB.Text = "Bare";
            this.OptionBareCB.UseVisualStyleBackColor = true;
            this.OptionBareCB.MouseEnter += new System.EventHandler(this.OptionBareCB_MouseEnter);
            this.OptionBareCB.MouseLeave += new System.EventHandler(this.OptionBareCB_MouseLeave);
            // 
            // OptionReadmeCB
            // 
            this.OptionReadmeCB.Location = new System.Drawing.Point(57, 3);
            this.OptionReadmeCB.Name = "OptionReadmeCB";
            this.OptionReadmeCB.Size = new System.Drawing.Size(66, 17);
            this.OptionReadmeCB.TabIndex = 4;
            this.OptionReadmeCB.Text = "Readme";
            this.OptionReadmeCB.UseVisualStyleBackColor = true;
            this.OptionReadmeCB.MouseEnter += new System.EventHandler(this.OptionReadmeCB_MouseEnter);
            this.OptionReadmeCB.MouseLeave += new System.EventHandler(this.OptionReadmeCB_MouseLeave);
            // 
            // BrowseLocationBT
            // 
            this.BrowseLocationBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseLocationBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseLocationBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseLocationBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseLocationBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseLocationBT.FlatAppearance.BorderSize = 0;
            this.BrowseLocationBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseLocationBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseLocationBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseLocationBT.Location = new System.Drawing.Point(439, 114);
            this.BrowseLocationBT.Name = "BrowseLocationBT";
            this.BrowseLocationBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseLocationBT.TabIndex = 12;
            this.BrowseLocationBT.UseVisualStyleBackColor = false;
            this.BrowseLocationBT.Click += new System.EventHandler(this.BrowseLocationBT_Click);
            this.BrowseLocationBT.MouseEnter += new System.EventHandler(this.BrowseLocationBT_MouseEnter);
            this.BrowseLocationBT.MouseLeave += new System.EventHandler(this.BrowseLocationBT_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRepoDescriptionSSLB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NewRepoDescriptionSSLB
            // 
            this.NewRepoDescriptionSSLB.Name = "NewRepoDescriptionSSLB";
            this.NewRepoDescriptionSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.OptionReadmeCB);
            this.panel1.Controls.Add(this.OptionBareCB);
            this.panel1.Location = new System.Drawing.Point(12, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 23);
            this.panel1.TabIndex = 14;
            // 
            // NewRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BrowseLocationBT);
            this.Controls.Add(this.RepoLocationGB);
            this.Controls.Add(this.RepoNameGB);
            this.MinimumSize = new System.Drawing.Size(527, 277);
            this.Name = "NewRepoFRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Repo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewRepoFRM_FormClosing);
            this.RepoNameGB.ResumeLayout(false);
            this.RepoNameGB.PerformLayout();
            this.RepoLocationGB.ResumeLayout(false);
            this.RepoLocationGB.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RepoNameTB;
        private System.Windows.Forms.GroupBox RepoNameGB;
        private System.Windows.Forms.GroupBox RepoLocationGB;
        private System.Windows.Forms.TextBox RepoLocationTB;
        private System.Windows.Forms.CheckBox OptionBareCB;
        private System.Windows.Forms.CheckBox OptionReadmeCB;
        private NoFocusSelectionRectangleButton BrowseLocationBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NewRepoDescriptionSSLB;
        private System.Windows.Forms.Panel panel1;
    }
}