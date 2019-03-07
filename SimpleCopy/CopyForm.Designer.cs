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
            this.CurrentOperation = new System.Windows.Forms.Label();
            this.CurrentFile = new System.Windows.Forms.Label();
            this.CurrentSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentOperation
            // 
            this.CurrentOperation.Location = new System.Drawing.Point(44, 31);
            this.CurrentOperation.Name = "CurrentOperation";
            this.CurrentOperation.Size = new System.Drawing.Size(678, 23);
            this.CurrentOperation.TabIndex = 0;
            this.CurrentOperation.Text = "CurrentOperation";
            // 
            // CurrentFile
            // 
            this.CurrentFile.Location = new System.Drawing.Point(44, 72);
            this.CurrentFile.Name = "CurrentFile";
            this.CurrentFile.Size = new System.Drawing.Size(678, 23);
            this.CurrentFile.TabIndex = 1;
            this.CurrentFile.Text = "CurrentFile";
            // 
            // CurrentSize
            // 
            this.CurrentSize.Location = new System.Drawing.Point(44, 116);
            this.CurrentSize.Name = "CurrentSize";
            this.CurrentSize.Size = new System.Drawing.Size(678, 23);
            this.CurrentSize.TabIndex = 2;
            this.CurrentSize.Text = "CurrentSize";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 228);
            this.Controls.Add(this.CurrentSize);
            this.Controls.Add(this.CurrentFile);
            this.Controls.Add(this.CurrentOperation);
            this.Name = "CopyForm";
            this.Text = "Copying...";
            this.Load += new System.EventHandler(this.CopyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CurrentOperation;
        private System.Windows.Forms.Label CurrentFile;
        private System.Windows.Forms.Label CurrentSize;
    }
}