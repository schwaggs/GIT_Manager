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
            this.CloneRepoBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewRepoNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StorePathTB = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloneRepoBT
            // 
            this.CloneRepoBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloneRepoBT.BackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.BackgroundImage = global::GITRepoManager.Properties.Resources.NewIcon;
            this.CloneRepoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloneRepoBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloneRepoBT.FlatAppearance.BorderSize = 0;
            this.CloneRepoBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloneRepoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneRepoBT.Location = new System.Drawing.Point(12, 158);
            this.CloneRepoBT.Name = "CloneRepoBT";
            this.CloneRepoBT.Size = new System.Drawing.Size(35, 35);
            this.CloneRepoBT.TabIndex = 7;
            this.CloneRepoBT.UseVisualStyleBackColor = false;
            this.CloneRepoBT.Click += new System.EventHandler(this.CloneRepoBT_Click);
            this.CloneRepoBT.MouseEnter += new System.EventHandler(this.CloneRepoBT_MouseEnter);
            this.CloneRepoBT.MouseLeave += new System.EventHandler(this.CloneRepoBT_MouseLeave);
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
            // AddRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(435, 205);
            this.Controls.Add(this.CloneRepoBT);
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
        private NoFocusSelectionRectangleButton CloneRepoBT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NewRepoNameTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StorePathTB;
    }
}