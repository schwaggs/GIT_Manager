namespace GITRepoManager
{
    partial class DeleteRepoFRM
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
            this.IsLocalRepoCB = new System.Windows.Forms.CheckBox();
            this.DeleteLocalCB = new System.Windows.Forms.CheckBox();
            this.RepoLocationGB = new System.Windows.Forms.GroupBox();
            this.RepoLocationTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DeleteRepoDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseLocationBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoLocationGB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsLocalRepoCB
            // 
            this.IsLocalRepoCB.AutoSize = true;
            this.IsLocalRepoCB.Location = new System.Drawing.Point(95, 3);
            this.IsLocalRepoCB.Name = "IsLocalRepoCB";
            this.IsLocalRepoCB.Size = new System.Drawing.Size(63, 17);
            this.IsLocalRepoCB.TabIndex = 15;
            this.IsLocalRepoCB.Text = "Is Local";
            this.IsLocalRepoCB.UseVisualStyleBackColor = true;
            this.IsLocalRepoCB.MouseEnter += new System.EventHandler(this.IsLocalRepoCB_MouseEnter);
            this.IsLocalRepoCB.MouseLeave += new System.EventHandler(this.IsLocalRepoCB_MouseLeave);
            // 
            // DeleteLocalCB
            // 
            this.DeleteLocalCB.AutoSize = true;
            this.DeleteLocalCB.Location = new System.Drawing.Point(3, 3);
            this.DeleteLocalCB.Name = "DeleteLocalCB";
            this.DeleteLocalCB.Size = new System.Drawing.Size(86, 17);
            this.DeleteLocalCB.TabIndex = 14;
            this.DeleteLocalCB.Text = "Delete Local";
            this.DeleteLocalCB.UseVisualStyleBackColor = true;
            this.DeleteLocalCB.MouseEnter += new System.EventHandler(this.DeleteLocalCB_MouseEnter);
            this.DeleteLocalCB.MouseLeave += new System.EventHandler(this.DeleteLocalCB_MouseLeave);
            // 
            // RepoLocationGB
            // 
            this.RepoLocationGB.Controls.Add(this.RepoLocationTB);
            this.RepoLocationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationGB.Location = new System.Drawing.Point(12, 12);
            this.RepoLocationGB.Name = "RepoLocationGB";
            this.RepoLocationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoLocationGB.TabIndex = 13;
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRepoDescriptionSSLB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 123);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DeleteRepoDescriptionSSLB
            // 
            this.DeleteRepoDescriptionSSLB.Name = "DeleteRepoDescriptionSSLB";
            this.DeleteRepoDescriptionSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteLocalCB);
            this.panel1.Controls.Add(this.IsLocalRepoCB);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 22);
            this.panel1.TabIndex = 18;
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
            this.BrowseLocationBT.Location = new System.Drawing.Point(439, 22);
            this.BrowseLocationBT.Name = "BrowseLocationBT";
            this.BrowseLocationBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseLocationBT.TabIndex = 16;
            this.BrowseLocationBT.UseVisualStyleBackColor = false;
            this.BrowseLocationBT.Click += new System.EventHandler(this.BrowseLocationBT_Click);
            this.BrowseLocationBT.MouseEnter += new System.EventHandler(this.BrowseLocationBT_MouseEnter);
            this.BrowseLocationBT.MouseLeave += new System.EventHandler(this.BrowseLocationBT_MouseLeave);
            // 
            // DeleteRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 145);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BrowseLocationBT);
            this.Controls.Add(this.RepoLocationGB);
            this.MaximumSize = new System.Drawing.Size(520, 184);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 184);
            this.Name = "DeleteRepoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Repo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteRepoFRM_FormClosing);
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

        private NoFocusSelectionRectangleButton BrowseLocationBT;
        private System.Windows.Forms.CheckBox IsLocalRepoCB;
        private System.Windows.Forms.CheckBox DeleteLocalCB;
        private System.Windows.Forms.GroupBox RepoLocationGB;
        private System.Windows.Forms.TextBox RepoLocationTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel DeleteRepoDescriptionSSLB;
        private System.Windows.Forms.Panel panel1;
    }
}