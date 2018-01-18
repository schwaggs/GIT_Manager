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
            this.AddPathBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SaveSettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.ResetSettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.ConfigFilesLV = new System.Windows.Forms.ListView();
            this.FilenamesCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrowseBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.TempPathTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainViewP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainViewP
            // 
            this.MainViewP.Controls.Add(this.label2);
            this.MainViewP.Controls.Add(this.label1);
            this.MainViewP.Controls.Add(this.textBox1);
            this.MainViewP.Controls.Add(this.TempPathTB);
            this.MainViewP.Controls.Add(this.BrowseBT);
            this.MainViewP.Controls.Add(this.ConfigFilesLV);
            this.MainViewP.Controls.Add(this.AddPathBT);
            this.MainViewP.Location = new System.Drawing.Point(12, 12);
            this.MainViewP.Name = "MainViewP";
            this.MainViewP.Size = new System.Drawing.Size(501, 332);
            this.MainViewP.TabIndex = 0;
            // 
            // AddPathBT
            // 
            this.AddPathBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPathBT.BackColor = System.Drawing.Color.Transparent;
            this.AddPathBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Add_Tag_Icon;
            this.AddPathBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPathBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddPathBT.FlatAppearance.BorderSize = 0;
            this.AddPathBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddPathBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddPathBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPathBT.Location = new System.Drawing.Point(462, 294);
            this.AddPathBT.Name = "AddPathBT";
            this.AddPathBT.Size = new System.Drawing.Size(35, 35);
            this.AddPathBT.TabIndex = 20;
            this.AddPathBT.UseVisualStyleBackColor = false;
            this.AddPathBT.Click += new System.EventHandler(this.AddPathBT_Click);
            this.AddPathBT.MouseEnter += new System.EventHandler(this.AddPathBT_MouseEnter);
            this.AddPathBT.MouseLeave += new System.EventHandler(this.AddPathBT_MouseLeave);
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
            this.SaveSettingsBT.Location = new System.Drawing.Point(12, 350);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(45, 45);
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
            this.ResetSettingsBT.Location = new System.Drawing.Point(63, 350);
            this.ResetSettingsBT.Name = "ResetSettingsBT";
            this.ResetSettingsBT.Size = new System.Drawing.Size(45, 45);
            this.ResetSettingsBT.TabIndex = 24;
            this.ResetSettingsBT.UseVisualStyleBackColor = false;
            this.ResetSettingsBT.Click += new System.EventHandler(this.ResetSettingsBT_Click);
            this.ResetSettingsBT.MouseEnter += new System.EventHandler(this.ResetSettingsBT_MouseEnter);
            this.ResetSettingsBT.MouseLeave += new System.EventHandler(this.ResetSettingsBT_MouseLeave);
            // 
            // ConfigFilesLV
            // 
            this.ConfigFilesLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigFilesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilenamesCH,
            this.LocationCH});
            this.ConfigFilesLV.FullRowSelect = true;
            this.ConfigFilesLV.GridLines = true;
            this.ConfigFilesLV.Location = new System.Drawing.Point(3, 96);
            this.ConfigFilesLV.MultiSelect = false;
            this.ConfigFilesLV.Name = "ConfigFilesLV";
            this.ConfigFilesLV.Size = new System.Drawing.Size(495, 192);
            this.ConfigFilesLV.TabIndex = 21;
            this.ConfigFilesLV.UseCompatibleStateImageBehavior = false;
            this.ConfigFilesLV.View = System.Windows.Forms.View.Details;
            // 
            // FilenamesCH
            // 
            this.FilenamesCH.Text = "Filename";
            this.FilenamesCH.Width = 190;
            // 
            // LocationCH
            // 
            this.LocationCH.Text = "Location";
            this.LocationCH.Width = 300;
            // 
            // BrowseBT
            // 
            this.BrowseBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Browse_Icon;
            this.BrowseBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseBT.FlatAppearance.BorderSize = 0;
            this.BrowseBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBT.Location = new System.Drawing.Point(421, 294);
            this.BrowseBT.Name = "BrowseBT";
            this.BrowseBT.Size = new System.Drawing.Size(35, 35);
            this.BrowseBT.TabIndex = 25;
            this.BrowseBT.UseVisualStyleBackColor = false;
            this.BrowseBT.Click += new System.EventHandler(this.BrowseBT_Click);
            this.BrowseBT.MouseEnter += new System.EventHandler(this.BrowseBT_MouseEnter);
            this.BrowseBT.MouseHover += new System.EventHandler(this.BrowseBT_MouseLeave);
            // 
            // TempPathTB
            // 
            this.TempPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempPathTB.Location = new System.Drawing.Point(3, 300);
            this.TempPathTB.Name = "TempPathTB";
            this.TempPathTB.Size = new System.Drawing.Size(413, 26);
            this.TempPathTB.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(413, 26);
            this.textBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Configuration File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Repository Stores";
            // 
            // SettingsViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(521, 402);
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
            this.MainViewP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainViewP;
        private NoFocusSelectionRectangleButton AddPathBT;
        private NoFocusSelectionRectangleButton SaveSettingsBT;
        private NoFocusSelectionRectangleButton ResetSettingsBT;
        private System.Windows.Forms.TextBox TempPathTB;
        private NoFocusSelectionRectangleButton BrowseBT;
        private System.Windows.Forms.ListView ConfigFilesLV;
        private System.Windows.Forms.ColumnHeader FilenamesCH;
        private System.Windows.Forms.ColumnHeader LocationCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}