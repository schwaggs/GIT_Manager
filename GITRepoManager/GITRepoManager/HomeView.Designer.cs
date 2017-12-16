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
            this.label1 = new System.Windows.Forms.Label();
            this.noFocusSelectionRectangleButton1 = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ButtonDescriptionSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.Location = new System.Drawing.Point(27, 27);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(446, 42);
            this.TitleLB.TabIndex = 1;
            this.TitleLB.Tag = "";
            this.TitleLB.Text = "Repository Management";
            // 
            // MainPL
            // 
            this.MainPL.Controls.Add(this.label1);
            this.MainPL.Controls.Add(this.noFocusSelectionRectangleButton1);
            this.MainPL.Location = new System.Drawing.Point(29, 92);
            this.MainPL.Name = "MainPL";
            this.MainPL.Size = new System.Drawing.Size(620, 304);
            this.MainPL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Custom Button";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // noFocusSelectionRectangleButton1
            // 
            this.noFocusSelectionRectangleButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noFocusSelectionRectangleButton1.BackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.BackgroundImage = global::GITRepoManager.Properties.Resources.MoveIcon;
            this.noFocusSelectionRectangleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noFocusSelectionRectangleButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noFocusSelectionRectangleButton1.FlatAppearance.BorderSize = 0;
            this.noFocusSelectionRectangleButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusSelectionRectangleButton1.Location = new System.Drawing.Point(0, 3);
            this.noFocusSelectionRectangleButton1.Name = "noFocusSelectionRectangleButton1";
            this.noFocusSelectionRectangleButton1.Size = new System.Drawing.Size(115, 125);
            this.noFocusSelectionRectangleButton1.TabIndex = 11;
            this.noFocusSelectionRectangleButton1.UseVisualStyleBackColor = false;
            this.noFocusSelectionRectangleButton1.Click += new System.EventHandler(this.noFocusSelectionRectangleButton1_Click);
            this.noFocusSelectionRectangleButton1.MouseEnter += new System.EventHandler(this.noFocusSelectionRectangleButton1_MouseEnter);
            this.noFocusSelectionRectangleButton1.MouseLeave += new System.EventHandler(this.noFocusSelectionRectangleButton1_MouseLeave);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
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
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPL);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HomeView";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPL.ResumeLayout(false);
            this.MainPL.PerformLayout();
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
        private NoFocusSelectionRectangleButton noFocusSelectionRectangleButton1;
        private System.Windows.Forms.Label label1;
    }
}

