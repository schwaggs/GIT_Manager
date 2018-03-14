namespace GITRepoManager
{
    partial class LogViewer
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
            this.LogNamesLV = new System.Windows.Forms.ListView();
            this.CommitNumberCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommitNumberLB = new System.Windows.Forms.Label();
            this.LogViewerSS = new System.Windows.Forms.StatusStrip();
            this.LogViewerSSLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.RawLogBT = new GITRepoManager.NoFocusSelectionRectangleButton();
            this.LogContentsTB = new System.Windows.Forms.TextBox();
            this.LogViewerSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogNamesLV
            // 
            this.LogNamesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CommitNumberCH});
            this.LogNamesLV.FullRowSelect = true;
            this.LogNamesLV.GridLines = true;
            this.LogNamesLV.Location = new System.Drawing.Point(13, 13);
            this.LogNamesLV.MultiSelect = false;
            this.LogNamesLV.Name = "LogNamesLV";
            this.LogNamesLV.ShowGroups = false;
            this.LogNamesLV.Size = new System.Drawing.Size(211, 352);
            this.LogNamesLV.TabIndex = 0;
            this.LogNamesLV.UseCompatibleStateImageBehavior = false;
            this.LogNamesLV.View = System.Windows.Forms.View.Details;
            this.LogNamesLV.SelectedIndexChanged += new System.EventHandler(this.LogNamesLV_SelectedIndexChanged);
            this.LogNamesLV.Click += new System.EventHandler(this.LogNamesLV_Click);
            // 
            // CommitNumberCH
            // 
            this.CommitNumberCH.Text = "Commit Number";
            this.CommitNumberCH.Width = 207;
            // 
            // CommitNumberLB
            // 
            this.CommitNumberLB.AutoSize = true;
            this.CommitNumberLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommitNumberLB.Location = new System.Drawing.Point(238, 13);
            this.CommitNumberLB.Name = "CommitNumberLB";
            this.CommitNumberLB.Size = new System.Drawing.Size(66, 24);
            this.CommitNumberLB.TabIndex = 1;
            this.CommitNumberLB.Text = "label1";
            // 
            // LogViewerSS
            // 
            this.LogViewerSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogViewerSSLB});
            this.LogViewerSS.Location = new System.Drawing.Point(0, 387);
            this.LogViewerSS.Name = "LogViewerSS";
            this.LogViewerSS.Size = new System.Drawing.Size(808, 22);
            this.LogViewerSS.TabIndex = 27;
            this.LogViewerSS.Text = "statusStrip1";
            // 
            // LogViewerSSLB
            // 
            this.LogViewerSSLB.Name = "LogViewerSSLB";
            this.LogViewerSSLB.Size = new System.Drawing.Size(0, 17);
            // 
            // RawLogBT
            // 
            this.RawLogBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RawLogBT.BackColor = System.Drawing.Color.Transparent;
            this.RawLogBT.BackgroundImage = global::GITRepoManager.Properties.Resources.Select_All_Icon;
            this.RawLogBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RawLogBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RawLogBT.FlatAppearance.BorderSize = 0;
            this.RawLogBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RawLogBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RawLogBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RawLogBT.Location = new System.Drawing.Point(761, 2);
            this.RawLogBT.Name = "RawLogBT";
            this.RawLogBT.Size = new System.Drawing.Size(35, 35);
            this.RawLogBT.TabIndex = 26;
            this.RawLogBT.UseVisualStyleBackColor = false;
            this.RawLogBT.Visible = false;
            this.RawLogBT.Click += new System.EventHandler(this.RawLogBT_Click);
            this.RawLogBT.MouseEnter += new System.EventHandler(this.RawLogBT_MouseEnter);
            this.RawLogBT.MouseLeave += new System.EventHandler(this.RawLogBT_MouseLeave);
            // 
            // LogContentsTB
            // 
            this.LogContentsTB.Location = new System.Drawing.Point(242, 41);
            this.LogContentsTB.Multiline = true;
            this.LogContentsTB.Name = "LogContentsTB";
            this.LogContentsTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogContentsTB.Size = new System.Drawing.Size(554, 324);
            this.LogContentsTB.TabIndex = 28;
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 409);
            this.Controls.Add(this.LogContentsTB);
            this.Controls.Add(this.LogViewerSS);
            this.Controls.Add(this.RawLogBT);
            this.Controls.Add(this.CommitNumberLB);
            this.Controls.Add(this.LogNamesLV);
            this.MaximizeBox = false;
            this.Name = "LogViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogViewer";
            this.Load += new System.EventHandler(this.LogViewer_Load);
            this.LogViewerSS.ResumeLayout(false);
            this.LogViewerSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LogNamesLV;
        private System.Windows.Forms.ColumnHeader CommitNumberCH;
        private System.Windows.Forms.Label CommitNumberLB;
        private NoFocusSelectionRectangleButton RawLogBT;
        private System.Windows.Forms.StatusStrip LogViewerSS;
        private System.Windows.Forms.ToolStripStatusLabel LogViewerSSLB;
        private System.Windows.Forms.TextBox LogContentsTB;
    }
}