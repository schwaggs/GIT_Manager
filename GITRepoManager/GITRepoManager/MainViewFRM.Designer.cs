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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.MoveRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DeleteRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.AddRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
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
            this.panel1.Controls.Add(this.CloneRepoBT);
            this.panel1.Controls.Add(this.MoveRepoBT);
            this.panel1.Controls.Add(this.DeleteRepoBT);
            this.panel1.Controls.Add(this.AddRepoBT);
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
            this.panel2.Location = new System.Drawing.Point(3, 19);
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
            this.pictureBox1.Location = new System.Drawing.Point(679, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(4, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 358);
            this.panel3.TabIndex = 2;
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
            this.CloneRepoBT.Location = new System.Drawing.Point(592, 18);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(40, 40);
            this.CloneRepoBT.TabIndex = 24;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Visible = false;
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
            this.MoveRepoBT.Location = new System.Drawing.Point(546, 18);
            this.MoveRepoBT.Name = "MoveRepoBT";
            this.MoveRepoBT.Size = new System.Drawing.Size(40, 40);
            this.MoveRepoBT.TabIndex = 23;
            this.MoveRepoBT.UseVisualStyleBackColor = false;
            this.MoveRepoBT.Visible = false;
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
            this.DeleteRepoBT.Location = new System.Drawing.Point(500, 18);
            this.DeleteRepoBT.Name = "DeleteRepoBT";
            this.DeleteRepoBT.Size = new System.Drawing.Size(40, 40);
            this.DeleteRepoBT.TabIndex = 22;
            this.DeleteRepoBT.UseVisualStyleBackColor = false;
            this.DeleteRepoBT.Visible = false;
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
            this.AddRepoBT.Location = new System.Drawing.Point(417, 16);
            this.AddRepoBT.Name = "AddRepoBT";
            this.AddRepoBT.Size = new System.Drawing.Size(45, 45);
            this.AddRepoBT.TabIndex = 21;
            this.AddRepoBT.UseVisualStyleBackColor = false;
            this.AddRepoBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.AddRepoBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.AddRepoBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // MainViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
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
        private NoFocusSelectionRectangleButton CloneRepoBT;
        private NoFocusSelectionRectangleButton MoveRepoBT;
        private NoFocusSelectionRectangleButton DeleteRepoBT;
        private NoFocusSelectionRectangleButton AddRepoBT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel3;
    }
}