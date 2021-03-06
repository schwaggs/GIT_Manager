﻿namespace GITRepoManager
{
    partial class MainViewFRM
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StoreLocationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MainStatusSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditRepoP = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RepoStatusCB = new System.Windows.Forms.ComboBox();
            this.LastCommitMessageTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LastCommitTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RepoPathTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReposLV = new System.Windows.Forms.ListView();
            this.RepoNameCHDR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AutoCheckTMR = new System.Windows.Forms.Timer(this.components);
            this.RepoRightClickCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloneRepoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewNotesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLogsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStoreBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RefreshStoresBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SettingsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.AddRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.ClearRepoChangesBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SaveRepoChangesBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.LogsBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.NotesBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.EditRepoP.SuspendLayout();
            this.RepoRightClickCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::GITRepoManager.Properties.Resources.BackGradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.OpenStoreBT);
            this.panel1.Controls.Add(this.CloneRepoBT);
            this.panel1.Controls.Add(this.RefreshStoresBT);
            this.panel1.Controls.Add(this.SettingsBT);
            this.panel1.Controls.Add(this.AddRepoBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 55);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StoreLocationCB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 40);
            this.panel2.TabIndex = 1;
            // 
            // StoreLocationCB
            // 
            this.StoreLocationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreLocationCB.FormattingEnabled = true;
            this.StoreLocationCB.Location = new System.Drawing.Point(128, 8);
            this.StoreLocationCB.Name = "StoreLocationCB";
            this.StoreLocationCB.Size = new System.Drawing.Size(244, 21);
            this.StoreLocationCB.TabIndex = 26;
            this.StoreLocationCB.SelectedIndexChanged += new System.EventHandler(this.StoreLocationCB_SelectedIndexChanged);
            this.StoreLocationCB.Click += new System.EventHandler(this.StoreLocationCB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Store Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GITRepoManager.Properties.Resources.GitLogo_Inverted;
            this.pictureBox1.Location = new System.Drawing.Point(728, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStatusSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            // 
            // MainStatusSSL
            // 
            this.MainStatusSSL.Name = "MainStatusSSL";
            this.MainStatusSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EditRepoP);
            this.panel3.Controls.Add(this.ReposLV);
            this.panel3.Location = new System.Drawing.Point(4, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 343);
            this.panel3.TabIndex = 2;
            // 
            // EditRepoP
            // 
            this.EditRepoP.Controls.Add(this.ClearRepoChangesBT);
            this.EditRepoP.Controls.Add(this.SaveRepoChangesBT);
            this.EditRepoP.Controls.Add(this.label7);
            this.EditRepoP.Controls.Add(this.label6);
            this.EditRepoP.Controls.Add(this.LogsBT);
            this.EditRepoP.Controls.Add(this.NotesBT);
            this.EditRepoP.Controls.Add(this.RepoStatusCB);
            this.EditRepoP.Controls.Add(this.LastCommitMessageTB);
            this.EditRepoP.Controls.Add(this.label5);
            this.EditRepoP.Controls.Add(this.LastCommitTB);
            this.EditRepoP.Controls.Add(this.label4);
            this.EditRepoP.Controls.Add(this.label3);
            this.EditRepoP.Controls.Add(this.RepoPathTB);
            this.EditRepoP.Controls.Add(this.label2);
            this.EditRepoP.Location = new System.Drawing.Point(321, 0);
            this.EditRepoP.Name = "EditRepoP";
            this.EditRepoP.Size = new System.Drawing.Size(480, 343);
            this.EditRepoP.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Logs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Notes";
            // 
            // RepoStatusCB
            // 
            this.RepoStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepoStatusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoStatusCB.FormattingEnabled = true;
            this.RepoStatusCB.Items.AddRange(new object[] {
            "None",
            "New",
            "Development",
            "Production"});
            this.RepoStatusCB.Location = new System.Drawing.Point(114, 35);
            this.RepoStatusCB.Name = "RepoStatusCB";
            this.RepoStatusCB.Size = new System.Drawing.Size(358, 26);
            this.RepoStatusCB.TabIndex = 17;
            this.RepoStatusCB.SelectedIndexChanged += new System.EventHandler(this.RepoStatusCB_SelectedIndexChanged);
            // 
            // LastCommitMessageTB
            // 
            this.LastCommitMessageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastCommitMessageTB.Location = new System.Drawing.Point(114, 97);
            this.LastCommitMessageTB.Multiline = true;
            this.LastCommitMessageTB.Name = "LastCommitMessageTB";
            this.LastCommitMessageTB.ReadOnly = true;
            this.LastCommitMessageTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LastCommitMessageTB.Size = new System.Drawing.Size(358, 128);
            this.LastCommitMessageTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message";
            // 
            // LastCommitTB
            // 
            this.LastCommitTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastCommitTB.Location = new System.Drawing.Point(114, 67);
            this.LastCommitTB.Name = "LastCommitTB";
            this.LastCommitTB.ReadOnly = true;
            this.LastCommitTB.Size = new System.Drawing.Size(358, 24);
            this.LastCommitTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Commit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Status";
            // 
            // RepoPathTB
            // 
            this.RepoPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoPathTB.Location = new System.Drawing.Point(114, 5);
            this.RepoPathTB.Name = "RepoPathTB";
            this.RepoPathTB.ReadOnly = true;
            this.RepoPathTB.Size = new System.Drawing.Size(358, 24);
            this.RepoPathTB.TabIndex = 1;
            this.RepoPathTB.Click += new System.EventHandler(this.RepoPathTB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Path";
            // 
            // ReposLV
            // 
            this.ReposLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReposLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RepoNameCHDR});
            this.ReposLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReposLV.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReposLV.FullRowSelect = true;
            this.ReposLV.GridLines = true;
            this.ReposLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReposLV.HideSelection = false;
            this.ReposLV.Location = new System.Drawing.Point(0, 0);
            this.ReposLV.MultiSelect = false;
            this.ReposLV.Name = "ReposLV";
            this.ReposLV.Size = new System.Drawing.Size(315, 343);
            this.ReposLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ReposLV.TabIndex = 1;
            this.ReposLV.UseCompatibleStateImageBehavior = false;
            this.ReposLV.View = System.Windows.Forms.View.Details;
            this.ReposLV.SelectedIndexChanged += new System.EventHandler(this.ReposLV_SelectedIndexChanged);
            this.ReposLV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReposLV_KeyUp);
            this.ReposLV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReposLV_MouseClick);
            this.ReposLV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReposLV_MouseUp);
            // 
            // RepoNameCHDR
            // 
            this.RepoNameCHDR.Text = "Repository Name";
            this.RepoNameCHDR.Width = 310;
            // 
            // AutoCheckTMR
            // 
            this.AutoCheckTMR.Tick += new System.EventHandler(this.AutoCheckTMR_Tick);
            // 
            // RepoRightClickCMS
            // 
            this.RepoRightClickCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloneRepoTSMI,
            this.ViewNotesTSMI,
            this.ViewLogsTSMI});
            this.RepoRightClickCMS.Name = "RepoRightClickCMS";
            this.RepoRightClickCMS.Size = new System.Drawing.Size(68, 70);
            this.RepoRightClickCMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RepoRightClickCMS_ItemClicked);
            // 
            // CloneRepoTSMI
            // 
            this.CloneRepoTSMI.Name = "CloneRepoTSMI";
            this.CloneRepoTSMI.Size = new System.Drawing.Size(67, 22);
            // 
            // ViewNotesTSMI
            // 
            this.ViewNotesTSMI.Name = "ViewNotesTSMI";
            this.ViewNotesTSMI.Size = new System.Drawing.Size(67, 22);
            // 
            // ViewLogsTSMI
            // 
            this.ViewLogsTSMI.Name = "ViewLogsTSMI";
            this.ViewLogsTSMI.Size = new System.Drawing.Size(67, 22);
            // 
            // OpenStoreBT
            // 
            this.OpenStoreBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenStoreBT.BackColor = System.Drawing.Color.Transparent;
            this.OpenStoreBT.BackgroundImage = global::GITRepoManager.Properties.Resources.OpenFolderIcon;
            this.OpenStoreBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenStoreBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OpenStoreBT.FlatAppearance.BorderSize = 0;
            this.OpenStoreBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OpenStoreBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OpenStoreBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenStoreBT.Location = new System.Drawing.Point(394, 16);
            this.OpenStoreBT.Name = "OpenStoreBT";
            this.OpenStoreBT.Size = new System.Drawing.Size(27, 27);
            this.OpenStoreBT.TabIndex = 35;
            this.OpenStoreBT.UseVisualStyleBackColor = false;
            this.OpenStoreBT.Click += new System.EventHandler(this.OpenStoreBT_Click);
            this.OpenStoreBT.MouseEnter += new System.EventHandler(this.OpenStoreBT_MouseEnter);
            this.OpenStoreBT.MouseLeave += new System.EventHandler(this.OpenStoreBT_MouseLeave);
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
            this.CloneRepoBT.Location = new System.Drawing.Point(531, 8);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(40, 40);
            this.CloneRepoBT.TabIndex = 24;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Visible = false;
            this.CloneRepoBT.Click += new System.EventHandler(this.CloneRepoBT_Click);
            this.CloneRepoBT.MouseEnter += new System.EventHandler(this.CloneRepoBT_MouseEnter);
            this.CloneRepoBT.MouseLeave += new System.EventHandler(this.CloneRepoBT_MouseLeave);
            // 
            // RefreshStoresBT
            // 
            this.RefreshStoresBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshStoresBT.BackColor = System.Drawing.Color.Transparent;
            this.RefreshStoresBT.BackgroundImage = global::GITRepoManager.Properties.Resources.RefreshIcon;
            this.RefreshStoresBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshStoresBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RefreshStoresBT.FlatAppearance.BorderSize = 0;
            this.RefreshStoresBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RefreshStoresBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RefreshStoresBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshStoresBT.Location = new System.Drawing.Point(647, 11);
            this.RefreshStoresBT.Name = "RefreshStoresBT";
            this.RefreshStoresBT.Size = new System.Drawing.Size(35, 35);
            this.RefreshStoresBT.TabIndex = 34;
            this.RefreshStoresBT.UseVisualStyleBackColor = false;
            this.RefreshStoresBT.Click += new System.EventHandler(this.RefreshStoresBT_Click);
            this.RefreshStoresBT.MouseEnter += new System.EventHandler(this.RefreshStoresBT_MouseEnter);
            this.RefreshStoresBT.MouseLeave += new System.EventHandler(this.RefreshStoresBT_MouseLeave);
            // 
            // SettingsBT
            // 
            this.SettingsBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsBT.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Settings_Icon;
            this.SettingsBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SettingsBT.FlatAppearance.BorderSize = 0;
            this.SettingsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBT.Location = new System.Drawing.Point(601, 8);
            this.SettingsBT.Name = "SettingsBT";
            this.SettingsBT.Size = new System.Drawing.Size(40, 40);
            this.SettingsBT.TabIndex = 25;
            this.SettingsBT.UseVisualStyleBackColor = false;
            this.SettingsBT.Click += new System.EventHandler(this.SettingsBT_Click);
            this.SettingsBT.MouseEnter += new System.EventHandler(this.SettingsBT_MouseEnter);
            this.SettingsBT.MouseLeave += new System.EventHandler(this.SettingsBT_MouseLeave);
            // 
            // AddRepoBT
            // 
            this.AddRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.AddRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.AddRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRepoBT.FlatAppearance.BorderSize = 0;
            this.AddRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRepoBT.Location = new System.Drawing.Point(480, 6);
            this.AddRepoBT.Name = "AddRepoBT";
            this.AddRepoBT.Size = new System.Drawing.Size(45, 45);
            this.AddRepoBT.TabIndex = 21;
            this.AddRepoBT.UseVisualStyleBackColor = false;
            this.AddRepoBT.Click += new System.EventHandler(this.AddRepoBT_Click);
            this.AddRepoBT.MouseEnter += new System.EventHandler(this.AddRepoBT_MouseEnter);
            this.AddRepoBT.MouseLeave += new System.EventHandler(this.AddRepoBT_MouseLeave);
            // 
            // ClearRepoChangesBT
            // 
            this.ClearRepoChangesBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearRepoChangesBT.BackColor = System.Drawing.Color.Transparent;
            this.ClearRepoChangesBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Reset_Settings_Icon;
            this.ClearRepoChangesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearRepoChangesBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearRepoChangesBT.FlatAppearance.BorderSize = 0;
            this.ClearRepoChangesBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearRepoChangesBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearRepoChangesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearRepoChangesBT.Location = new System.Drawing.Point(442, 305);
            this.ClearRepoChangesBT.Name = "ClearRepoChangesBT";
            this.ClearRepoChangesBT.Size = new System.Drawing.Size(35, 35);
            this.ClearRepoChangesBT.TabIndex = 32;
            this.ClearRepoChangesBT.UseVisualStyleBackColor = false;
            this.ClearRepoChangesBT.Click += new System.EventHandler(this.ClearRepoChangesBT_Click);
            this.ClearRepoChangesBT.MouseEnter += new System.EventHandler(this.ClearRepoChangesBT_MouseEnter);
            this.ClearRepoChangesBT.MouseLeave += new System.EventHandler(this.ClearRepoChangesBT_MouseLeave);
            // 
            // SaveRepoChangesBT
            // 
            this.SaveRepoChangesBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveRepoChangesBT.BackColor = System.Drawing.Color.Transparent;
            this.SaveRepoChangesBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Save_Settings_Icon;
            this.SaveRepoChangesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveRepoChangesBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveRepoChangesBT.FlatAppearance.BorderSize = 0;
            this.SaveRepoChangesBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveRepoChangesBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveRepoChangesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveRepoChangesBT.Location = new System.Drawing.Point(7, 305);
            this.SaveRepoChangesBT.Name = "SaveRepoChangesBT";
            this.SaveRepoChangesBT.Size = new System.Drawing.Size(35, 35);
            this.SaveRepoChangesBT.TabIndex = 31;
            this.SaveRepoChangesBT.UseVisualStyleBackColor = false;
            this.SaveRepoChangesBT.Click += new System.EventHandler(this.SaveRepoChangesBT_Click);
            this.SaveRepoChangesBT.MouseEnter += new System.EventHandler(this.SaveRepoChangesBT_MouseEnter);
            this.SaveRepoChangesBT.MouseLeave += new System.EventHandler(this.SaveRepoChangesBT_MouseLeave);
            // 
            // LogsBT
            // 
            this.LogsBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogsBT.BackColor = System.Drawing.Color.Transparent;
            this.LogsBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Log_Icon;
            this.LogsBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogsBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogsBT.FlatAppearance.BorderSize = 0;
            this.LogsBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogsBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsBT.Location = new System.Drawing.Point(61, 192);
            this.LogsBT.Name = "LogsBT";
            this.LogsBT.Size = new System.Drawing.Size(35, 35);
            this.LogsBT.TabIndex = 27;
            this.LogsBT.UseVisualStyleBackColor = false;
            this.LogsBT.Click += new System.EventHandler(this.LogsBT_Click);
            this.LogsBT.MouseEnter += new System.EventHandler(this.LogsBT_MouseEnter);
            this.LogsBT.MouseLeave += new System.EventHandler(this.LogsBT_MouseLeave);
            // 
            // NotesBT
            // 
            this.NotesBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NotesBT.BackColor = System.Drawing.Color.Transparent;
            this.NotesBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Notes_Icon;
            this.NotesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotesBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NotesBT.FlatAppearance.BorderSize = 0;
            this.NotesBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NotesBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NotesBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotesBT.Location = new System.Drawing.Point(59, 150);
            this.NotesBT.Name = "NotesBT";
            this.NotesBT.Size = new System.Drawing.Size(35, 35);
            this.NotesBT.TabIndex = 26;
            this.NotesBT.UseVisualStyleBackColor = false;
            this.NotesBT.Click += new System.EventHandler(this.NotesBT_Click);
            this.NotesBT.MouseEnter += new System.EventHandler(this.NotesBT_MouseEnter);
            this.NotesBT.MouseLeave += new System.EventHandler(this.NotesBT_MouseLeave);
            // 
            // MainViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(866, 483);
            this.MinimumSize = new System.Drawing.Size(834, 483);
            this.Name = "MainViewFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIT Repository Manager";
            this.Load += new System.EventHandler(this.MainViewFRM_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.EditRepoP.ResumeLayout(false);
            this.EditRepoP.PerformLayout();
            this.RepoRightClickCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox StoreLocationCB;
        private NoFocusSelectionRectangleButton CloneRepoBT;
        private NoFocusSelectionRectangleButton AddRepoBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView ReposLV;
        private System.Windows.Forms.ColumnHeader RepoNameCHDR;
        private NoFocusSelectionRectangleButton SettingsBT;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusSSL;
        private System.Windows.Forms.Panel EditRepoP;
        private System.Windows.Forms.TextBox RepoPathTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastCommitMessageTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastCommitTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox RepoStatusCB;
        private NoFocusSelectionRectangleButton LogsBT;
        private NoFocusSelectionRectangleButton NotesBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private NoFocusSelectionRectangleButton ClearRepoChangesBT;
        private NoFocusSelectionRectangleButton SaveRepoChangesBT;
        private NoFocusSelectionRectangleButton RefreshStoresBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NoFocusSelectionRectangleButton OpenStoreBT;
        public System.Windows.Forms.Timer AutoCheckTMR;
        private System.Windows.Forms.ContextMenuStrip RepoRightClickCMS;
        private System.Windows.Forms.ToolStripMenuItem CloneRepoTSMI;
        private System.Windows.Forms.ToolStripMenuItem ViewNotesTSMI;
        private System.Windows.Forms.ToolStripMenuItem ViewLogsTSMI;
    }
}