﻿namespace SimpleCopy
{
    partial class ProfileEditorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveAttributes = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAttributes = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DirectoryCopyFlags = new System.Windows.Forms.CheckedListBox();
            this.FileCopyFlags = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckPerFile = new System.Windows.Forms.CheckBox();
            this.InterPacketGap = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MultiThreadedCopies = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.DoNotUseWindowsCopyOffload = new System.Windows.Forms.CheckBox();
            this.CopySymbolicLink = new System.Windows.Forms.CheckBox();
            this.EnableRestartMode = new System.Windows.Forms.CheckBox();
            this.TurnLongPathSupportOff = new System.Windows.Forms.CheckBox();
            this.EnableBackupMode = new System.Windows.Forms.CheckBox();
            this.FatFiles = new System.Windows.Forms.CheckBox();
            this.UseEfwRawMode = new System.Windows.Forms.CheckBox();
            this.UseUnbufferedIo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RetryWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.RetryCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.CreateDirectoryAndFileTree = new System.Windows.Forms.CheckBox();
            this.MoveFilesAndDirectories = new System.Windows.Forms.CheckBox();
            this.MoveFiles = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.NumericUpDown();
            this.CopySubdirectoriesIncludingEmpty = new System.Windows.Forms.CheckBox();
            this.Purge = new System.Windows.Forms.CheckBox();
            this.CopySubdirectories = new System.Windows.Forms.CheckBox();
            this.Mirror = new System.Windows.Forms.CheckBox();
            this.FileFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ProfileName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterPacketGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiThreadedCopies)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RetryWaitTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Copy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.RemoveAttributes);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.AddAttributes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.DirectoryCopyFlags);
            this.groupBox3.Controls.Add(this.FileCopyFlags);
            this.groupBox3.Location = new System.Drawing.Point(214, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 319);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // RemoveAttributes
            // 
            this.RemoveAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAttributes.CheckOnClick = true;
            this.RemoveAttributes.FormattingEnabled = true;
            this.RemoveAttributes.Items.AddRange(new object[] {
            "Read Only",
            "Archive",
            "System",
            "Hidden",
            "Compressed",
            "Not Content Indexed",
            "Encrypted",
            "Temporary",
            "Offline"});
            this.RemoveAttributes.Location = new System.Drawing.Point(6, 256);
            this.RemoveAttributes.Name = "RemoveAttributes";
            this.RemoveAttributes.Size = new System.Drawing.Size(196, 49);
            this.RemoveAttributes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Remove Attributes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Attributes";
            // 
            // AddAttributes
            // 
            this.AddAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAttributes.CheckOnClick = true;
            this.AddAttributes.FormattingEnabled = true;
            this.AddAttributes.Items.AddRange(new object[] {
            "Read Only",
            "Archive",
            "System",
            "Hidden",
            "Compressed",
            "Not Content Indexed",
            "Encrypted",
            "Temporary",
            "Offline"});
            this.AddAttributes.Location = new System.Drawing.Point(6, 178);
            this.AddAttributes.Name = "AddAttributes";
            this.AddAttributes.Size = new System.Drawing.Size(196, 49);
            this.AddAttributes.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "File Copy Flags";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Directory Copy Flags";
            // 
            // DirectoryCopyFlags
            // 
            this.DirectoryCopyFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryCopyFlags.CheckOnClick = true;
            this.DirectoryCopyFlags.FormattingEnabled = true;
            this.DirectoryCopyFlags.Items.AddRange(new object[] {
            "Data",
            "Attributes",
            "Time Stamps"});
            this.DirectoryCopyFlags.Location = new System.Drawing.Point(6, 103);
            this.DirectoryCopyFlags.Name = "DirectoryCopyFlags";
            this.DirectoryCopyFlags.Size = new System.Drawing.Size(196, 49);
            this.DirectoryCopyFlags.TabIndex = 1;
            // 
            // FileCopyFlags
            // 
            this.FileCopyFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileCopyFlags.CheckOnClick = true;
            this.FileCopyFlags.FormattingEnabled = true;
            this.FileCopyFlags.Items.AddRange(new object[] {
            "Data",
            "Attributes",
            "Time Stamps",
            "NTFS access control lists (ACL)",
            "Owner information",
            "Auditing information"});
            this.FileCopyFlags.Location = new System.Drawing.Point(6, 28);
            this.FileCopyFlags.Name = "FileCopyFlags";
            this.FileCopyFlags.Size = new System.Drawing.Size(196, 49);
            this.FileCopyFlags.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CheckPerFile);
            this.groupBox2.Controls.Add(this.InterPacketGap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MultiThreadedCopies);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DoNotUseWindowsCopyOffload);
            this.groupBox2.Controls.Add(this.CopySymbolicLink);
            this.groupBox2.Controls.Add(this.EnableRestartMode);
            this.groupBox2.Controls.Add(this.TurnLongPathSupportOff);
            this.groupBox2.Controls.Add(this.EnableBackupMode);
            this.groupBox2.Controls.Add(this.FatFiles);
            this.groupBox2.Controls.Add(this.UseEfwRawMode);
            this.groupBox2.Controls.Add(this.UseUnbufferedIo);
            this.groupBox2.Location = new System.Drawing.Point(428, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 319);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // CheckPerFile
            // 
            this.CheckPerFile.AutoSize = true;
            this.CheckPerFile.Location = new System.Drawing.Point(6, 195);
            this.CheckPerFile.Name = "CheckPerFile";
            this.CheckPerFile.Size = new System.Drawing.Size(95, 17);
            this.CheckPerFile.TabIndex = 24;
            this.CheckPerFile.Text = "Check Per File";
            this.CheckPerFile.UseVisualStyleBackColor = true;
            // 
            // InterPacketGap
            // 
            this.InterPacketGap.Location = new System.Drawing.Point(118, 292);
            this.InterPacketGap.Name = "InterPacketGap";
            this.InterPacketGap.Size = new System.Drawing.Size(71, 20);
            this.InterPacketGap.TabIndex = 23;
            this.InterPacketGap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Inter-packet Gap";
            // 
            // MultiThreadedCopies
            // 
            this.MultiThreadedCopies.Location = new System.Drawing.Point(118, 266);
            this.MultiThreadedCopies.Name = "MultiThreadedCopies";
            this.MultiThreadedCopies.Size = new System.Drawing.Size(71, 20);
            this.MultiThreadedCopies.TabIndex = 21;
            this.MultiThreadedCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mutli-threaded Copies";
            // 
            // DoNotUseWindowsCopyOffload
            // 
            this.DoNotUseWindowsCopyOffload.AutoSize = true;
            this.DoNotUseWindowsCopyOffload.Location = new System.Drawing.Point(6, 172);
            this.DoNotUseWindowsCopyOffload.Name = "DoNotUseWindowsCopyOffload";
            this.DoNotUseWindowsCopyOffload.Size = new System.Drawing.Size(193, 17);
            this.DoNotUseWindowsCopyOffload.TabIndex = 19;
            this.DoNotUseWindowsCopyOffload.Text = "Do Not Use Windows Copy Offload";
            this.DoNotUseWindowsCopyOffload.UseVisualStyleBackColor = true;
            // 
            // CopySymbolicLink
            // 
            this.CopySymbolicLink.AutoSize = true;
            this.CopySymbolicLink.Location = new System.Drawing.Point(6, 149);
            this.CopySymbolicLink.Name = "CopySymbolicLink";
            this.CopySymbolicLink.Size = new System.Drawing.Size(118, 17);
            this.CopySymbolicLink.TabIndex = 17;
            this.CopySymbolicLink.Text = "Copy Symbolic Link";
            this.CopySymbolicLink.UseVisualStyleBackColor = true;
            // 
            // EnableRestartMode
            // 
            this.EnableRestartMode.AutoSize = true;
            this.EnableRestartMode.Location = new System.Drawing.Point(6, 11);
            this.EnableRestartMode.Name = "EnableRestartMode";
            this.EnableRestartMode.Size = new System.Drawing.Size(110, 17);
            this.EnableRestartMode.TabIndex = 4;
            this.EnableRestartMode.Text = "Restartable Mode";
            this.EnableRestartMode.UseVisualStyleBackColor = true;
            // 
            // TurnLongPathSupportOff
            // 
            this.TurnLongPathSupportOff.AutoSize = true;
            this.TurnLongPathSupportOff.Location = new System.Drawing.Point(6, 126);
            this.TurnLongPathSupportOff.Name = "TurnLongPathSupportOff";
            this.TurnLongPathSupportOff.Size = new System.Drawing.Size(157, 17);
            this.TurnLongPathSupportOff.TabIndex = 16;
            this.TurnLongPathSupportOff.Text = "Turn Long Path Support Off";
            this.TurnLongPathSupportOff.UseVisualStyleBackColor = true;
            // 
            // EnableBackupMode
            // 
            this.EnableBackupMode.AutoSize = true;
            this.EnableBackupMode.Location = new System.Drawing.Point(6, 34);
            this.EnableBackupMode.Name = "EnableBackupMode";
            this.EnableBackupMode.Size = new System.Drawing.Size(93, 17);
            this.EnableBackupMode.TabIndex = 5;
            this.EnableBackupMode.Text = "Backup Mode";
            this.EnableBackupMode.UseVisualStyleBackColor = true;
            // 
            // FatFiles
            // 
            this.FatFiles.AutoSize = true;
            this.FatFiles.Location = new System.Drawing.Point(6, 103);
            this.FatFiles.Name = "FatFiles";
            this.FatFiles.Size = new System.Drawing.Size(70, 17);
            this.FatFiles.TabIndex = 15;
            this.FatFiles.Text = "FAT Files";
            this.FatFiles.UseVisualStyleBackColor = true;
            // 
            // UseEfwRawMode
            // 
            this.UseEfwRawMode.AutoSize = true;
            this.UseEfwRawMode.Location = new System.Drawing.Point(6, 80);
            this.UseEfwRawMode.Name = "UseEfwRawMode";
            this.UseEfwRawMode.Size = new System.Drawing.Size(161, 17);
            this.UseEfwRawMode.TabIndex = 7;
            this.UseEfwRawMode.Text = "EFS RAW for encrypted files";
            this.UseEfwRawMode.UseVisualStyleBackColor = true;
            // 
            // UseUnbufferedIo
            // 
            this.UseUnbufferedIo.AutoSize = true;
            this.UseUnbufferedIo.Location = new System.Drawing.Point(6, 57);
            this.UseUnbufferedIo.Name = "UseUnbufferedIo";
            this.UseUnbufferedIo.Size = new System.Drawing.Size(98, 17);
            this.UseUnbufferedIo.TabIndex = 6;
            this.UseUnbufferedIo.Text = "Unbuffered I/O";
            this.UseUnbufferedIo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.RetryWaitTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RetryCount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CreateDirectoryAndFileTree);
            this.groupBox1.Controls.Add(this.MoveFilesAndDirectories);
            this.groupBox1.Controls.Add(this.MoveFiles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Depth);
            this.groupBox1.Controls.Add(this.CopySubdirectoriesIncludingEmpty);
            this.groupBox1.Controls.Add(this.Purge);
            this.groupBox1.Controls.Add(this.CopySubdirectories);
            this.groupBox1.Controls.Add(this.Mirror);
            this.groupBox1.Controls.Add(this.FileFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 319);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // RetryWaitTime
            // 
            this.RetryWaitTime.Location = new System.Drawing.Point(99, 292);
            this.RetryWaitTime.Name = "RetryWaitTime";
            this.RetryWaitTime.Size = new System.Drawing.Size(90, 20);
            this.RetryWaitTime.TabIndex = 27;
            this.RetryWaitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Retry Wait Time";
            // 
            // RetryCount
            // 
            this.RetryCount.Location = new System.Drawing.Point(99, 266);
            this.RetryCount.Name = "RetryCount";
            this.RetryCount.Size = new System.Drawing.Size(90, 20);
            this.RetryCount.TabIndex = 25;
            this.RetryCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Retry Count";
            // 
            // CreateDirectoryAndFileTree
            // 
            this.CreateDirectoryAndFileTree.AutoSize = true;
            this.CreateDirectoryAndFileTree.Enabled = false;
            this.CreateDirectoryAndFileTree.Location = new System.Drawing.Point(6, 204);
            this.CreateDirectoryAndFileTree.Name = "CreateDirectoryAndFileTree";
            this.CreateDirectoryAndFileTree.Size = new System.Drawing.Size(167, 17);
            this.CreateDirectoryAndFileTree.TabIndex = 14;
            this.CreateDirectoryAndFileTree.Text = "Create Directory and File Tree";
            this.CreateDirectoryAndFileTree.UseVisualStyleBackColor = true;
            // 
            // MoveFilesAndDirectories
            // 
            this.MoveFilesAndDirectories.AutoSize = true;
            this.MoveFilesAndDirectories.Enabled = false;
            this.MoveFilesAndDirectories.Location = new System.Drawing.Point(6, 181);
            this.MoveFilesAndDirectories.Name = "MoveFilesAndDirectories";
            this.MoveFilesAndDirectories.Size = new System.Drawing.Size(151, 17);
            this.MoveFilesAndDirectories.TabIndex = 13;
            this.MoveFilesAndDirectories.Text = "Move Files and Directories";
            this.MoveFilesAndDirectories.UseVisualStyleBackColor = true;
            // 
            // MoveFiles
            // 
            this.MoveFiles.AutoSize = true;
            this.MoveFiles.Enabled = false;
            this.MoveFiles.Location = new System.Drawing.Point(6, 158);
            this.MoveFiles.Name = "MoveFiles";
            this.MoveFiles.Size = new System.Drawing.Size(77, 17);
            this.MoveFiles.TabIndex = 12;
            this.MoveFiles.Text = "Move Files";
            this.MoveFiles.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth";
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(60, 132);
            this.Depth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(122, 20);
            this.Depth.TabIndex = 10;
            // 
            // CopySubdirectoriesIncludingEmpty
            // 
            this.CopySubdirectoriesIncludingEmpty.AutoSize = true;
            this.CopySubdirectoriesIncludingEmpty.Location = new System.Drawing.Point(6, 37);
            this.CopySubdirectoriesIncludingEmpty.Name = "CopySubdirectoriesIncludingEmpty";
            this.CopySubdirectoriesIncludingEmpty.Size = new System.Drawing.Size(196, 17);
            this.CopySubdirectoriesIncludingEmpty.TabIndex = 1;
            this.CopySubdirectoriesIncludingEmpty.Text = "Copy Subdirectories including empty";
            this.CopySubdirectoriesIncludingEmpty.UseVisualStyleBackColor = true;
            // 
            // Purge
            // 
            this.Purge.AutoSize = true;
            this.Purge.Location = new System.Drawing.Point(6, 60);
            this.Purge.Name = "Purge";
            this.Purge.Size = new System.Drawing.Size(54, 17);
            this.Purge.TabIndex = 9;
            this.Purge.Text = "Purge";
            this.Purge.UseVisualStyleBackColor = true;
            // 
            // CopySubdirectories
            // 
            this.CopySubdirectories.AutoSize = true;
            this.CopySubdirectories.Location = new System.Drawing.Point(6, 14);
            this.CopySubdirectories.Name = "CopySubdirectories";
            this.CopySubdirectories.Size = new System.Drawing.Size(120, 17);
            this.CopySubdirectories.TabIndex = 0;
            this.CopySubdirectories.Text = "Copy Subdirectories";
            this.CopySubdirectories.UseVisualStyleBackColor = true;
            // 
            // Mirror
            // 
            this.Mirror.AutoSize = true;
            this.Mirror.Location = new System.Drawing.Point(6, 83);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(97, 17);
            this.Mirror.TabIndex = 8;
            this.Mirror.Text = "Mirror Directory";
            this.Mirror.UseVisualStyleBackColor = true;
            // 
            // FileFilter
            // 
            this.FileFilter.Location = new System.Drawing.Point(60, 106);
            this.FileFilter.Name = "FileFilter";
            this.FileFilter.Size = new System.Drawing.Size(122, 20);
            this.FileFilter.TabIndex = 2;
            this.FileFilter.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Filter";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Selection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(584, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ProfileName
            // 
            this.ProfileName.Location = new System.Drawing.Point(477, 12);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(178, 20);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.TextChanged += new System.EventHandler(this.ProfileName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name";
            // 
            // ProfileEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 419);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(687, 422);
            this.Name = "ProfileEditorForm";
            this.Text = "Profile Options Editor";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterPacketGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiThreadedCopies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RetryWaitTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox DirectoryCopyFlags;
        private System.Windows.Forms.CheckedListBox FileCopyFlags;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox EnableRestartMode;
        private System.Windows.Forms.CheckBox EnableBackupMode;
        private System.Windows.Forms.CheckBox UseEfwRawMode;
        private System.Windows.Forms.CheckBox UseUnbufferedIo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Depth;
        private System.Windows.Forms.CheckBox CopySubdirectoriesIncludingEmpty;
        private System.Windows.Forms.CheckBox Purge;
        private System.Windows.Forms.CheckBox CopySubdirectories;
        private System.Windows.Forms.CheckBox Mirror;
        private System.Windows.Forms.TextBox FileFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MoveFilesAndDirectories;
        private System.Windows.Forms.CheckBox MoveFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox AddAttributes;
        private System.Windows.Forms.CheckedListBox RemoveAttributes;
        private System.Windows.Forms.CheckBox FatFiles;
        private System.Windows.Forms.CheckBox CreateDirectoryAndFileTree;
        private System.Windows.Forms.CheckBox TurnLongPathSupportOff;
        private System.Windows.Forms.CheckBox CopySymbolicLink;
        private System.Windows.Forms.CheckBox DoNotUseWindowsCopyOffload;
        private System.Windows.Forms.NumericUpDown MultiThreadedCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown InterPacketGap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckPerFile;
        private System.Windows.Forms.NumericUpDown RetryWaitTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown RetryCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProfileName;
        private System.Windows.Forms.Label label11;
    }
}