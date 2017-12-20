namespace GITRepoManager
{
    partial class MoveRepoFRM
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MoveRepoDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrowseRepoDestinationBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoDestinationGB = new System.Windows.Forms.GroupBox();
            this.RepoDestinationTB = new System.Windows.Forms.TextBox();
            this.RepoSourceGB = new System.Windows.Forms.GroupBox();
            this.RepoSourceTB = new System.Windows.Forms.TextBox();
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.statusStrip1.SuspendLayout();
            this.RepoDestinationGB.SuspendLayout();
            this.RepoSourceGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveRepoDescriptionSSLB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MoveRepoDescriptionSSLB
            // 
            this.MoveRepoDescriptionSSLB.Name = "MoveRepoDescriptionSSLB";
            this.MoveRepoDescriptionSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // BrowseRepoDestinationBT
            // 
            this.BrowseRepoDestinationBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseRepoDestinationBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoDestinationBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseRepoDestinationBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseRepoDestinationBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseRepoDestinationBT.FlatAppearance.BorderSize = 0;
            this.BrowseRepoDestinationBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoDestinationBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoDestinationBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseRepoDestinationBT.Location = new System.Drawing.Point(439, 108);
            this.BrowseRepoDestinationBT.Name = "BrowseRepoDestinationBT";
            this.BrowseRepoDestinationBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseRepoDestinationBT.TabIndex = 17;
            this.BrowseRepoDestinationBT.UseVisualStyleBackColor = false;
            this.BrowseRepoDestinationBT.Click += new System.EventHandler(this.BrowseRepoDestinationBT_Click);
            this.BrowseRepoDestinationBT.MouseEnter += new System.EventHandler(this.BrowseRepoDestinationBT_MouseEnter);
            this.BrowseRepoDestinationBT.MouseLeave += new System.EventHandler(this.BrowseRepoDestinationBT_MouseLeave);
            // 
            // RepoDestinationGB
            // 
            this.RepoDestinationGB.Controls.Add(this.RepoDestinationTB);
            this.RepoDestinationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoDestinationGB.Location = new System.Drawing.Point(12, 98);
            this.RepoDestinationGB.Name = "RepoDestinationGB";
            this.RepoDestinationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoDestinationGB.TabIndex = 16;
            this.RepoDestinationGB.TabStop = false;
            this.RepoDestinationGB.Text = "Destination";
            // 
            // RepoDestinationTB
            // 
            this.RepoDestinationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoDestinationTB.Location = new System.Drawing.Point(10, 29);
            this.RepoDestinationTB.Multiline = true;
            this.RepoDestinationTB.Name = "RepoDestinationTB";
            this.RepoDestinationTB.Size = new System.Drawing.Size(402, 29);
            this.RepoDestinationTB.TabIndex = 0;
            // 
            // RepoSourceGB
            // 
            this.RepoSourceGB.Controls.Add(this.RepoSourceTB);
            this.RepoSourceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceGB.Location = new System.Drawing.Point(12, 6);
            this.RepoSourceGB.Name = "RepoSourceGB";
            this.RepoSourceGB.Size = new System.Drawing.Size(421, 73);
            this.RepoSourceGB.TabIndex = 15;
            this.RepoSourceGB.TabStop = false;
            this.RepoSourceGB.Text = "Source";
            // 
            // RepoSourceTB
            // 
            this.RepoSourceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceTB.Location = new System.Drawing.Point(10, 29);
            this.RepoSourceTB.Multiline = true;
            this.RepoSourceTB.Name = "RepoSourceTB";
            this.RepoSourceTB.Size = new System.Drawing.Size(402, 29);
            this.RepoSourceTB.TabIndex = 0;
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
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(439, 12);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseRepoSourceBT.TabIndex = 20;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // MoveRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 225);
            this.Controls.Add(this.BrowseRepoSourceBT);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BrowseRepoDestinationBT);
            this.Controls.Add(this.RepoDestinationGB);
            this.Controls.Add(this.RepoSourceGB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 264);
            this.MinimumSize = new System.Drawing.Size(521, 264);
            this.Name = "MoveRepoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move Repo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoveRepoFRM_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.RepoDestinationGB.ResumeLayout(false);
            this.RepoDestinationGB.PerformLayout();
            this.RepoSourceGB.ResumeLayout(false);
            this.RepoSourceGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MoveRepoDescriptionSSLB;
        private NoFocusSelectionRectangleButton BrowseRepoDestinationBT;
        private System.Windows.Forms.GroupBox RepoDestinationGB;
        private System.Windows.Forms.TextBox RepoDestinationTB;
        private System.Windows.Forms.GroupBox RepoSourceGB;
        private System.Windows.Forms.TextBox RepoSourceTB;
        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
    }
}