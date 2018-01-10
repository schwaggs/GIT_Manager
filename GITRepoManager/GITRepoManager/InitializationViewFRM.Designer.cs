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
            this.ProgressCPB = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // ProgressCPB
            // 
            this.ProgressCPB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgressCPB.AnimationSpeed = 500;
            this.ProgressCPB.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressCPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressCPB.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProgressCPB.InnerMargin = 2;
            this.ProgressCPB.InnerWidth = -1;
            this.ProgressCPB.Location = new System.Drawing.Point(12, -1);
            this.ProgressCPB.MarqueeAnimationSpeed = 2000;
            this.ProgressCPB.Name = "ProgressCPB";
            this.ProgressCPB.OuterColor = System.Drawing.Color.Gray;
            this.ProgressCPB.OuterMargin = -25;
            this.ProgressCPB.OuterWidth = 26;
            this.ProgressCPB.ProgressColor = System.Drawing.Color.Lime;
            this.ProgressCPB.ProgressWidth = 25;
            this.ProgressCPB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgressCPB.Size = new System.Drawing.Size(150, 150);
            this.ProgressCPB.StartAngle = 270;
            this.ProgressCPB.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressCPB.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.ProgressCPB.SubscriptText = "";
            this.ProgressCPB.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressCPB.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.ProgressCPB.SuperscriptText = "";
            this.ProgressCPB.TabIndex = 0;
            this.ProgressCPB.Text = "Initializing";
            this.ProgressCPB.TextMargin = new System.Windows.Forms.Padding(0);
            // 
            // InitializationViewFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(184, 152);
            this.Controls.Add(this.ProgressCPB);
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
            this.Load += new System.EventHandler(this.InitializationViewFRM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProgressCPB;
    }
}