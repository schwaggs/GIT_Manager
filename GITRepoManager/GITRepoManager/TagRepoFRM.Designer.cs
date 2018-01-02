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
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ClearAllBT = new System.Windows.Forms.Button();
            this.SelectAllBT = new System.Windows.Forms.Button();
            this.SearchResultsP.SuspendLayout();
            this.TagRepoSS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(112, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 443);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SearchResultsP
            // 
            this.SearchResultsP.AutoSize = true;
            this.SearchResultsP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchResultsP.Controls.Add(this.flowLayoutPanel1);
            this.SearchResultsP.Location = new System.Drawing.Point(12, 136);
            this.SearchResultsP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchResultsP.Name = "SearchResultsP";
            this.SearchResultsP.Size = new System.Drawing.Size(451, 459);
            this.SearchResultsP.TabIndex = 3;
            this.SearchResultsP.Visible = false;
            // 
            // TagRepoSS
            // 
            this.TagRepoSS.BackColor = System.Drawing.Color.White;
            this.TagRepoSS.Dock = System.Windows.Forms.DockStyle.None;
            this.TagRepoSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TagRepoStatusTB});
            this.TagRepoSS.Location = new System.Drawing.Point(2, 82);
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
            this.RepoSourceTB.Size = new System.Drawing.Size(384, 29);
            this.RepoSourceTB.TabIndex = 0;
            this.RepoSourceTB.TextChanged += new System.EventHandler(this.RepoSourceTB_TextChanged);
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
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(397, 6);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(52, 64);
            this.BrowseRepoSourceBT.TabIndex = 26;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RepoSourceTB);
            this.panel1.Controls.Add(this.BrowseRepoSourceBT);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 76);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Source";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(409, 111);
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
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ClearAllBT
            // 
            this.ClearAllBT.Location = new System.Drawing.Point(361, 111);
            this.ClearAllBT.Name = "ClearAllBT";
            this.ClearAllBT.Size = new System.Drawing.Size(42, 23);
            this.ClearAllBT.TabIndex = 33;
            this.ClearAllBT.Text = "None";
            this.ClearAllBT.UseVisualStyleBackColor = true;
            this.ClearAllBT.Visible = false;
            this.ClearAllBT.Click += new System.EventHandler(this.ClearAllBT_Click);
            // 
            // SelectAllBT
            // 
            this.SelectAllBT.Location = new System.Drawing.Point(329, 111);
            this.SelectAllBT.Name = "SelectAllBT";
            this.SelectAllBT.Size = new System.Drawing.Size(26, 23);
            this.SelectAllBT.TabIndex = 34;
            this.SelectAllBT.Text = "All";
            this.SelectAllBT.UseVisualStyleBackColor = true;
            this.SelectAllBT.Visible = false;
            this.SelectAllBT.Click += new System.EventHandler(this.SelectAllBT_Click);
            // 
            // TagRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 629);
            this.Controls.Add(this.SelectAllBT);
            this.Controls.Add(this.ClearAllBT);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TagRepoSS);
            this.Controls.Add(this.SearchResultsP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TagRepoFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TagRepoFRM_Load);
            this.SearchResultsP.ResumeLayout(false);
            this.TagRepoSS.ResumeLayout(false);
            this.TagRepoSS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button ClearAllBT;
        private System.Windows.Forms.Button SelectAllBT;
    }
}