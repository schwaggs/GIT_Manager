namespace GITRepoManager
{
    partial class NewRepoFRM
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
            this.RepoNameTB = new System.Windows.Forms.TextBox();
            this.RepoNameGB = new System.Windows.Forms.GroupBox();
            this.RepoLocationGB = new System.Windows.Forms.GroupBox();
            this.RepoLocationTB = new System.Windows.Forms.TextBox();
            this.OptionBareCB = new System.Windows.Forms.CheckBox();
            this.OptionReadmeCB = new System.Windows.Forms.CheckBox();
            this.NewRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoNameGB.SuspendLayout();
            this.RepoLocationGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepoNameTB
            // 
            this.RepoNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoNameTB.Location = new System.Drawing.Point(10, 29);
            this.RepoNameTB.Multiline = true;
            this.RepoNameTB.Name = "RepoNameTB";
            this.RepoNameTB.Size = new System.Drawing.Size(402, 29);
            this.RepoNameTB.TabIndex = 0;
            // 
            // RepoNameGB
            // 
            this.RepoNameGB.Controls.Add(this.RepoNameTB);
            this.RepoNameGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoNameGB.Location = new System.Drawing.Point(12, 12);
            this.RepoNameGB.Name = "RepoNameGB";
            this.RepoNameGB.Size = new System.Drawing.Size(421, 73);
            this.RepoNameGB.TabIndex = 1;
            this.RepoNameGB.TabStop = false;
            this.RepoNameGB.Text = "Name";
            // 
            // RepoLocationGB
            // 
            this.RepoLocationGB.Controls.Add(this.RepoLocationTB);
            this.RepoLocationGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationGB.Location = new System.Drawing.Point(12, 104);
            this.RepoLocationGB.Name = "RepoLocationGB";
            this.RepoLocationGB.Size = new System.Drawing.Size(421, 73);
            this.RepoLocationGB.TabIndex = 2;
            this.RepoLocationGB.TabStop = false;
            this.RepoLocationGB.Text = "Location";
            // 
            // RepoLocationTB
            // 
            this.RepoLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoLocationTB.Location = new System.Drawing.Point(10, 29);
            this.RepoLocationTB.Multiline = true;
            this.RepoLocationTB.Name = "RepoLocationTB";
            this.RepoLocationTB.Size = new System.Drawing.Size(402, 29);
            this.RepoLocationTB.TabIndex = 0;
            // 
            // OptionBareCB
            // 
            this.OptionBareCB.AutoSize = true;
            this.OptionBareCB.Location = new System.Drawing.Point(12, 184);
            this.OptionBareCB.Name = "OptionBareCB";
            this.OptionBareCB.Size = new System.Drawing.Size(48, 17);
            this.OptionBareCB.TabIndex = 3;
            this.OptionBareCB.Text = "Bare";
            this.OptionBareCB.UseVisualStyleBackColor = true;
            // 
            // OptionReadmeCB
            // 
            this.OptionReadmeCB.AutoSize = true;
            this.OptionReadmeCB.Location = new System.Drawing.Point(66, 184);
            this.OptionReadmeCB.Name = "OptionReadmeCB";
            this.OptionReadmeCB.Size = new System.Drawing.Size(66, 17);
            this.OptionReadmeCB.TabIndex = 4;
            this.OptionReadmeCB.Text = "Readme";
            this.OptionReadmeCB.UseVisualStyleBackColor = true;
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
            this.NewRepoBT.Location = new System.Drawing.Point(454, 70);
            this.NewRepoBT.Name = "NewRepoBT";
            this.NewRepoBT.Size = new System.Drawing.Size(56, 63);
            this.NewRepoBT.TabIndex = 12;
            this.NewRepoBT.UseVisualStyleBackColor = false;
            this.NewRepoBT.Click += new System.EventHandler(this.NewRepoBT_Click);
            this.NewRepoBT.MouseEnter += new System.EventHandler(this.NewRepoBT_MouseEnter);
            this.NewRepoBT.MouseLeave += new System.EventHandler(this.NewRepoBT_MouseLeave);
            // 
            // NewRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 213);
            this.Controls.Add(this.NewRepoBT);
            this.Controls.Add(this.OptionReadmeCB);
            this.Controls.Add(this.OptionBareCB);
            this.Controls.Add(this.RepoLocationGB);
            this.Controls.Add(this.RepoNameGB);
            this.Name = "NewRepoFRM";
            this.Text = "New Repo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewRepoFRM_FormClosing);
            this.RepoNameGB.ResumeLayout(false);
            this.RepoNameGB.PerformLayout();
            this.RepoLocationGB.ResumeLayout(false);
            this.RepoLocationGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RepoNameTB;
        private System.Windows.Forms.GroupBox RepoNameGB;
        private System.Windows.Forms.GroupBox RepoLocationGB;
        private System.Windows.Forms.TextBox RepoLocationTB;
        private System.Windows.Forms.CheckBox OptionBareCB;
        private System.Windows.Forms.CheckBox OptionReadmeCB;
        private NoFocusSelectionRectangleButton NewRepoBT;
    }
}