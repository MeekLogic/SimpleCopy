namespace SimpleCopy
{
    partial class CopyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentFile = new System.Windows.Forms.Label();
            this.CurrentSize = new System.Windows.Forms.Label();
            this.CurrentFileProgress = new System.Windows.Forms.ProgressBar();
            this.PauseResumeButton = new System.Windows.Forms.Button();
            this.SystemMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentFile
            // 
            this.CurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentFile.Location = new System.Drawing.Point(24, 70);
            this.CurrentFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(820, 89);
            this.CurrentFile.TabIndex = 1;
            this.CurrentFile.Text = "CurrentFile";
            // 
            // CurrentSize
            // 
            this.CurrentSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSize.Location = new System.Drawing.Point(851, 70);
            this.CurrentSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(161, 41);
            this.CurrentSize.TabIndex = 2;
            this.CurrentSize.Text = "CurrentSize";
            this.CurrentSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CurrentFileProgress
            // 
            this.CurrentFileProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentFileProgress.Location = new System.Drawing.Point(26, 22);
            this.CurrentFileProgress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CurrentFileProgress.Name = "CurrentFileProgress";
            this.CurrentFileProgress.Size = new System.Drawing.Size(986, 42);
            this.CurrentFileProgress.Step = 1;
            this.CurrentFileProgress.TabIndex = 3;
            // 
            // PauseResumeButton
            // 
            this.PauseResumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseResumeButton.Enabled = false;
            this.PauseResumeButton.Location = new System.Drawing.Point(875, 116);
            this.PauseResumeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PauseResumeButton.Name = "PauseResumeButton";
            this.PauseResumeButton.Size = new System.Drawing.Size(138, 42);
            this.PauseResumeButton.TabIndex = 5;
            this.PauseResumeButton.Text = "Pause";
            this.PauseResumeButton.UseVisualStyleBackColor = true;
            this.PauseResumeButton.Click += new System.EventHandler(this.PauseResumeButton_Click);
            // 
            // SystemMessage
            // 
            this.SystemMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemMessage.Location = new System.Drawing.Point(28, 179);
            this.SystemMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SystemMessage.Name = "SystemMessage";
            this.SystemMessage.Size = new System.Drawing.Size(988, 54);
            this.SystemMessage.TabIndex = 6;
            this.SystemMessage.Text = "SystemMessage";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 258);
            this.Controls.Add(this.SystemMessage);
            this.Controls.Add(this.PauseResumeButton);
            this.Controls.Add(this.CurrentFileProgress);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(567, 276);
            this.Name = "CopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copying...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CopyForm_FormClosing);
            this.Load += new System.EventHandler(this.CopyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CurrentFile;
        private System.Windows.Forms.Label CurrentSize;
        private System.Windows.Forms.ProgressBar CurrentFileProgress;
        private System.Windows.Forms.Button PauseResumeButton;
        private System.Windows.Forms.Label SystemMessage;
    }
}