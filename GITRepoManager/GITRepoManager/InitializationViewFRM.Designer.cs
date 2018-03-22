namespace GITRepoManager
{
    partial class InitializationViewFRM
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
            this.ProgressBarIncrT = new System.Windows.Forms.Timer(this.components);
            this.RootsBGW = new System.ComponentModel.BackgroundWorker();
            this.ReposBGW = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VerifyConfigCheckPB = new System.Windows.Forms.PictureBox();
            this.ReadConfigPB = new System.Windows.Forms.PictureBox();
            this.ChangesPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VerifyConfigCheckPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadConfigPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangesPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarIncrT
            // 
            this.ProgressBarIncrT.Enabled = true;
            this.ProgressBarIncrT.Interval = 50;
            // 
            // RootsBGW
            // 
            this.RootsBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RootsBGW_DoWork);
            this.RootsBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RootsBGW_ProgressChanged);
            this.RootsBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RootsBGW_RunWorkerCompleted);
            // 
            // ReposBGW
            // 
            this.ReposBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReposBGW_DoWork);
            this.ReposBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ReposBGW_ProgressChanged);
            this.ReposBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ReposBGW_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verify Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Read Configuration File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check For Changes";
            // 
            // VerifyConfigCheckPB
            // 
            this.VerifyConfigCheckPB.BackgroundImage = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.VerifyConfigCheckPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyConfigCheckPB.InitialImage = null;
            this.VerifyConfigCheckPB.Location = new System.Drawing.Point(233, 9);
            this.VerifyConfigCheckPB.Name = "VerifyConfigCheckPB";
            this.VerifyConfigCheckPB.Size = new System.Drawing.Size(33, 30);
            this.VerifyConfigCheckPB.TabIndex = 3;
            this.VerifyConfigCheckPB.TabStop = false;
            // 
            // ReadConfigPB
            // 
            this.ReadConfigPB.BackgroundImage = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ReadConfigPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReadConfigPB.Image = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ReadConfigPB.InitialImage = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ReadConfigPB.Location = new System.Drawing.Point(233, 49);
            this.ReadConfigPB.Name = "ReadConfigPB";
            this.ReadConfigPB.Size = new System.Drawing.Size(33, 30);
            this.ReadConfigPB.TabIndex = 4;
            this.ReadConfigPB.TabStop = false;
            // 
            // ChangesPB
            // 
            this.ChangesPB.BackgroundImage = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ChangesPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangesPB.Image = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ChangesPB.InitialImage = global::GITRepoManager.Properties.Resources.ConfigCheck_Default;
            this.ChangesPB.Location = new System.Drawing.Point(233, 94);
            this.ChangesPB.Name = "ChangesPB";
            this.ChangesPB.Size = new System.Drawing.Size(33, 30);
            this.ChangesPB.TabIndex = 5;
            this.ChangesPB.TabStop = false;
            // 
            // InitializationViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(280, 135);
            this.Controls.Add(this.ChangesPB);
            this.Controls.Add(this.ReadConfigPB);
            this.Controls.Add(this.VerifyConfigCheckPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitializationViewFRM";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Manager Initialization";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitializationViewFRM_FormClosing);
            this.Load += new System.EventHandler(this.InitializationViewFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VerifyConfigCheckPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadConfigPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangesPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ProgressBarIncrT;
        private System.ComponentModel.BackgroundWorker RootsBGW;
        private System.ComponentModel.BackgroundWorker ReposBGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox VerifyConfigCheckPB;
        private System.Windows.Forms.PictureBox ReadConfigPB;
        private System.Windows.Forms.PictureBox ChangesPB;
    }
}