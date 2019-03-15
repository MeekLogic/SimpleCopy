namespace SimpleCopy
{
    partial class MainForm
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
            this.CopyButton = new System.Windows.Forms.Button();
            this.SourceBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.TextBox();
            this.SourceButton = new System.Windows.Forms.Button();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Location = new System.Drawing.Point(396, 127);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(2);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(68, 20);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SourceBrowser
            // 
            this.SourceBrowser.Description = "Select source folder.";
            // 
            // DestinationBrowser
            // 
            this.DestinationBrowser.Description = "Select destination folder.";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(492, 24);
            this.MenuStrip.TabIndex = 10;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.RecentToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(53, 22);
            this.fileToolStripMenuItem1.Text = "Profile";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // RecentToolStripMenuItem
            // 
            this.RecentToolStripMenuItem.Name = "RecentToolStripMenuItem";
            this.RecentToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.RecentToolStripMenuItem.Text = "Recent";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // ProfileBrowser
            // 
            this.ProfileBrowser.FileName = "profileBrowser";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Source";
            // 
            // Source
            // 
            this.Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source.Location = new System.Drawing.Point(26, 54);
            this.Source.Margin = new System.Windows.Forms.Padding(2);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(395, 20);
            this.Source.TabIndex = 23;
            this.Source.TextChanged += new System.EventHandler(this.Source_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Destination";
            // 
            // Destination
            // 
            this.Destination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Destination.Location = new System.Drawing.Point(26, 92);
            this.Destination.Margin = new System.Windows.Forms.Padding(2);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(395, 20);
            this.Destination.TabIndex = 24;
            this.Destination.TextChanged += new System.EventHandler(this.Destination_TextChanged);
            // 
            // SourceButton
            // 
            this.SourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceButton.Location = new System.Drawing.Point(423, 54);
            this.SourceButton.Margin = new System.Windows.Forms.Padding(2);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(53, 20);
            this.SourceButton.TabIndex = 25;
            this.SourceButton.Text = "Browse";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // DestinationButton
            // 
            this.DestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationButton.Location = new System.Drawing.Point(423, 92);
            this.DestinationButton.Margin = new System.Windows.Forms.Padding(2);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(53, 20);
            this.DestinationButton.TabIndex = 26;
            this.DestinationButton.Text = "Browse";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.SourceButton);
            this.Controls.Add(this.DestinationButton);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.CopyButton);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(305, 185);
            this.Name = "MainForm";
            this.Text = "Simple Copy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.FolderBrowserDialog SourceBrowser;
        private System.Windows.Forms.FolderBrowserDialog DestinationBrowser;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecentToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ProfileBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

