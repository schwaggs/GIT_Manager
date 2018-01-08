namespace GITRepoManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.noFocusSelectionRectangleButton1 = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.noFocusSelectionRectangleButton2 = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.noFocusSelectionRectangleButton3 = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.noFocusSelectionRectangleButton4 = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::GITRepoManager.Properties.Resources.BackGradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.noFocusSelectionRectangleButton4);
            this.panel1.Controls.Add(this.noFocusSelectionRectangleButton3);
            this.panel1.Controls.Add(this.noFocusSelectionRectangleButton2);
            this.panel1.Controls.Add(this.noFocusSelectionRectangleButton1);
            this.panel1.Controls.Add(this.BrowseRepoSourceBT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 71);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 40);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Root Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GITRepoManager.Properties.Resources.GitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(704, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BrowseRepoSourceBT
            // 
            this.BrowseRepoSourceBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseRepoSourceBT.BackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.BrowseRepoSourceBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseRepoSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseRepoSourceBT.FlatAppearance.BorderSize = 0;
            this.BrowseRepoSourceBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BrowseRepoSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(394, 8);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(40, 40);
            this.BrowseRepoSourceBT.TabIndex = 21;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // noFocusSelectionRectangleButton1
            // 
            this.noFocusSelectionRectangleButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noFocusSelectionRectangleButton1.BackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.BackgroundImage = global::GITRepoManager.Properties.Resources.DeleteIcon;
            this.noFocusSelectionRectangleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noFocusSelectionRectangleButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noFocusSelectionRectangleButton1.FlatAppearance.BorderSize = 0;
            this.noFocusSelectionRectangleButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusSelectionRectangleButton1.Location = new System.Drawing.Point(443, 8);
            this.noFocusSelectionRectangleButton1.Name = "noFocusSelectionRectangleButton1";
            this.noFocusSelectionRectangleButton1.Size = new System.Drawing.Size(40, 40);
            this.noFocusSelectionRectangleButton1.TabIndex = 22;
            this.noFocusSelectionRectangleButton1.UseVisualStyleBackColor = false;
            // 
            // noFocusSelectionRectangleButton2
            // 
            this.noFocusSelectionRectangleButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noFocusSelectionRectangleButton2.BackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton2.BackgroundImage = global::GITRepoManager.Properties.Resources.MoveIcon;
            this.noFocusSelectionRectangleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noFocusSelectionRectangleButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noFocusSelectionRectangleButton2.FlatAppearance.BorderSize = 0;
            this.noFocusSelectionRectangleButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusSelectionRectangleButton2.Location = new System.Drawing.Point(489, 8);
            this.noFocusSelectionRectangleButton2.Name = "noFocusSelectionRectangleButton2";
            this.noFocusSelectionRectangleButton2.Size = new System.Drawing.Size(40, 40);
            this.noFocusSelectionRectangleButton2.TabIndex = 23;
            this.noFocusSelectionRectangleButton2.UseVisualStyleBackColor = false;
            // 
            // noFocusSelectionRectangleButton3
            // 
            this.noFocusSelectionRectangleButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noFocusSelectionRectangleButton3.BackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton3.BackgroundImage = global::GITRepoManager.Properties.Resources.CloneIcon;
            this.noFocusSelectionRectangleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noFocusSelectionRectangleButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noFocusSelectionRectangleButton3.FlatAppearance.BorderSize = 0;
            this.noFocusSelectionRectangleButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusSelectionRectangleButton3.Location = new System.Drawing.Point(535, 8);
            this.noFocusSelectionRectangleButton3.Name = "noFocusSelectionRectangleButton3";
            this.noFocusSelectionRectangleButton3.Size = new System.Drawing.Size(40, 40);
            this.noFocusSelectionRectangleButton3.TabIndex = 24;
            this.noFocusSelectionRectangleButton3.UseVisualStyleBackColor = false;
            // 
            // noFocusSelectionRectangleButton4
            // 
            this.noFocusSelectionRectangleButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noFocusSelectionRectangleButton4.BackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton4.BackgroundImage = global::GITRepoManager.Properties.Resources.TagIcon;
            this.noFocusSelectionRectangleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noFocusSelectionRectangleButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.noFocusSelectionRectangleButton4.FlatAppearance.BorderSize = 0;
            this.noFocusSelectionRectangleButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.noFocusSelectionRectangleButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noFocusSelectionRectangleButton4.Location = new System.Drawing.Point(581, 8);
            this.noFocusSelectionRectangleButton4.Name = "noFocusSelectionRectangleButton4";
            this.noFocusSelectionRectangleButton4.Size = new System.Drawing.Size(40, 40);
            this.noFocusSelectionRectangleButton4.TabIndex = 25;
            this.noFocusSelectionRectangleButton4.UseVisualStyleBackColor = false;
            // 
            // MainViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.panel1);
            this.Name = "MainViewFRM";
            this.Text = "GIT Repository Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private NoFocusSelectionRectangleButton noFocusSelectionRectangleButton4;
        private NoFocusSelectionRectangleButton noFocusSelectionRectangleButton3;
        private NoFocusSelectionRectangleButton noFocusSelectionRectangleButton2;
        private NoFocusSelectionRectangleButton noFocusSelectionRectangleButton1;
        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
    }
}