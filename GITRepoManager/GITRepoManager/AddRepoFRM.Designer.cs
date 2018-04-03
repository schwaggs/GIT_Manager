namespace GITRepoManager
{
    partial class AddRepoFRM
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
            this.AddRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewRepoNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StorePathTB = new System.Windows.Forms.TextBox();
            this.AddingPB = new System.Windows.Forms.ProgressBar();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.AddRepoBT.Location = new System.Drawing.Point(12, 158);
            this.AddRepoBT.Name = "AddRepoBT";
            this.AddRepoBT.Size = new System.Drawing.Size(35, 35);
            this.AddRepoBT.TabIndex = 7;
            this.AddRepoBT.UseVisualStyleBackColor = false;
            this.AddRepoBT.Click += new System.EventHandler(this.AddRepoBT_Click);
            this.AddRepoBT.MouseEnter += new System.EventHandler(this.AddRepoBT_MouseEnter);
            this.AddRepoBT.MouseLeave += new System.EventHandler(this.AddRepoBT_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NewRepoNameTB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 57);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Repository Name";
            // 
            // NewRepoNameTB
            // 
            this.NewRepoNameTB.Location = new System.Drawing.Point(7, 25);
            this.NewRepoNameTB.Name = "NewRepoNameTB";
            this.NewRepoNameTB.Size = new System.Drawing.Size(399, 26);
            this.NewRepoNameTB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StorePathTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store Path";
            // 
            // StorePathTB
            // 
            this.StorePathTB.Location = new System.Drawing.Point(7, 25);
            this.StorePathTB.Name = "StorePathTB";
            this.StorePathTB.ReadOnly = true;
            this.StorePathTB.Size = new System.Drawing.Size(399, 26);
            this.StorePathTB.TabIndex = 4;
            // 
            // AddingPB
            // 
            this.AddingPB.Location = new System.Drawing.Point(53, 163);
            this.AddingPB.Name = "AddingPB";
            this.AddingPB.Size = new System.Drawing.Size(364, 26);
            this.AddingPB.TabIndex = 8;
            this.AddingPB.Visible = false;
            // 
            // AddRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(435, 205);
            this.Controls.Add(this.AddingPB);
            this.Controls.Add(this.AddRepoBT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRepoFRM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Repository";
            this.Load += new System.EventHandler(this.AddRepoFRM_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NoFocusSelectionRectangleButton AddRepoBT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NewRepoNameTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StorePathTB;
        private System.Windows.Forms.ProgressBar AddingPB;
    }
}