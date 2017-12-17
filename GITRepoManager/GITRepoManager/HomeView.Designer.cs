namespace GITRepoManager
{
    partial class HomeView
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
            this.TitleLB = new System.Windows.Forms.Label();
            this.MainPL = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ButtonDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.MoveRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.TagRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DeleteRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.NewRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.MainPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.Location = new System.Drawing.Point(27, 29);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(446, 42);
            this.TitleLB.TabIndex = 1;
            this.TitleLB.Tag = "";
            this.TitleLB.Text = "Repository Management";
            // 
            // MainPL
            // 
            this.MainPL.Controls.Add(this.MoveRepoBT);
            this.MainPL.Controls.Add(this.TagRepoBT);
            this.MainPL.Controls.Add(this.DeleteRepoBT);
            this.MainPL.Controls.Add(this.CloneRepoBT);
            this.MainPL.Controls.Add(this.NewRepoBT);
            this.MainPL.Location = new System.Drawing.Point(29, 92);
            this.MainPL.Name = "MainPL";
            this.MainPL.Size = new System.Drawing.Size(444, 307);
            this.MainPL.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GITRepoManager.Properties.Resources.GitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(479, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonDescriptionSSLB});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ButtonDescriptionSSLB
            // 
            this.ButtonDescriptionSSLB.BackColor = System.Drawing.Color.White;
            this.ButtonDescriptionSSLB.Name = "ButtonDescriptionSSLB";
            this.ButtonDescriptionSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // MoveRepoBT
            // 
            this.MoveRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.MoveIcon;
            this.MoveRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoveRepoBT.FlatAppearance.BorderSize = 0;
            this.MoveRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRepoBT.Location = new System.Drawing.Point(247, 3);
            this.MoveRepoBT.Name = "MoveRepoBT";
            this.MoveRepoBT.Size = new System.Drawing.Size(115, 125);
            this.MoveRepoBT.TabIndex = 16;
            this.MoveRepoBT.UseVisualStyleBackColor = false;
            this.MoveRepoBT.Click += new System.EventHandler(this.MoveRepoBT_Click);
            this.MoveRepoBT.MouseEnter += new System.EventHandler(this.MoveRepoBT_MouseEnter);
            this.MoveRepoBT.MouseLeave += new System.EventHandler(this.MoveRepoBT_MouseLeave);
            // 
            // TagRepoBT
            // 
            this.TagRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TagRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.TagIcon;
            this.TagRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TagRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TagRepoBT.FlatAppearance.BorderSize = 0;
            this.TagRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TagRepoBT.Location = new System.Drawing.Point(182, 134);
            this.TagRepoBT.Name = "TagRepoBT";
            this.TagRepoBT.Size = new System.Drawing.Size(115, 125);
            this.TagRepoBT.TabIndex = 15;
            this.TagRepoBT.UseVisualStyleBackColor = false;
            this.TagRepoBT.Click += new System.EventHandler(this.TagRepoBT_Click);
            this.TagRepoBT.MouseEnter += new System.EventHandler(this.TagRepoBT_MouseEnter);
            this.TagRepoBT.MouseLeave += new System.EventHandler(this.TagRepoBT_MouseLeave);
            // 
            // DeleteRepoBT
            // 
            this.DeleteRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.DeleteIcon;
            this.DeleteRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteRepoBT.FlatAppearance.BorderSize = 0;
            this.DeleteRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRepoBT.Location = new System.Drawing.Point(124, 3);
            this.DeleteRepoBT.Name = "DeleteRepoBT";
            this.DeleteRepoBT.Size = new System.Drawing.Size(115, 125);
            this.DeleteRepoBT.TabIndex = 14;
            this.DeleteRepoBT.UseVisualStyleBackColor = false;
            this.DeleteRepoBT.Click += new System.EventHandler(this.DeleteRepoBT_Click);
            this.DeleteRepoBT.MouseEnter += new System.EventHandler(this.DeleteRepoBT_MouseEnter);
            this.DeleteRepoBT.MouseLeave += new System.EventHandler(this.DeleteRepoBT_MouseLeave);
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
            this.CloneRepoBT.Location = new System.Drawing.Point(61, 134);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(115, 125);
            this.CloneRepoBT.TabIndex = 13;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Click += new System.EventHandler(this.CloneRepoBT_Click);
            this.CloneRepoBT.MouseEnter += new System.EventHandler(this.CloneRepoBT_MouseEnter);
            this.CloneRepoBT.MouseLeave += new System.EventHandler(this.CloneRepoBT_MouseLeave);
            // 
            // NewRepoBT
            // 
            this.NewRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.NewRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewRepoBT.FlatAppearance.BorderSize = 0;
            this.NewRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRepoBT.Location = new System.Drawing.Point(3, 3);
            this.NewRepoBT.Name = "NewRepoBT";
            this.NewRepoBT.Size = new System.Drawing.Size(115, 125);
            this.NewRepoBT.TabIndex = 11;
            this.NewRepoBT.UseVisualStyleBackColor = false;
            this.NewRepoBT.Click += new System.EventHandler(this.NewRepoBT_Click);
            this.NewRepoBT.MouseEnter += new System.EventHandler(this.NewRepoBT_MouseEnter);
            this.NewRepoBT.MouseLeave += new System.EventHandler(this.NewRepoBT_MouseLeave);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPL);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HomeView";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.Panel MainPL;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ButtonDescriptionSSLB;
        private NoFocusSelectionRectangleButton NewRepoBT;
        private NoFocusSelectionRectangleButton MoveRepoBT;
        private NoFocusSelectionRectangleButton TagRepoBT;
        private NoFocusSelectionRectangleButton DeleteRepoBT;
        private NoFocusSelectionRectangleButton CloneRepoBT;
    }
}

