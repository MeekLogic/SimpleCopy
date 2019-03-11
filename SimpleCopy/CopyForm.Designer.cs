namespace SimpleCopy
{
    partial class CopyForm
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
            this.CurrentFile = new System.Windows.Forms.Label();
            this.CurrentSize = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SystemMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentFile
            // 
            this.CurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentFile.Location = new System.Drawing.Point(13, 38);
            this.CurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(447, 48);
            this.CurrentFile.TabIndex = 1;
            this.CurrentFile.Text = "CurrentFile";
            // 
            // CurrentSize
            // 
            this.CurrentSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSize.Location = new System.Drawing.Point(464, 38);
            this.CurrentSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(88, 22);
            this.CurrentSize.TabIndex = 2;
            this.CurrentSize.Text = "CurrentSize";
            this.CurrentSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(14, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(477, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SystemMessage
            // 
            this.SystemMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemMessage.Location = new System.Drawing.Point(15, 97);
            this.SystemMessage.Name = "SystemMessage";
            this.SystemMessage.Size = new System.Drawing.Size(539, 29);
            this.SystemMessage.TabIndex = 6;
            this.SystemMessage.Text = "SystemMessage";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 140);
            this.Controls.Add(this.SystemMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 179);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SystemMessage;
    }
}