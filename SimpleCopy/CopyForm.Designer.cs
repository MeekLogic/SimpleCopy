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
            this.SuspendLayout();
            // 
            // CurrentFile
            // 
            this.CurrentFile.Location = new System.Drawing.Point(11, 38);
            this.CurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(271, 12);
            this.CurrentFile.TabIndex = 1;
            this.CurrentFile.Text = "CurrentFile";
            // 
            // CurrentSize
            // 
            this.CurrentSize.Location = new System.Drawing.Point(288, 38);
            this.CurrentSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(95, 12);
            this.CurrentSize.TabIndex = 2;
            this.CurrentSize.Text = "CurrentSize";
            this.CurrentSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(369, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(308, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 82);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
    }
}