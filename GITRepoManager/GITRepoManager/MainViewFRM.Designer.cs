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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonLayoutTBLT = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NewRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.MoveRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoLogBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.DeleteRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.TagRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ButtonLayoutTBLT.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ButtonLayoutTBLT);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 58);
            this.panel1.TabIndex = 0;
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
            this.pictureBox1.Size = new System.Drawing.Size(103, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonLayoutTBLT
            // 
            this.ButtonLayoutTBLT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLayoutTBLT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLayoutTBLT.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLayoutTBLT.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.ButtonLayoutTBLT.ColumnCount = 6;
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonLayoutTBLT.Controls.Add(this.NewRepoBT, 0, 0);
            this.ButtonLayoutTBLT.Controls.Add(this.MoveRepoBT, 5, 0);
            this.ButtonLayoutTBLT.Controls.Add(this.RepoLogBT, 4, 0);
            this.ButtonLayoutTBLT.Controls.Add(this.DeleteRepoBT, 1, 0);
            this.ButtonLayoutTBLT.Controls.Add(this.CloneRepoBT, 2, 0);
            this.ButtonLayoutTBLT.Controls.Add(this.TagRepoBT, 3, 0);
            this.ButtonLayoutTBLT.Location = new System.Drawing.Point(403, 9);
            this.ButtonLayoutTBLT.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.ButtonLayoutTBLT.Name = "ButtonLayoutTBLT";
            this.ButtonLayoutTBLT.RowCount = 1;
            this.ButtonLayoutTBLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonLayoutTBLT.Size = new System.Drawing.Size(281, 39);
            this.ButtonLayoutTBLT.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 39);
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
            // NewRepoBT
            // 
            this.NewRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.NewRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewRepoBT.Enabled = false;
            this.NewRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewRepoBT.FlatAppearance.BorderSize = 0;
            this.NewRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRepoBT.Location = new System.Drawing.Point(10, 5);
            this.NewRepoBT.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.NewRepoBT.Name = "NewRepoBT";
            this.NewRepoBT.Size = new System.Drawing.Size(30, 29);
            this.NewRepoBT.TabIndex = 18;
            this.NewRepoBT.UseVisualStyleBackColor = false;
            // 
            // MoveRepoBT
            // 
            this.MoveRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoveRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.MoveIcon;
            this.MoveRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveRepoBT.Enabled = false;
            this.MoveRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MoveRepoBT.FlatAppearance.BorderSize = 0;
            this.MoveRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRepoBT.Location = new System.Drawing.Point(245, 5);
            this.MoveRepoBT.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.MoveRepoBT.Name = "MoveRepoBT";
            this.MoveRepoBT.Size = new System.Drawing.Size(30, 29);
            this.MoveRepoBT.TabIndex = 22;
            this.MoveRepoBT.UseVisualStyleBackColor = false;
            // 
            // RepoLogBT
            // 
            this.RepoLogBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RepoLogBT.BackColor = System.Drawing.Color.Transparent;
            this.RepoLogBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Log_Icon;
            this.RepoLogBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RepoLogBT.Enabled = false;
            this.RepoLogBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RepoLogBT.FlatAppearance.BorderSize = 0;
            this.RepoLogBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RepoLogBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RepoLogBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepoLogBT.Location = new System.Drawing.Point(197, 5);
            this.RepoLogBT.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.RepoLogBT.Name = "RepoLogBT";
            this.RepoLogBT.Size = new System.Drawing.Size(30, 29);
            this.RepoLogBT.TabIndex = 23;
            this.RepoLogBT.UseVisualStyleBackColor = false;
            // 
            // DeleteRepoBT
            // 
            this.DeleteRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.DeleteIcon;
            this.DeleteRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRepoBT.Enabled = false;
            this.DeleteRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteRepoBT.FlatAppearance.BorderSize = 0;
            this.DeleteRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRepoBT.Location = new System.Drawing.Point(58, 5);
            this.DeleteRepoBT.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.DeleteRepoBT.Name = "DeleteRepoBT";
            this.DeleteRepoBT.Size = new System.Drawing.Size(30, 29);
            this.DeleteRepoBT.TabIndex = 20;
            this.DeleteRepoBT.UseVisualStyleBackColor = false;
            // 
            // CloneRepoBT
            // 
            this.CloneRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloneRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.CloneIcon;
            this.CloneRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloneRepoBT.Enabled = false;
            this.CloneRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloneRepoBT.FlatAppearance.BorderSize = 0;
            this.CloneRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneRepoBT.Location = new System.Drawing.Point(106, 5);
            this.CloneRepoBT.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(30, 29);
            this.CloneRepoBT.TabIndex = 19;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            // 
            // TagRepoBT
            // 
            this.TagRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TagRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.TagIcon;
            this.TagRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TagRepoBT.Enabled = false;
            this.TagRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TagRepoBT.FlatAppearance.BorderSize = 0;
            this.TagRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TagRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TagRepoBT.Location = new System.Drawing.Point(149, 5);
            this.TagRepoBT.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.TagRepoBT.Name = "TagRepoBT";
            this.TagRepoBT.Size = new System.Drawing.Size(30, 29);
            this.TagRepoBT.TabIndex = 21;
            this.TagRepoBT.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ButtonLayoutTBLT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NoFocusSelectionRectangleButton RepoLogBT;
        private NoFocusSelectionRectangleButton MoveRepoBT;
        private NoFocusSelectionRectangleButton TagRepoBT;
        private NoFocusSelectionRectangleButton DeleteRepoBT;
        private NoFocusSelectionRectangleButton CloneRepoBT;
        private NoFocusSelectionRectangleButton NewRepoBT;
        private System.Windows.Forms.TableLayoutPanel ButtonLayoutTBLT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}