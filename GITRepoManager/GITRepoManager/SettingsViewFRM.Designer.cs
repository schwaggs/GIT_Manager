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
            this.DeleteLocationBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigPathTB = new System.Windows.Forms.TextBox();
            this.TempPathTB = new System.Windows.Forms.TextBox();
            this.BrowseBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.StoreLocationLV = new System.Windows.Forms.ListView();
            this.StoreNameCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPathBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SaveSettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SettingsInfoSSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainViewP.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainViewP
            // 
            this.MainViewP.Controls.Add(this.DeleteLocationBT);
            this.MainViewP.Controls.Add(this.label2);
            this.MainViewP.Controls.Add(this.label1);
            this.MainViewP.Controls.Add(this.ConfigPathTB);
            this.MainViewP.Controls.Add(this.TempPathTB);
            this.MainViewP.Controls.Add(this.BrowseBT);
            this.MainViewP.Controls.Add(this.StoreLocationLV);
            this.MainViewP.Controls.Add(this.AddPathBT);
            this.MainViewP.Location = new System.Drawing.Point(12, 12);
            this.MainViewP.Name = "MainViewP";
            this.MainViewP.Size = new System.Drawing.Size(501, 332);
            this.MainViewP.TabIndex = 0;
            // 
            // DeleteLocationBT
            // 
            this.DeleteLocationBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteLocationBT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLocationBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Delete_Tag_Icon;
            this.DeleteLocationBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteLocationBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteLocationBT.FlatAppearance.BorderSize = 0;
            this.DeleteLocationBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteLocationBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteLocationBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteLocationBT.Location = new System.Drawing.Point(472, 68);
            this.DeleteLocationBT.Name = "DeleteLocationBT";
            this.DeleteLocationBT.Size = new System.Drawing.Size(25, 25);
            this.DeleteLocationBT.TabIndex = 31;
            this.DeleteLocationBT.UseVisualStyleBackColor = false;
            this.DeleteLocationBT.Visible = false;
            this.DeleteLocationBT.Click += new System.EventHandler(this.DeleteLocationBT_Click);
            this.DeleteLocationBT.MouseEnter += new System.EventHandler(this.DeleteLocationBT_MouseEnter);
            this.DeleteLocationBT.MouseLeave += new System.EventHandler(this.DeleteLocationBT_MouseLeave);
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
            // ConfigPathTB
            // 
            this.ConfigPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigPathTB.Location = new System.Drawing.Point(3, 31);
            this.ConfigPathTB.Name = "ConfigPathTB";
            this.ConfigPathTB.ReadOnly = true;
            this.ConfigPathTB.Size = new System.Drawing.Size(413, 26);
            this.ConfigPathTB.TabIndex = 28;
            // 
            // TempPathTB
            // 
            this.TempPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempPathTB.Location = new System.Drawing.Point(3, 300);
            this.TempPathTB.Name = "TempPathTB";
            this.TempPathTB.Size = new System.Drawing.Size(413, 26);
            this.TempPathTB.TabIndex = 26;
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
            this.BrowseBT.MouseLeave += new System.EventHandler(this.BrowseBT_MouseLeave);
            // 
            // StoreLocationLV
            // 
            this.StoreLocationLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreLocationLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StoreNameCH,
            this.LocationCH});
            this.StoreLocationLV.FullRowSelect = true;
            this.StoreLocationLV.GridLines = true;
            this.StoreLocationLV.Location = new System.Drawing.Point(3, 96);
            this.StoreLocationLV.MultiSelect = false;
            this.StoreLocationLV.Name = "StoreLocationLV";
            this.StoreLocationLV.Size = new System.Drawing.Size(494, 192);
            this.StoreLocationLV.TabIndex = 21;
            this.StoreLocationLV.UseCompatibleStateImageBehavior = false;
            this.StoreLocationLV.View = System.Windows.Forms.View.Details;
            this.StoreLocationLV.SelectedIndexChanged += new System.EventHandler(this.StoreLocationsLV_SelectedIndexChanged);
            // 
            // StoreNameCH
            // 
            this.StoreNameCH.Text = "Store Name";
            this.StoreNameCH.Width = 187;
            // 
            // LocationCH
            // 
            this.LocationCH.Text = "Location";
            this.LocationCH.Width = 301;
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
            this.SaveSettingsBT.Location = new System.Drawing.Point(12, 344);
            this.SaveSettingsBT.Name = "SaveSettingsBT";
            this.SaveSettingsBT.Size = new System.Drawing.Size(45, 45);
            this.SaveSettingsBT.TabIndex = 23;
            this.SaveSettingsBT.UseVisualStyleBackColor = false;
            this.SaveSettingsBT.Click += new System.EventHandler(this.SaveSettingsBT_Click);
            this.SaveSettingsBT.MouseEnter += new System.EventHandler(this.SaveSettingsBT_MouseEnter);
            this.SaveSettingsBT.MouseLeave += new System.EventHandler(this.SaveSettingsBT_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsInfoSSSL});
            this.statusStrip1.Location = new System.Drawing.Point(12, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SettingsInfoSSSL
            // 
            this.SettingsInfoSSSL.Name = "SettingsInfoSSSL";
            this.SettingsInfoSSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // SettingsViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(521, 421);
            this.Controls.Add(this.statusStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainViewP;
        private NoFocusSelectionRectangleButton AddPathBT;
        private NoFocusSelectionRectangleButton SaveSettingsBT;
        private System.Windows.Forms.TextBox TempPathTB;
        private NoFocusSelectionRectangleButton BrowseBT;
        private System.Windows.Forms.ListView StoreLocationLV;
        private System.Windows.Forms.ColumnHeader StoreNameCH;
        private System.Windows.Forms.ColumnHeader LocationCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfigPathTB;
        private NoFocusSelectionRectangleButton DeleteLocationBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SettingsInfoSSSL;
    }
}