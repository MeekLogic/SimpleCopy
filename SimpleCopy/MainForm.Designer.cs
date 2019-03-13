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
            this.Source = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.SourceButton = new System.Windows.Forms.Button();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SourceBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.AdvancedTabPage = new System.Windows.Forms.TabControl();
            this.BasicTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnableRestartMode = new System.Windows.Forms.CheckBox();
            this.EnableBackupMode = new System.Windows.Forms.CheckBox();
            this.UseEfwRawMode = new System.Windows.Forms.CheckBox();
            this.UseUnbufferedIo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CopySubdirectoriesIncludingEmpty = new System.Windows.Forms.CheckBox();
            this.Purge = new System.Windows.Forms.CheckBox();
            this.CopySubdirectories = new System.Windows.Forms.CheckBox();
            this.Mirror = new System.Windows.Forms.CheckBox();
            this.FileFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.AdvancedTabPage.SuspendLayout();
            this.BasicTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Source
            // 
            this.Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source.Location = new System.Drawing.Point(24, 54);
            this.Source.Margin = new System.Windows.Forms.Padding(4);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(1007, 29);
            this.Source.TabIndex = 0;
            // 
            // Destination
            // 
            this.Destination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Destination.Location = new System.Drawing.Point(24, 124);
            this.Destination.Margin = new System.Windows.Forms.Padding(4);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(1007, 29);
            this.Destination.TabIndex = 1;
            // 
            // SourceButton
            // 
            this.SourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceButton.Location = new System.Drawing.Point(1038, 54);
            this.SourceButton.Margin = new System.Windows.Forms.Padding(4);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(97, 37);
            this.SourceButton.TabIndex = 2;
            this.SourceButton.Text = "Browse";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceBrowseButton_Click);
            // 
            // DestinationButton
            // 
            this.DestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationButton.Location = new System.Drawing.Point(1038, 124);
            this.DestinationButton.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(97, 37);
            this.DestinationButton.TabIndex = 3;
            this.DestinationButton.Text = "Browse";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.DestinationBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Location = new System.Drawing.Point(1051, 408);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(125, 37);
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
            // AdvancedTabPage
            // 
            this.AdvancedTabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedTabPage.Controls.Add(this.BasicTabPage);
            this.AdvancedTabPage.Controls.Add(this.tabPage2);
            this.AdvancedTabPage.Location = new System.Drawing.Point(13, 44);
            this.AdvancedTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.AdvancedTabPage.Name = "AdvancedTabPage";
            this.AdvancedTabPage.SelectedIndex = 0;
            this.AdvancedTabPage.Size = new System.Drawing.Size(1170, 356);
            this.AdvancedTabPage.TabIndex = 8;
            // 
            // BasicTabPage
            // 
            this.BasicTabPage.Controls.Add(this.label1);
            this.BasicTabPage.Controls.Add(this.Source);
            this.BasicTabPage.Controls.Add(this.label2);
            this.BasicTabPage.Controls.Add(this.Destination);
            this.BasicTabPage.Controls.Add(this.SourceButton);
            this.BasicTabPage.Controls.Add(this.DestinationButton);
            this.BasicTabPage.Location = new System.Drawing.Point(4, 33);
            this.BasicTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.BasicTabPage.Name = "BasicTabPage";
            this.BasicTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.BasicTabPage.Size = new System.Drawing.Size(1162, 319);
            this.BasicTabPage.TabIndex = 0;
            this.BasicTabPage.Text = "Basic";
            this.BasicTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1162, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EnableRestartMode);
            this.groupBox2.Controls.Add(this.EnableBackupMode);
            this.groupBox2.Controls.Add(this.UseEfwRawMode);
            this.groupBox2.Controls.Add(this.UseUnbufferedIo);
            this.groupBox2.Location = new System.Drawing.Point(414, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(732, 290);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // EnableRestartMode
            // 
            this.EnableRestartMode.AutoSize = true;
            this.EnableRestartMode.Location = new System.Drawing.Point(11, 20);
            this.EnableRestartMode.Margin = new System.Windows.Forms.Padding(6);
            this.EnableRestartMode.Name = "EnableRestartMode";
            this.EnableRestartMode.Size = new System.Drawing.Size(191, 29);
            this.EnableRestartMode.TabIndex = 4;
            this.EnableRestartMode.Text = "Restartable Mode";
            this.EnableRestartMode.UseVisualStyleBackColor = true;
            // 
            // EnableBackupMode
            // 
            this.EnableBackupMode.AutoSize = true;
            this.EnableBackupMode.Location = new System.Drawing.Point(11, 63);
            this.EnableBackupMode.Margin = new System.Windows.Forms.Padding(6);
            this.EnableBackupMode.Name = "EnableBackupMode";
            this.EnableBackupMode.Size = new System.Drawing.Size(159, 29);
            this.EnableBackupMode.TabIndex = 5;
            this.EnableBackupMode.Text = "Backup Mode";
            this.EnableBackupMode.UseVisualStyleBackColor = true;
            // 
            // UseEfwRawMode
            // 
            this.UseEfwRawMode.AutoSize = true;
            this.UseEfwRawMode.Location = new System.Drawing.Point(11, 148);
            this.UseEfwRawMode.Margin = new System.Windows.Forms.Padding(6);
            this.UseEfwRawMode.Name = "UseEfwRawMode";
            this.UseEfwRawMode.Size = new System.Drawing.Size(286, 29);
            this.UseEfwRawMode.TabIndex = 7;
            this.UseEfwRawMode.Text = "EFS RAW for encrypted files";
            this.UseEfwRawMode.UseVisualStyleBackColor = true;
            // 
            // UseUnbufferedIo
            // 
            this.UseUnbufferedIo.AutoSize = true;
            this.UseUnbufferedIo.Location = new System.Drawing.Point(11, 105);
            this.UseUnbufferedIo.Margin = new System.Windows.Forms.Padding(6);
            this.UseUnbufferedIo.Name = "UseUnbufferedIo";
            this.UseUnbufferedIo.Size = new System.Drawing.Size(166, 29);
            this.UseUnbufferedIo.TabIndex = 6;
            this.UseUnbufferedIo.Text = "Unbuffered I/O";
            this.UseUnbufferedIo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CopySubdirectoriesIncludingEmpty);
            this.groupBox1.Controls.Add(this.Purge);
            this.groupBox1.Controls.Add(this.CopySubdirectories);
            this.groupBox1.Controls.Add(this.Mirror);
            this.groupBox1.Controls.Add(this.FileFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(394, 290);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // CopySubdirectoriesIncludingEmpty
            // 
            this.CopySubdirectoriesIncludingEmpty.AutoSize = true;
            this.CopySubdirectoriesIncludingEmpty.Location = new System.Drawing.Point(11, 68);
            this.CopySubdirectoriesIncludingEmpty.Margin = new System.Windows.Forms.Padding(6);
            this.CopySubdirectoriesIncludingEmpty.Name = "CopySubdirectoriesIncludingEmpty";
            this.CopySubdirectoriesIncludingEmpty.Size = new System.Drawing.Size(355, 29);
            this.CopySubdirectoriesIncludingEmpty.TabIndex = 1;
            this.CopySubdirectoriesIncludingEmpty.Text = "Copy Subdirectories including empty";
            this.CopySubdirectoriesIncludingEmpty.UseVisualStyleBackColor = true;
            // 
            // Purge
            // 
            this.Purge.AutoSize = true;
            this.Purge.Location = new System.Drawing.Point(11, 111);
            this.Purge.Margin = new System.Windows.Forms.Padding(6);
            this.Purge.Name = "Purge";
            this.Purge.Size = new System.Drawing.Size(90, 29);
            this.Purge.TabIndex = 9;
            this.Purge.Text = "Purge";
            this.Purge.UseVisualStyleBackColor = true;
            // 
            // CopySubdirectories
            // 
            this.CopySubdirectories.AutoSize = true;
            this.CopySubdirectories.Location = new System.Drawing.Point(11, 26);
            this.CopySubdirectories.Margin = new System.Windows.Forms.Padding(6);
            this.CopySubdirectories.Name = "CopySubdirectories";
            this.CopySubdirectories.Size = new System.Drawing.Size(215, 29);
            this.CopySubdirectories.TabIndex = 0;
            this.CopySubdirectories.Text = "Copy Subdirectories";
            this.CopySubdirectories.UseVisualStyleBackColor = true;
            // 
            // Mirror
            // 
            this.Mirror.AutoSize = true;
            this.Mirror.Location = new System.Drawing.Point(11, 153);
            this.Mirror.Margin = new System.Windows.Forms.Padding(6);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(170, 29);
            this.Mirror.TabIndex = 8;
            this.Mirror.Text = "Mirror Directory";
            this.Mirror.UseVisualStyleBackColor = true;
            // 
            // FileFilter
            // 
            this.FileFilter.Location = new System.Drawing.Point(11, 196);
            this.FileFilter.Margin = new System.Windows.Forms.Padding(6);
            this.FileFilter.Name = "FileFilter";
            this.FileFilter.Size = new System.Drawing.Size(239, 29);
            this.FileFilter.TabIndex = 2;
            this.FileFilter.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Filter";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1188, 38);
            this.MenuStrip.TabIndex = 10;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.RecentToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(84, 34);
            this.fileToolStripMenuItem1.Text = "Profile";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // RecentToolStripMenuItem
            // 
            this.RecentToolStripMenuItem.Name = "RecentToolStripMenuItem";
            this.RecentToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.RecentToolStripMenuItem.Text = "Recent";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ProfileBrowser
            // 
            this.ProfileBrowser.FileName = "profileBrowser";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 465);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.AdvancedTabPage);
            this.Controls.Add(this.CopyButton);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1197, 483);
            this.Name = "MainForm";
            this.Text = "Simple Copy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.AdvancedTabPage.ResumeLayout(false);
            this.BasicTabPage.ResumeLayout(false);
            this.BasicTabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.FolderBrowserDialog SourceBrowser;
        private System.Windows.Forms.FolderBrowserDialog DestinationBrowser;
        private System.Windows.Forms.TabControl AdvancedTabPage;
        private System.Windows.Forms.TabPage BasicTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox CopySubdirectories;
        private System.Windows.Forms.CheckBox Purge;
        private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.CheckBox UseEfwRawMode;
        private System.Windows.Forms.CheckBox UseUnbufferedIo;
        private System.Windows.Forms.CheckBox EnableBackupMode;
        private System.Windows.Forms.CheckBox EnableRestartMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileFilter;
        private System.Windows.Forms.CheckBox CopySubdirectoriesIncludingEmpty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ProfileBrowser;
    }
}

