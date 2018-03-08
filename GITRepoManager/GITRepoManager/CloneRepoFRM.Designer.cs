namespace GITRepoManager
{
    partial class CloneRepoFRM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RepoPathTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DestinationPathTB = new System.Windows.Forms.TextBox();
            this.ClearAllBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RepoPathTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repository Path";
            // 
            // RepoPathTB
            // 
            this.RepoPathTB.Location = new System.Drawing.Point(7, 25);
            this.RepoPathTB.Name = "RepoPathTB";
            this.RepoPathTB.ReadOnly = true;
            this.RepoPathTB.Size = new System.Drawing.Size(399, 26);
            this.RepoPathTB.TabIndex = 4;
            this.RepoPathTB.Click += new System.EventHandler(this.RepoPathTB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BrowseRepoSourceBT);
            this.groupBox2.Controls.Add(this.DestinationPathTB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clone Destination Path";
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
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(361, 12);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(45, 45);
            this.BrowseRepoSourceBT.TabIndex = 1;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // DestinationPathTB
            // 
            this.DestinationPathTB.Location = new System.Drawing.Point(7, 25);
            this.DestinationPathTB.Name = "DestinationPathTB";
            this.DestinationPathTB.Size = new System.Drawing.Size(338, 26);
            this.DestinationPathTB.TabIndex = 0;
            // 
            // ClearAllBT
            // 
            this.ClearAllBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearAllBT.BackColor = System.Drawing.Color.Transparent;
            this.ClearAllBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Reset_Settings_Icon;
            this.ClearAllBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearAllBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearAllBT.FlatAppearance.BorderSize = 0;
            this.ClearAllBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearAllBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearAllBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllBT.Location = new System.Drawing.Point(71, 154);
            this.ClearAllBT.Name = "ClearAllBT";
            this.ClearAllBT.Size = new System.Drawing.Size(35, 35);
            this.ClearAllBT.TabIndex = 3;
            this.ClearAllBT.UseVisualStyleBackColor = false;
            this.ClearAllBT.Click += new System.EventHandler(this.ClearAllBT_Click);
            this.ClearAllBT.MouseEnter += new System.EventHandler(this.ClearAllBT_MouseEnter);
            this.ClearAllBT.MouseLeave += new System.EventHandler(this.ClearAllBT_MouseLeave);
            // 
            // CloneRepoBT
            // 
            this.CloneRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloneRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.CloneIcon;
            this.CloneRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloneRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloneRepoBT.FlatAppearance.BorderSize = 0;
            this.CloneRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneRepoBT.Location = new System.Drawing.Point(20, 154);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(35, 35);
            this.CloneRepoBT.TabIndex = 2;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Click += new System.EventHandler(this.CloneRepoBT_Click);
            this.CloneRepoBT.MouseEnter += new System.EventHandler(this.CloneRepoBT_MouseEnter);
            this.CloneRepoBT.MouseLeave += new System.EventHandler(this.CloneRepoBT_MouseLeave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 34);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // CloneRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 194);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ClearAllBT);
            this.Controls.Add(this.CloneRepoBT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CloneRepoFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone Repository";
            this.Load += new System.EventHandler(this.CloneRepoFRM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RepoPathTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DestinationPathTB;
        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
        private NoFocusSelectionRectangleButton CloneRepoBT;
        private NoFocusSelectionRectangleButton ClearAllBT;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}