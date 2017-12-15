namespace GITRepoManager
{
    partial class Form1
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
            this.LabelRepoBT = new System.Windows.Forms.Button();
            this.CloneRepoBT = new System.Windows.Forms.Button();
            this.MoveRepoBT = new System.Windows.Forms.Button();
            this.DeleteRepoBT = new System.Windows.Forms.Button();
            this.NewRepoBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CommandInfoTB = new System.Windows.Forms.TextBox();
            this.MainPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.Location = new System.Drawing.Point(22, 44);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(446, 42);
            this.TitleLB.TabIndex = 1;
            this.TitleLB.Tag = "";
            this.TitleLB.Text = "Repository Management";
            // 
            // MainPL
            // 
            this.MainPL.Controls.Add(this.LabelRepoBT);
            this.MainPL.Controls.Add(this.CloneRepoBT);
            this.MainPL.Controls.Add(this.MoveRepoBT);
            this.MainPL.Controls.Add(this.DeleteRepoBT);
            this.MainPL.Controls.Add(this.NewRepoBT);
            this.MainPL.Location = new System.Drawing.Point(29, 134);
            this.MainPL.Name = "MainPL";
            this.MainPL.Size = new System.Drawing.Size(439, 262);
            this.MainPL.TabIndex = 2;
            // 
            // LabelRepoBT
            // 
            this.LabelRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.LabelRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.TagIcon;
            this.LabelRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LabelRepoBT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.LabelRepoBT.FlatAppearance.BorderSize = 0;
            this.LabelRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LabelRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LabelRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelRepoBT.Location = new System.Drawing.Point(245, 3);
            this.LabelRepoBT.Name = "LabelRepoBT";
            this.LabelRepoBT.Size = new System.Drawing.Size(115, 125);
            this.LabelRepoBT.TabIndex = 6;
            this.LabelRepoBT.UseVisualStyleBackColor = false;
            this.LabelRepoBT.Click += new System.EventHandler(this.LabelRepoBT_Click);
            this.LabelRepoBT.MouseEnter += new System.EventHandler(this.LabelRepoBT_MouseEnter);
            this.LabelRepoBT.MouseLeave += new System.EventHandler(this.LabelRepoBT_MouseLeave);
            // 
            // CloneRepoBT
            // 
            this.CloneRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.CloneIcon;
            this.CloneRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloneRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CloneRepoBT.FlatAppearance.BorderSize = 0;
            this.CloneRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneRepoBT.ForeColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.Location = new System.Drawing.Point(124, 134);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(115, 125);
            this.CloneRepoBT.TabIndex = 5;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Click += new System.EventHandler(this.CloneRepoBT_Click);
            this.CloneRepoBT.Paint += new System.Windows.Forms.PaintEventHandler(this.CloneRepoBT_Paint);
            this.CloneRepoBT.MouseEnter += new System.EventHandler(this.CloneRepoBT_MouseEnter);
            this.CloneRepoBT.MouseLeave += new System.EventHandler(this.CloneRepoBT_MouseLeave);
            // 
            // MoveRepoBT
            // 
            this.MoveRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.MoveIcon;
            this.MoveRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveRepoBT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.MoveRepoBT.FlatAppearance.BorderSize = 0;
            this.MoveRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MoveRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRepoBT.Location = new System.Drawing.Point(3, 134);
            this.MoveRepoBT.Name = "MoveRepoBT";
            this.MoveRepoBT.Size = new System.Drawing.Size(115, 125);
            this.MoveRepoBT.TabIndex = 4;
            this.MoveRepoBT.UseVisualStyleBackColor = false;
            this.MoveRepoBT.Click += new System.EventHandler(this.MoveRepoBT_Click);
            this.MoveRepoBT.Paint += new System.Windows.Forms.PaintEventHandler(this.MoveRepoBT_Paint);
            this.MoveRepoBT.MouseEnter += new System.EventHandler(this.MoveRepoBT_MouseEnter);
            this.MoveRepoBT.MouseLeave += new System.EventHandler(this.MoveRepoBT_MouseLeave);
            // 
            // DeleteRepoBT
            // 
            this.DeleteRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.DeleteIcon;
            this.DeleteRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRepoBT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.DeleteRepoBT.FlatAppearance.BorderSize = 0;
            this.DeleteRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRepoBT.Location = new System.Drawing.Point(124, 3);
            this.DeleteRepoBT.Name = "DeleteRepoBT";
            this.DeleteRepoBT.Size = new System.Drawing.Size(115, 125);
            this.DeleteRepoBT.TabIndex = 3;
            this.DeleteRepoBT.UseVisualStyleBackColor = false;
            this.DeleteRepoBT.Click += new System.EventHandler(this.DeleteRepoBT_Click);
            this.DeleteRepoBT.Paint += new System.Windows.Forms.PaintEventHandler(this.DeleteRepoBT_Paint);
            this.DeleteRepoBT.MouseEnter += new System.EventHandler(this.DeleteRepoBT_MouseEnter);
            this.DeleteRepoBT.MouseLeave += new System.EventHandler(this.DeleteRepoBT_MouseLeave);
            // 
            // NewRepoBT
            // 
            this.NewRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.NewRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewRepoBT.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.NewRepoBT.FlatAppearance.BorderSize = 0;
            this.NewRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRepoBT.Location = new System.Drawing.Point(3, 3);
            this.NewRepoBT.Name = "NewRepoBT";
            this.NewRepoBT.Size = new System.Drawing.Size(115, 125);
            this.NewRepoBT.TabIndex = 2;
            this.NewRepoBT.UseVisualStyleBackColor = false;
            this.NewRepoBT.Click += new System.EventHandler(this.NewRepoBT_Click);
            this.NewRepoBT.Paint += new System.Windows.Forms.PaintEventHandler(this.NewRepoBT_Paint);
            this.NewRepoBT.MouseEnter += new System.EventHandler(this.NewRepoBT_MouseEnter);
            this.NewRepoBT.MouseLeave += new System.EventHandler(this.NewRepoBT_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GITRepoManager.Properties.Resources.GitLogo;
            this.pictureBox1.Location = new System.Drawing.Point(479, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CommandInfoTB
            // 
            this.CommandInfoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandInfoTB.Location = new System.Drawing.Point(479, 134);
            this.CommandInfoTB.Multiline = true;
            this.CommandInfoTB.Name = "CommandInfoTB";
            this.CommandInfoTB.ReadOnly = true;
            this.CommandInfoTB.Size = new System.Drawing.Size(170, 262);
            this.CommandInfoTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 411);
            this.Controls.Add(this.CommandInfoTB);
            this.Controls.Add(this.MainPL);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.Panel MainPL;
        private System.Windows.Forms.Button LabelRepoBT;
        private System.Windows.Forms.Button CloneRepoBT;
        private System.Windows.Forms.Button MoveRepoBT;
        private System.Windows.Forms.Button DeleteRepoBT;
        private System.Windows.Forms.Button NewRepoBT;
        private System.Windows.Forms.TextBox CommandInfoTB;
    }
}

