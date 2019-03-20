using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class ProfileEditorForm : Form
    {
        public ProfileEditorForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ProfileName.Text = ProfileManager.CurrentName;
            FileFilter.Text = ProfileManager.Current.FileFilter;
            EnableRestartMode.Checked = ProfileManager.Current.EnableRestartMode;
            EnableBackupMode.Checked = ProfileManager.Current.EnableBackupMode;
            UseUnbufferedIo.Checked = ProfileManager.Current.UseUnbufferedIo;
            if (ProfileManager.Current.Mirror)
            {
                Mirror.Checked = true;
                CopySubdirectories.Checked = true;
                CopySubdirectoriesIncludingEmpty.Checked = true;
                Purge.Checked = true;
                CopySubdirectories.Enabled = false;
                CopySubdirectoriesIncludingEmpty.Enabled = false;
                Purge.Enabled = false;
            }
            else
            {
                CopySubdirectories.Checked = ProfileManager.Current.CopySubdirectories;
                CopySubdirectoriesIncludingEmpty.Checked = ProfileManager.Current.CopySubdirectoriesIncludingEmpty;
                Purge.Checked = ProfileManager.Current.Purge;
            }
            Depth.Value = ProfileManager.Current.Depth;
            MoveFiles.Checked = ProfileManager.Current.MoveFiles;
            MoveFilesAndDirectories.Checked = ProfileManager.Current.MoveFilesAndDirectories;
            CreateDirectoryAndFileTree.Checked = ProfileManager.Current.CreateDirectoryAndFileTree;
            FatFiles.Checked = ProfileManager.Current.FatFiles;
            TurnLongPathSupportOff.Checked = ProfileManager.Current.TurnLongPathSupportOff;
            CopySymbolicLink.Checked = ProfileManager.Current.CopySymobolicLink;
            DoNotUseWindowsCopyOffload.Checked = ProfileManager.Current.DoNotUseWindowsCopyOffload;
            CheckPerFile.Checked = ProfileManager.Current.CheckPerFile;
            if (ProfileManager.Current.EnableEfsRawMode || ProfileManager.Current.InterPacketGap > 0)
            {
                UseEfwRawMode.Checked = ProfileManager.Current.EnableEfsRawMode;
                InterPacketGap.Value = ProfileManager.Current.InterPacketGap;
                MultiThreadedCopies.Enabled = false;
            }
            else if (ProfileManager.Current.MultiThreadedCopiesCount > 0)
            {
                MultiThreadedCopies.Value = ProfileManager.Current.MultiThreadedCopiesCount;
                UseEfwRawMode.Enabled = false;
                InterPacketGap.Enabled = false;
            }
            RetryCount.Value = ProfileManager.Current.RetryCount;
            RetryWaitTime.Value = ProfileManager.Current.RetryWaitTime;

            // File Copy Flags
            if (ProfileManager.Current.FileCopyFlags.Data) FileCopyFlags.SetItemChecked(0, true);
            if (ProfileManager.Current.FileCopyFlags.Attributes) FileCopyFlags.SetItemChecked(1, true);
            if (ProfileManager.Current.FileCopyFlags.TimeStamps) FileCopyFlags.SetItemChecked(2, true);
            if (ProfileManager.Current.FileCopyFlags.Security) FileCopyFlags.SetItemChecked(3, true);
            if (ProfileManager.Current.FileCopyFlags.Owner) FileCopyFlags.SetItemChecked(4, true);
            if (ProfileManager.Current.FileCopyFlags.Auditing) FileCopyFlags.SetItemChecked(5, true);

            // Directory Copy Flags
            if (ProfileManager.Current.DirectoryCopyFlags.Data) DirectoryCopyFlags.SetItemChecked(0, true);
            if (ProfileManager.Current.DirectoryCopyFlags.Attributes) DirectoryCopyFlags.SetItemChecked(1, true);
            if (ProfileManager.Current.DirectoryCopyFlags.TimeStamps) DirectoryCopyFlags.SetItemChecked(2, true);

            // Add Attributes
            if (ProfileManager.Current.AddAttributes.ReadOnly) AddAttributes.SetItemChecked(0, true);
            if (ProfileManager.Current.AddAttributes.Archive) AddAttributes.SetItemChecked(1, true);
            if (ProfileManager.Current.AddAttributes.System) AddAttributes.SetItemChecked(2, true);
            if (ProfileManager.Current.AddAttributes.Hidden) AddAttributes.SetItemChecked(3, true);
            if (ProfileManager.Current.AddAttributes.Compressed) AddAttributes.SetItemChecked(4, true);
            if (ProfileManager.Current.AddAttributes.NotContentIndexed) AddAttributes.SetItemChecked(5, true);
            if (ProfileManager.Current.AddAttributes.Encrypted) AddAttributes.SetItemChecked(6, true);
            if (ProfileManager.Current.AddAttributes.Temporary) AddAttributes.SetItemChecked(7, true);
            if (ProfileManager.Current.AddAttributes.Offline) AddAttributes.SetItemChecked(8, true);

            // Remove Attributes
            if (ProfileManager.Current.RemoveAttributes.ReadOnly) RemoveAttributes.SetItemChecked(0, true);
            if (ProfileManager.Current.RemoveAttributes.Archive) RemoveAttributes.SetItemChecked(1, true);
            if (ProfileManager.Current.RemoveAttributes.System) RemoveAttributes.SetItemChecked(2, true);
            if (ProfileManager.Current.RemoveAttributes.Hidden) RemoveAttributes.SetItemChecked(3, true);
            if (ProfileManager.Current.RemoveAttributes.Compressed) RemoveAttributes.SetItemChecked(4, true);
            if (ProfileManager.Current.RemoveAttributes.NotContentIndexed) RemoveAttributes.SetItemChecked(5, true);
            if (ProfileManager.Current.RemoveAttributes.Encrypted) RemoveAttributes.SetItemChecked(6, true);
            if (ProfileManager.Current.RemoveAttributes.Temporary) RemoveAttributes.SetItemChecked(7, true);
            if (ProfileManager.Current.RemoveAttributes.Offline) RemoveAttributes.SetItemChecked(8, true);

            // Events
            EnableRestartMode.CheckedChanged += new EventHandler(EnableRestartMode_CheckedChanged);
            EnableBackupMode.CheckedChanged += new EventHandler(EnableBackupMode_CheckedChanged);
            UseEfwRawMode.CheckedChanged += new EventHandler(UseEfwRawMode_CheckedChanged);
            UseUnbufferedIo.CheckedChanged += new EventHandler(UseUnbufferedIo_CheckedChanged);
            CopySubdirectoriesIncludingEmpty.CheckedChanged += new EventHandler(CopySubdirectoriesIncludingEmpty_CheckedChanged);
            Purge.CheckedChanged += new EventHandler(Purge_CheckedChanged);
            CopySubdirectories.CheckedChanged += new EventHandler(CopySubdirectories_CheckedChanged);
            Mirror.CheckedChanged += new EventHandler(Mirror_CheckedChanged);
            FileFilter.TextChanged += new EventHandler(FileFilter_TextChanged);
            RemoveAttributes.SelectedValueChanged += new EventHandler(RemoveAttributes_SelectedValueChanged);
            AddAttributes.SelectedValueChanged += new EventHandler(AddAttributes_SelectedValueChanged);
            DirectoryCopyFlags.SelectedValueChanged += new EventHandler(DirectoryCopyFlags_SelectedValueChanged);
            FileCopyFlags.SelectedValueChanged += new EventHandler(FileCopyFlags_SelectedValueChanged);
            CheckPerFile.CheckedChanged += new EventHandler(CheckPerFile_CheckedChanged);
            InterPacketGap.ValueChanged += new EventHandler(InterPacketGap_ValueChanged);
            MultiThreadedCopies.ValueChanged += new EventHandler(MultiThreadedCopies_ValueChanged);
            DoNotUseWindowsCopyOffload.CheckedChanged += new EventHandler(DoNotUseWindowsCopyOffload_CheckedChanged);
            CopySymbolicLink.CheckedChanged += new EventHandler(CopySymbolicLink_CheckedChanged);
            TurnLongPathSupportOff.CheckedChanged += new EventHandler(TurnLongPathSupportOff_CheckedChanged);
            FatFiles.CheckedChanged += new EventHandler(FatFiles_CheckedChanged);
            UseEfwRawMode.CheckedChanged += new EventHandler(UseEfwRawMode_CheckedChanged);
            CreateDirectoryAndFileTree.CheckedChanged += new EventHandler(CreateDirectoryAndFileTree_CheckedChanged);
            MoveFilesAndDirectories.CheckedChanged += new EventHandler(MoveFilesAndDirectories_CheckedChanged);
            MoveFiles.CheckedChanged += new EventHandler(MoveFiles_CheckedChanged);
            Depth.ValueChanged += new EventHandler(Depth_ValueChanged);
            RetryCount.ValueChanged += new EventHandler(RetryCount_ValueChanged);
            RetryWaitTime.ValueChanged += new EventHandler(RetryWaitTime_ValueChanged);
        }

        private void CopySubdirectories_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.CopySubdirectories = CopySubdirectories.Checked;
        }

        private void EnableBackupMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.EnableBackupMode = EnableBackupMode.Checked;
        }

        private void CopySubdirectoriesIncludingEmpty_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.CopySubdirectoriesIncludingEmpty = CopySubdirectoriesIncludingEmpty.Checked;
        }

        private void EnableRestartMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.EnableRestartMode = EnableRestartMode.Checked;
        }

        private void UseUnbufferedIo_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.UseUnbufferedIo = UseUnbufferedIo.Checked;
        }

        private void Purge_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.Purge = Purge.Checked;
        }

        private void Mirror_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = ProfileManager.Current.Mirror = Mirror.Checked;

            CopySubdirectories.Enabled = !enabled;
            //
            CopySubdirectoriesIncludingEmpty.Checked = enabled;
            CopySubdirectoriesIncludingEmpty.Enabled = !enabled;
            //
            Purge.Checked = enabled;
            Purge.Enabled = !enabled;
        }

        private void FileFilter_TextChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.FileFilter = FileFilter.Text;
        }

        private void FileCopyFlags_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FileCopyFlags.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ProfileManager.Current.FileCopyFlags.Data = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.Current.FileCopyFlags.Attributes = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.Current.FileCopyFlags.TimeStamps = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.Current.FileCopyFlags.Security = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.Current.FileCopyFlags.Owner = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.Current.FileCopyFlags.Auditing = FileCopyFlags.GetItemChecked(i);
                        break;
                }
            }
        }

        private void DirectoryCopyFlags_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DirectoryCopyFlags.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ProfileManager.Current.DirectoryCopyFlags.Data = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.Current.DirectoryCopyFlags.Attributes = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.Current.DirectoryCopyFlags.TimeStamps = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.Current.DirectoryCopyFlags.Security = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.Current.DirectoryCopyFlags.Owner = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.Current.DirectoryCopyFlags.Auditing = DirectoryCopyFlags.GetItemChecked(i);
                        break;
                }
            }
        }

        private void AddAttributes_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < AddAttributes.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ProfileManager.Current.AddAttributes.ReadOnly = AddAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.Current.AddAttributes.Archive = AddAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.Current.AddAttributes.System = AddAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.Current.AddAttributes.Hidden = AddAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.Current.AddAttributes.Compressed = AddAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.Current.AddAttributes.NotContentIndexed = AddAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        ProfileManager.Current.AddAttributes.Encrypted = AddAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        ProfileManager.Current.AddAttributes.Temporary = AddAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        ProfileManager.Current.AddAttributes.Offline = AddAttributes.GetItemChecked(i);
                        break;
                }
            }
        }

        private void RemoveAttributes_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < RemoveAttributes.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ProfileManager.Current.RemoveAttributes.ReadOnly = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.Current.RemoveAttributes.Archive = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.Current.RemoveAttributes.System = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.Current.RemoveAttributes.Hidden = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.Current.RemoveAttributes.Compressed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.Current.RemoveAttributes.NotContentIndexed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        ProfileManager.Current.RemoveAttributes.Encrypted = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        ProfileManager.Current.RemoveAttributes.Temporary = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        ProfileManager.Current.RemoveAttributes.Offline = RemoveAttributes.GetItemChecked(i);
                        break;
                }
            }
        }

        private void MoveFiles_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.MoveFiles = MoveFiles.Checked;
        }

        private void MoveFilesAndDirectories_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.MoveFilesAndDirectories = MoveFilesAndDirectories.Checked;
        }

        private void CreateDirectoryAndFileTree_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.CreateDirectoryAndFileTree = CreateDirectoryAndFileTree.Checked;
        }

        private void FatFiles_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.FatFiles = FatFiles.Checked;
        }

        private void TurnLongPathSupportOff_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.TurnLongPathSupportOff = TurnLongPathSupportOff.Checked;
        }

        private void CopySymbolicLink_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.CopySymobolicLink = CopySymbolicLink.Checked;
        }

        private void DoNotUseWindowsCopyOffload_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.DoNotUseWindowsCopyOffload = DoNotUseWindowsCopyOffload.Checked;
        }

        private void CheckPerFile_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.CheckPerFile = CheckPerFile.Checked;
        }

        private void MultiThreadedCopies_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.MultiThreadedCopiesCount = (int)MultiThreadedCopies.Value;

            if (MultiThreadedCopies.Value > 0)
            {
                UseEfwRawMode.Enabled = false;
                InterPacketGap.Enabled = false;
            }
            else
            {
                UseEfwRawMode.Enabled = true;
                InterPacketGap.Enabled = true;
            }
        }

        private void InterPacketGap_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.InterPacketGap = (int)InterPacketGap.Value;

            if (UseEfwRawMode.Checked || InterPacketGap.Value > 0)
            {
                MultiThreadedCopies.Enabled = false;
            }
            else
            {
                MultiThreadedCopies.Enabled = true;
            }
        }

        private void Depth_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.Depth = (int)Depth.Value;
        }

        private void UseEfwRawMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.EnableEfsRawMode = UseEfwRawMode.Checked;

            if (UseEfwRawMode.Checked || InterPacketGap.Value > 0)
            {
                MultiThreadedCopies.Enabled = false;
            }
            else
            {
                MultiThreadedCopies.Enabled = true;
            }
        }

        private void RetryCount_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.RetryCount = (int)RetryCount.Value;
        }

        private void RetryWaitTime_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.Current.RetryWaitTime = (int)RetryWaitTime.Value;
        }

        private void ProfileName_TextChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentName = ProfileName.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}