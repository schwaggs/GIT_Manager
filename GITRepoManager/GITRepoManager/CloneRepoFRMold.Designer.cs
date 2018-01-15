namespace GITRepoManager
{
    partial class CloneRepoFRMold
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
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CloneRepoDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrowseCloneDestinationBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.CloneDestinationGB = new System.Windows.Forms.GroupBox();
            this.CloneDestinationTB = new System.Windows.Forms.TextBox();
            this.RepoSourceGB = new System.Windows.Forms.GroupBox();
            this.RepoSourceTB = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.CloneDestinationGB.SuspendLayout();
            this.RepoSourceGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseRepoSourceBT
            // 
            this.BrowseRepoSourceBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseRepoSourceBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseRepoSourceBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseRepoSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseRepoSourceBT.FlatAppearance.BorderSize = 0;
            this.BrowseRepoSourceBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(549, 29);
            this.BrowseRepoSourceBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(70, 79);
            this.BrowseRepoSourceBT.TabIndex = 25;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneRepoDescriptionSSLB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(631, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CloneRepoDescriptionSSLB
            // 
            this.CloneRepoDescriptionSSLB.Name = "CloneRepoDescriptionSSLB";
            this.CloneRepoDescriptionSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // BrowseCloneDestinationBT
            // 
            this.BrowseCloneDestinationBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseCloneDestinationBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseCloneDestinationBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseCloneDestinationBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseCloneDestinationBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseCloneDestinationBT.FlatAppearance.BorderSize = 0;
            this.BrowseCloneDestinationBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseCloneDestinationBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseCloneDestinationBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseCloneDestinationBT.Location = new System.Drawing.Point(549, 126);
            this.BrowseCloneDestinationBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrowseCloneDestinationBT.Name = "BrowseCloneDestinationBT";
            this.BrowseCloneDestinationBT.Size = new System.Drawing.Size(70, 79);
            this.BrowseCloneDestinationBT.TabIndex = 23;
            this.BrowseCloneDestinationBT.UseVisualStyleBackColor = false;
            this.BrowseCloneDestinationBT.Click += new System.EventHandler(this.BrowseCloneDestinationBT_Click);
            this.BrowseCloneDestinationBT.MouseEnter += new System.EventHandler(this.BrowseCloneDestinationBT_MouseEnter);
            this.BrowseCloneDestinationBT.MouseLeave += new System.EventHandler(this.BrowseCloneDestinationBT_MouseLeave);
            // 
            // CloneDestinationGB
            // 
            this.CloneDestinationGB.Controls.Add(this.CloneDestinationTB);
            this.CloneDestinationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloneDestinationGB.Location = new System.Drawing.Point(15, 114);
            this.CloneDestinationGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloneDestinationGB.Name = "CloneDestinationGB";
            this.CloneDestinationGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloneDestinationGB.Size = new System.Drawing.Size(526, 91);
            this.CloneDestinationGB.TabIndex = 22;
            this.CloneDestinationGB.TabStop = false;
            this.CloneDestinationGB.Text = "Destination";
            // 
            // CloneDestinationTB
            // 
            this.CloneDestinationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloneDestinationTB.Location = new System.Drawing.Point(8, 36);
            this.CloneDestinationTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloneDestinationTB.Multiline = true;
            this.CloneDestinationTB.Name = "CloneDestinationTB";
            this.CloneDestinationTB.Size = new System.Drawing.Size(510, 35);
            this.CloneDestinationTB.TabIndex = 0;
            // 
            // RepoSourceGB
            // 
            this.RepoSourceGB.Controls.Add(this.RepoSourceTB);
            this.RepoSourceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceGB.Location = new System.Drawing.Point(15, 15);
            this.RepoSourceGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RepoSourceGB.Name = "RepoSourceGB";
            this.RepoSourceGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RepoSourceGB.Size = new System.Drawing.Size(526, 91);
            this.RepoSourceGB.TabIndex = 21;
            this.RepoSourceGB.TabStop = false;
            this.RepoSourceGB.Text = "Source";
            // 
            // RepoSourceTB
            // 
            this.RepoSourceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceTB.Location = new System.Drawing.Point(8, 31);
            this.RepoSourceTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RepoSourceTB.Multiline = true;
            this.RepoSourceTB.Name = "RepoSourceTB";
            this.RepoSourceTB.Size = new System.Drawing.Size(510, 35);
            this.RepoSourceTB.TabIndex = 0;
            // 
            // CloneRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 250);
            this.Controls.Add(this.BrowseRepoSourceBT);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BrowseCloneDestinationBT);
            this.Controls.Add(this.CloneDestinationGB);
            this.Controls.Add(this.RepoSourceGB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 297);
            this.MinimumSize = new System.Drawing.Size(649, 297);
            this.Name = "CloneRepoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clone Repo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloneRepoFRM_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.CloneDestinationGB.ResumeLayout(false);
            this.CloneDestinationGB.PerformLayout();
            this.RepoSourceGB.ResumeLayout(false);
            this.RepoSourceGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CloneRepoDescriptionSSLB;
        private NoFocusSelectionRectangleButton BrowseCloneDestinationBT;
        private System.Windows.Forms.GroupBox CloneDestinationGB;
        private System.Windows.Forms.TextBox CloneDestinationTB;
        private System.Windows.Forms.GroupBox RepoSourceGB;
        private System.Windows.Forms.TextBox RepoSourceTB;
    }
}