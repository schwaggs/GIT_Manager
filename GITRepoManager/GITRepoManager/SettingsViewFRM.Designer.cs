namespace GITRepoManager
{
    partial class SettingsViewFRM
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
            this.MainViewP = new System.Windows.Forms.Panel();
            this.BrowseStatusBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusFileLocationTB = new System.Windows.Forms.TextBox();
            this.BrowseTagsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TagsFileLocationTB = new System.Windows.Forms.TextBox();
            this.BrowseRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoLocationGB = new System.Windows.Forms.GroupBox();
            this.RepoFileLocationTB = new System.Windows.Forms.TextBox();
            this.SaveSettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.ResetSettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.MainViewP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RepoLocationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainViewP
            // 
            this.MainViewP.Controls.Add(this.BrowseStatusBT);
            this.MainViewP.Controls.Add(this.groupBox2);
            this.MainViewP.Controls.Add(this.BrowseTagsBT);
            this.MainViewP.Controls.Add(this.groupBox1);
            this.MainViewP.Controls.Add(this.BrowseRepoBT);
            this.MainViewP.Controls.Add(this.RepoLocationGB);
            this.MainViewP.Location = new System.Drawing.Point(12, 12);
            this.MainViewP.Name = "MainViewP";
            this.MainViewP.Size = new System.Drawing.Size(501, 267);
            this.MainViewP.TabIndex = 0;
            // 
            // BrowseStatusBT
            // 
            this.BrowseStatusBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseStatusBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseStatusBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseStatusBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseStatusBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseStatusBT.FlatAppearance.BorderSize = 0;
            this.BrowseStatusBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseStatusBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseStatusBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseStatusBT.Location = new System.Drawing.Point(430, 190);
            this.BrowseStatusBT.Name = "BrowseStatusBT";
            this.BrowseStatusBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseStatusBT.TabIndex = 22;
            this.BrowseStatusBT.UseVisualStyleBackColor = false;
            this.BrowseStatusBT.Click += new System.EventHandler(this.BrowseBT_Click);
            this.BrowseStatusBT.MouseEnter += new System.EventHandler(this.BrowseBT_MouseEnter);
            this.BrowseStatusBT.MouseLeave += new System.EventHandler(this.BrowseBT_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusFileLocationTB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 73);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status File";
            // 
            // StatusFileLocationTB
            // 
            this.StatusFileLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusFileLocationTB.Location = new System.Drawing.Point(10, 29);
            this.StatusFileLocationTB.Name = "StatusFileLocationTB";
            this.StatusFileLocationTB.Size = new System.Drawing.Size(402, 29);
            this.StatusFileLocationTB.TabIndex = 0;
            // 
            // BrowseTagsBT
            // 
            this.BrowseTagsBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseTagsBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseTagsBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseTagsBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseTagsBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseTagsBT.FlatAppearance.BorderSize = 0;
            this.BrowseTagsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseTagsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseTagsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseTagsBT.Location = new System.Drawing.Point(430, 102);
            this.BrowseTagsBT.Name = "BrowseTagsBT";
            this.BrowseTagsBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseTagsBT.TabIndex = 20;
            this.BrowseTagsBT.UseVisualStyleBackColor = false;
            this.BrowseTagsBT.Click += new System.EventHandler(this.BrowseBT_Click);
            this.BrowseTagsBT.MouseEnter += new System.EventHandler(this.BrowseBT_MouseEnter);
            this.BrowseTagsBT.MouseLeave += new System.EventHandler(this.BrowseBT_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TagsFileLocationTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tags File";
            // 
            // TagsFileLocationTB
            // 
            this.TagsFileLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagsFileLocationTB.Location = new System.Drawing.Point(10, 29);
            this.TagsFileLocationTB.Name = "TagsFileLocationTB";
            this.TagsFileLocationTB.Size = new System.Drawing.Size(402, 29);
            this.TagsFileLocationTB.TabIndex = 0;
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
            this.BrowseRepoBT.Location = new System.Drawing.Point(430, 13);
            this.BrowseRepoBT.Name = "BrowseRepoBT";
            this.BrowseRepoBT.Size = new System.Drawing.Size(56, 63);
            this.BrowseRepoBT.TabIndex = 18;
            this.BrowseRepoBT.UseVisualStyleBackColor = false;
            this.BrowseRepoBT.Click += new System.EventHandler(this.BrowseBT_Click);
            this.BrowseRepoBT.MouseEnter += new System.EventHandler(this.BrowseBT_MouseEnter);
            this.BrowseRepoBT.MouseLeave += new System.EventHandler(this.BrowseBT_MouseLeave);
            // 
            // RepoLocationGB
            // 
            this.RepoLocationGB.Controls.Add(this.RepoFileLocationTB);
            this.RepoLocationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationGB.Location = new System.Drawing.Point(3, 3);
            this.RepoLocationGB.Name = "RepoLocationGB";
            this.RepoLocationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoLocationGB.TabIndex = 17;
            this.RepoLocationGB.TabStop = false;
            this.RepoLocationGB.Text = "Repository File";
            // 
            // RepoFileLocationTB
            // 
            this.RepoFileLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoFileLocationTB.Location = new System.Drawing.Point(10, 29);
            this.RepoFileLocationTB.Name = "RepoFileLocationTB";
            this.RepoFileLocationTB.Size = new System.Drawing.Size(402, 29);
            this.RepoFileLocationTB.TabIndex = 0;
            // 
            // SaveSettingsBT
            // 
            this.SaveSettingsBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveSettingsBT.BackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Save_Settings_Icon;
            this.SaveSettingsBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveSettingsBT.FlatAppearance.BorderSize = 0;
            this.SaveSettingsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBT.Location = new System.Drawing.Point(12, 285);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(56, 63);
            this.SaveSettingsBT.TabIndex = 23;
            this.SaveSettingsBT.UseVisualStyleBackColor = false;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            this.SaveSettingsBT.MouseEnter += new System.EventHandler(this.SaveSettingsBT_MouseEnter);
            this.SaveSettingsBT.MouseLeave += new System.EventHandler(this.SaveSettingsBT_MouseLeave);
            // 
            // ResetSettingsBT
            // 
            this.ResetSettingsBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetSettingsBT.BackColor = System.Drawing.Color.Transparent;
            this.ResetSettingsBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Reset_Settings_Icon;
            this.ResetSettingsBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetSettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetSettingsBT.FlatAppearance.BorderSize = 0;
            this.ResetSettingsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetSettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetSettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSettingsBT.Location = new System.Drawing.Point(85, 285);
            this.ResetSettingsBT.Name = "ResetSettingsBT";
            this.ResetSettingsBT.Size = new System.Drawing.Size(56, 63);
            this.ResetSettingsBT.TabIndex = 24;
            this.ResetSettingsBT.UseVisualStyleBackColor = false;
            this.ResetSettingsBT.Click += new System.EventHandler(this.ResetSettingsBT_Click);
            this.ResetSettingsBT.MouseEnter += new System.EventHandler(this.ResetSettingsBT_MouseEnter);
            this.ResetSettingsBT.MouseLeave += new System.EventHandler(this.ResetSettingsBT_MouseLeave);
            // 
            // SettingsViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 352);
            this.Controls.Add(this.ResetSettingsBT);
            this.Controls.Add(this.SaveSettingsBT);
            this.Controls.Add(this.MainViewP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "SettingsViewFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsViewFRM_FormClosing);
            this.Load += new System.EventHandler(this.SettingsViewFRM_Load);
            this.MainViewP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RepoLocationGB.ResumeLayout(false);
            this.RepoLocationGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainViewP;
        private NoFocusSelectionRectangleButton BrowseStatusBT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox StatusFileLocationTB;
        private NoFocusSelectionRectangleButton BrowseTagsBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TagsFileLocationTB;
        private NoFocusSelectionRectangleButton BrowseRepoBT;
        private System.Windows.Forms.GroupBox RepoLocationGB;
        private System.Windows.Forms.TextBox RepoFileLocationTB;
        private NoFocusSelectionRectangleButton SaveSettingsBT;
        private NoFocusSelectionRectangleButton ResetSettingsBT;
    }
}