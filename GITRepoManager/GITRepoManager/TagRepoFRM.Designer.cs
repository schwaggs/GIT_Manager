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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseRepoSourceBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.RepoSourceGB = new System.Windows.Forms.GroupBox();
            this.RepoSourceTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.RepoSourceGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchListIL
            // 
            this.SearchListIL.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SearchListIL.ImageSize = new System.Drawing.Size(16, 16);
            this.SearchListIL.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(150, 275);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 425);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 425);
            this.panel1.TabIndex = 3;
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
            this.BrowseRepoSourceBT.Location = new System.Drawing.Point(546, 54);
            this.BrowseRepoSourceBT.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseRepoSourceBT.Name = "BrowseRepoSourceBT";
            this.BrowseRepoSourceBT.Size = new System.Drawing.Size(70, 79);
            this.BrowseRepoSourceBT.TabIndex = 26;
            this.BrowseRepoSourceBT.UseVisualStyleBackColor = false;
            this.BrowseRepoSourceBT.Click += new System.EventHandler(this.BrowseRepoSourceBT_Click);
            this.BrowseRepoSourceBT.MouseEnter += new System.EventHandler(this.BrowseRepoSourceBT_MouseEnter);
            this.BrowseRepoSourceBT.MouseLeave += new System.EventHandler(this.BrowseRepoSourceBT_MouseLeave);
            // 
            // RepoSourceGB
            // 
            this.RepoSourceGB.Controls.Add(this.RepoSourceTB);
            this.RepoSourceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceGB.Location = new System.Drawing.Point(12, 42);
            this.RepoSourceGB.Margin = new System.Windows.Forms.Padding(4);
            this.RepoSourceGB.Name = "RepoSourceGB";
            this.RepoSourceGB.Padding = new System.Windows.Forms.Padding(4);
            this.RepoSourceGB.Size = new System.Drawing.Size(526, 91);
            this.RepoSourceGB.TabIndex = 27;
            this.RepoSourceGB.TabStop = false;
            this.RepoSourceGB.Text = "Source";
            // 
            // RepoSourceTB
            // 
            this.RepoSourceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoSourceTB.Location = new System.Drawing.Point(8, 31);
            this.RepoSourceTB.Margin = new System.Windows.Forms.Padding(4);
            this.RepoSourceTB.Multiline = true;
            this.RepoSourceTB.Name = "RepoSourceTB";
            this.RepoSourceTB.Size = new System.Drawing.Size(510, 35);
            this.RepoSourceTB.TabIndex = 0;
            this.RepoSourceTB.TextChanged += new System.EventHandler(this.RepoSourceTB_TextChanged);
            // 
            // TagRepoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.RepoSourceGB);
            this.Controls.Add(this.BrowseRepoSourceBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TagRepoFRM";
            this.Text = "Tag Repo";
            this.panel1.ResumeLayout(false);
            this.RepoSourceGB.ResumeLayout(false);
            this.RepoSourceGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList SearchListIL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private NoFocusSelectionRectangleButton BrowseRepoSourceBT;
        private System.Windows.Forms.GroupBox RepoSourceGB;
        private System.Windows.Forms.TextBox RepoSourceTB;
    }
}