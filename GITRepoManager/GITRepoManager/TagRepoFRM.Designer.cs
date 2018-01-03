namespace GITRepoManager
{
    partial class TagRepoFRM
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
            this.SearchListIL = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchResultsP = new System.Windows.Forms.Panel();
            this.TagRepoSS = new System.Windows.Forms.StatusStrip();
            this.TagRepoStatusTB = new System.Windows.Forms.ToolStripStatusLabel();
            this.RepoSourceTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MainViewP = new System.Windows.Forms.Panel();
            this.EditViewP = new System.Windows.Forms.Panel();
            this.TagsLV = new System.Windows.Forms.ListView();
            this.Tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepositoriesLV = new System.Windows.Forms.ListView();
            this.Repositories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewTagP = new System.Windows.Forms.Panel();
            this.TempTagsLV = new System.Windows.Forms.ListView();
            this.TempTagsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewTagTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTagBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.Control1BT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.MainViewBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SelectNoneBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SelectAllBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.EditSelectedBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.SearchResultsP.SuspendLayout();
            this.TagRepoSS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.MainViewP.SuspendLayout();
            this.EditViewP.SuspendLayout();
            this.NewTagP.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchListIL
            // 
            this.SearchListIL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SearchListIL.ImageSize = new System.Drawing.Size(16, 16);
            this.SearchListIL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(112, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 223);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SearchResultsP
            // 
            this.SearchResultsP.AutoSize = true;
            this.SearchResultsP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchResultsP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchResultsP.Controls.Add(this.flowLayoutPanel1);
            this.SearchResultsP.Location = new System.Drawing.Point(2, 177);
            this.SearchResultsP.Margin = new System.Windows.Forms.Padding(2);
            this.SearchResultsP.Name = "SearchResultsP";
            this.SearchResultsP.Size = new System.Drawing.Size(452, 231);
            this.SearchResultsP.TabIndex = 3;
            this.SearchResultsP.Visible = false;
            // 
            // TagRepoSS
            // 
            this.TagRepoSS.BackColor = System.Drawing.Color.White;
            this.TagRepoSS.Dock = System.Windows.Forms.DockStyle.None;
            this.TagRepoSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TagRepoStatusTB});
            this.TagRepoSS.Location = new System.Drawing.Point(13, 90);
            this.TagRepoSS.Name = "TagRepoSS";
            this.TagRepoSS.Size = new System.Drawing.Size(17, 22);
            this.TagRepoSS.SizingGrip = false;
            this.TagRepoSS.TabIndex = 30;
            this.TagRepoSS.Text = "statusStrip1";
            // 
            // TagRepoStatusTB
            // 
            this.TagRepoStatusTB.Name = "TagRepoStatusTB";
            this.TagRepoStatusTB.Size = new System.Drawing.Size(0, 17);
            // 
            // RepoSourceTB
            // 
            this.RepoSourceTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RepoSourceTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.RepoSourceTB.BackColor = System.Drawing.Color.White;
            this.RepoSourceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepoSourceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceTB.HideSelection = false;
            this.RepoSourceTB.Location = new System.Drawing.Point(7, 35);
            this.RepoSourceTB.Name = "RepoSourceTB";
            this.RepoSourceTB.Size = new System.Drawing.Size(372, 29);
            this.RepoSourceTB.TabIndex = 0;
            this.RepoSourceTB.TextChanged += new System.EventHandler(this.RepoSourceTB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RepoSourceTB);
            this.panel1.Controls.Add(this.BrowseRepoSourceBT);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 76);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Source";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(384, 137);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 35);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainViewP
            // 
            this.MainViewP.AutoSize = true;
            this.MainViewP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainViewP.Controls.Add(this.panel1);
            this.MainViewP.Controls.Add(this.SelectNoneBT);
            this.MainViewP.Controls.Add(this.SearchResultsP);
            this.MainViewP.Controls.Add(this.SelectAllBT);
            this.MainViewP.Controls.Add(this.TagRepoSS);
            this.MainViewP.Controls.Add(this.EditSelectedBT);
            this.MainViewP.Controls.Add(this.numericUpDown1);
            this.MainViewP.Location = new System.Drawing.Point(1, 1);
            this.MainViewP.Name = "MainViewP";
            this.MainViewP.Size = new System.Drawing.Size(457, 410);
            this.MainViewP.TabIndex = 34;
            // 
            // EditViewP
            // 
            this.EditViewP.Controls.Add(this.Control1BT);
            this.EditViewP.Controls.Add(this.TagsLV);
            this.EditViewP.Controls.Add(this.RepositoriesLV);
            this.EditViewP.Controls.Add(this.MainViewBT);
            this.EditViewP.Location = new System.Drawing.Point(1, 4);
            this.EditViewP.Name = "EditViewP";
            this.EditViewP.Size = new System.Drawing.Size(457, 404);
            this.EditViewP.TabIndex = 0;
            this.EditViewP.Visible = false;
            // 
            // TagsLV
            // 
            this.TagsLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TagsLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TagsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tags});
            this.TagsLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.TagsLV.FullRowSelect = true;
            this.TagsLV.GridLines = true;
            this.TagsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TagsLV.HideSelection = false;
            this.TagsLV.Location = new System.Drawing.Point(236, 45);
            this.TagsLV.MultiSelect = false;
            this.TagsLV.Name = "TagsLV";
            this.TagsLV.Size = new System.Drawing.Size(214, 355);
            this.TagsLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.TagsLV.TabIndex = 34;
            this.TagsLV.UseCompatibleStateImageBehavior = false;
            this.TagsLV.View = System.Windows.Forms.View.Details;
            this.TagsLV.SelectedIndexChanged += new System.EventHandler(this.TagsLV_SelectedIndexChanged);
            // 
            // Tags
            // 
            this.Tags.Text = "Tags";
            this.Tags.Width = 210;
            // 
            // RepositoriesLV
            // 
            this.RepositoriesLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.RepositoriesLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepositoriesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Repositories});
            this.RepositoriesLV.FullRowSelect = true;
            this.RepositoriesLV.GridLines = true;
            this.RepositoriesLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RepositoriesLV.HideSelection = false;
            this.RepositoriesLV.Location = new System.Drawing.Point(9, 45);
            this.RepositoriesLV.MultiSelect = false;
            this.RepositoriesLV.Name = "RepositoriesLV";
            this.RepositoriesLV.Size = new System.Drawing.Size(221, 355);
            this.RepositoriesLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RepositoriesLV.TabIndex = 33;
            this.RepositoriesLV.UseCompatibleStateImageBehavior = false;
            this.RepositoriesLV.View = System.Windows.Forms.View.Details;
            this.RepositoriesLV.SelectedIndexChanged += new System.EventHandler(this.RepositoriesLV_SelectedIndexChanged);
            // 
            // Repositories
            // 
            this.Repositories.Text = "Repositories";
            this.Repositories.Width = 217;
            // 
            // NewTagP
            // 
            this.NewTagP.AutoSize = true;
            this.NewTagP.Controls.Add(this.TempTagsLV);
            this.NewTagP.Controls.Add(this.NewTagTB);
            this.NewTagP.Controls.Add(this.AddTagBT);
            this.NewTagP.Controls.Add(this.label2);
            this.NewTagP.Location = new System.Drawing.Point(465, 1);
            this.NewTagP.Name = "NewTagP";
            this.NewTagP.Size = new System.Drawing.Size(277, 410);
            this.NewTagP.TabIndex = 35;
            this.NewTagP.Visible = false;
            // 
            // TempTagsLV
            // 
            this.TempTagsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TempTagsColumn});
            this.TempTagsLV.GridLines = true;
            this.TempTagsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.TempTagsLV.Location = new System.Drawing.Point(7, 62);
            this.TempTagsLV.MultiSelect = false;
            this.TempTagsLV.Name = "TempTagsLV";
            this.TempTagsLV.Size = new System.Drawing.Size(264, 341);
            this.TempTagsLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.TempTagsLV.TabIndex = 38;
            this.TempTagsLV.UseCompatibleStateImageBehavior = false;
            this.TempTagsLV.View = System.Windows.Forms.View.Details;
            // 
            // TempTagsColumn
            // 
            this.TempTagsColumn.Text = "";
            // 
            // NewTagTB
            // 
            this.NewTagTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTagTB.Location = new System.Drawing.Point(7, 26);
            this.NewTagTB.Name = "NewTagTB";
            this.NewTagTB.Size = new System.Drawing.Size(226, 26);
            this.NewTagTB.TabIndex = 37;
            this.NewTagTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewTagTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Tag";
            // 
            // AddTagBT
            // 
            this.AddTagBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTagBT.BackColor = System.Drawing.Color.Transparent;
            this.AddTagBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Add_Tag_Icon;
            this.AddTagBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddTagBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddTagBT.FlatAppearance.BorderSize = 0;
            this.AddTagBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddTagBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddTagBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTagBT.Location = new System.Drawing.Point(236, 21);
            this.AddTagBT.Name = "AddTagBT";
            this.AddTagBT.Size = new System.Drawing.Size(35, 35);
            this.AddTagBT.TabIndex = 36;
            this.AddTagBT.UseVisualStyleBackColor = false;
            this.AddTagBT.Click += new System.EventHandler(this.AddTagBT_Click);
            this.AddTagBT.MouseEnter += new System.EventHandler(this.AddTagBT_MouseEnter);
            this.AddTagBT.MouseLeave += new System.EventHandler(this.AddTagBT_MouseLeave);
            // 
            // Control1BT
            // 
            this.Control1BT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Control1BT.BackColor = System.Drawing.Color.Transparent;
            this.Control1BT.BackgroundImage = global::GITRepoManager.Properties.Resources.Add_Tag_Icon;
            this.Control1BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Control1BT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Control1BT.FlatAppearance.BorderSize = 0;
            this.Control1BT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Control1BT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Control1BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Control1BT.Location = new System.Drawing.Point(415, 3);
            this.Control1BT.Name = "Control1BT";
            this.Control1BT.Size = new System.Drawing.Size(35, 35);
            this.Control1BT.TabIndex = 35;
            this.Control1BT.UseVisualStyleBackColor = false;
            this.Control1BT.Visible = false;
            this.Control1BT.Click += new System.EventHandler(this.Control1BT_Click);
            this.Control1BT.MouseEnter += new System.EventHandler(this.Control1BT_MouseEnter);
            this.Control1BT.MouseLeave += new System.EventHandler(this.Control1BT_MouseLeave);
            // 
            // MainViewBT
            // 
            this.MainViewBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainViewBT.BackColor = System.Drawing.Color.Transparent;
            this.MainViewBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Back_Icon;
            this.MainViewBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainViewBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MainViewBT.FlatAppearance.BorderSize = 0;
            this.MainViewBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MainViewBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MainViewBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainViewBT.Location = new System.Drawing.Point(6, 3);
            this.MainViewBT.Name = "MainViewBT";
            this.MainViewBT.Size = new System.Drawing.Size(35, 35);
            this.MainViewBT.TabIndex = 29;
            this.MainViewBT.UseVisualStyleBackColor = false;
            this.MainViewBT.Click += new System.EventHandler(this.MainViewBT_Click);
            this.MainViewBT.MouseEnter += new System.EventHandler(this.MainViewBT_MouseEnter);
            this.MainViewBT.MouseLeave += new System.EventHandler(this.MainViewBT_MouseLeave);
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
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(385, 6);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(52, 64);
            this.BrowseRepoSourceBT.TabIndex = 26;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // SelectNoneBT
            // 
            this.SelectNoneBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectNoneBT.BackColor = System.Drawing.Color.Transparent;
            this.SelectNoneBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Select_None_Icon;
            this.SelectNoneBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectNoneBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectNoneBT.FlatAppearance.BorderSize = 0;
            this.SelectNoneBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SelectNoneBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SelectNoneBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectNoneBT.Location = new System.Drawing.Point(336, 138);
            this.SelectNoneBT.Name = "SelectNoneBT";
            this.SelectNoneBT.Size = new System.Drawing.Size(35, 35);
            this.SelectNoneBT.TabIndex = 27;
            this.SelectNoneBT.UseVisualStyleBackColor = false;
            this.SelectNoneBT.Visible = false;
            this.SelectNoneBT.Click += new System.EventHandler(this.ClearAllBT_Click);
            this.SelectNoneBT.MouseEnter += new System.EventHandler(this.SelectNoneBT_MouseEnter);
            this.SelectNoneBT.MouseLeave += new System.EventHandler(this.SelectNoneBT_MouseLeave);
            // 
            // SelectAllBT
            // 
            this.SelectAllBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectAllBT.BackColor = System.Drawing.Color.Transparent;
            this.SelectAllBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Select_All_Icon;
            this.SelectAllBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectAllBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SelectAllBT.FlatAppearance.BorderSize = 0;
            this.SelectAllBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SelectAllBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SelectAllBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllBT.Location = new System.Drawing.Point(294, 138);
            this.SelectAllBT.Name = "SelectAllBT";
            this.SelectAllBT.Size = new System.Drawing.Size(36, 34);
            this.SelectAllBT.TabIndex = 33;
            this.SelectAllBT.UseVisualStyleBackColor = false;
            this.SelectAllBT.Visible = false;
            this.SelectAllBT.Click += new System.EventHandler(this.SelectAllBT_Click);
            this.SelectAllBT.MouseEnter += new System.EventHandler(this.SelectAllBT_MouseEnter);
            this.SelectAllBT.MouseLeave += new System.EventHandler(this.SelectAllBT_MouseLeave);
            // 
            // EditSelectedBT
            // 
            this.EditSelectedBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditSelectedBT.BackColor = System.Drawing.Color.Transparent;
            this.EditSelectedBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Edit_Icon;
            this.EditSelectedBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditSelectedBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditSelectedBT.FlatAppearance.BorderSize = 0;
            this.EditSelectedBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EditSelectedBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EditSelectedBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSelectedBT.Location = new System.Drawing.Point(13, 138);
            this.EditSelectedBT.Name = "EditSelectedBT";
            this.EditSelectedBT.Size = new System.Drawing.Size(35, 35);
            this.EditSelectedBT.TabIndex = 28;
            this.EditSelectedBT.UseVisualStyleBackColor = false;
            this.EditSelectedBT.Visible = false;
            this.EditSelectedBT.Click += new System.EventHandler(this.EditSelectedBT_Click);
            this.EditSelectedBT.MouseEnter += new System.EventHandler(this.EditSelectedBT_MouseEnter);
            this.EditSelectedBT.MouseLeave += new System.EventHandler(this.EditSelectedBT_MouseLeave);
            // 
            // TagRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.NewTagP);
            this.Controls.Add(this.EditViewP);
            this.Controls.Add(this.MainViewP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TagRepoFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Repo";
            this.Load += new System.EventHandler(this.TagRepoFRM_Load);
            this.SearchResultsP.ResumeLayout(false);
            this.TagRepoSS.ResumeLayout(false);
            this.TagRepoSS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.MainViewP.ResumeLayout(false);
            this.MainViewP.PerformLayout();
            this.EditViewP.ResumeLayout(false);
            this.NewTagP.ResumeLayout(false);
            this.NewTagP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList SearchListIL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel SearchResultsP;
        private System.Windows.Forms.StatusStrip TagRepoSS;
        private System.Windows.Forms.ToolStripStatusLabel TagRepoStatusTB;
        private System.Windows.Forms.TextBox RepoSourceTB;
        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private NoFocusSelectionRectangleButton EditSelectedBT;
        private NoFocusSelectionRectangleButton SelectAllBT;
        private NoFocusSelectionRectangleButton SelectNoneBT;
        private System.Windows.Forms.Panel MainViewP;
        private System.Windows.Forms.Panel EditViewP;
        private NoFocusSelectionRectangleButton MainViewBT;
        private System.Windows.Forms.ListView TagsLV;
        private System.Windows.Forms.ListView RepositoriesLV;
        private System.Windows.Forms.ColumnHeader Repositories;
        private NoFocusSelectionRectangleButton Control1BT;
        private System.Windows.Forms.ColumnHeader Tags;
        private System.Windows.Forms.Panel NewTagP;
        private System.Windows.Forms.TextBox NewTagTB;
        private NoFocusSelectionRectangleButton AddTagBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView TempTagsLV;
        private System.Windows.Forms.ColumnHeader TempTagsColumn;
    }
}