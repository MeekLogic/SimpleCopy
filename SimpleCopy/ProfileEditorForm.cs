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
            FileFilter.Text = ProfileManager.CurrentProfile.FileFilter;
            EnableRestartMode.Checked = ProfileManager.CurrentProfile.EnableRestartMode;
            EnableBackupMode.Checked = ProfileManager.CurrentProfile.EnableBackupMode;
            UseUnbufferedIo.Checked = ProfileManager.CurrentProfile.UseUnbufferedIo;
            if (ProfileManager.CurrentProfile.Mirror)
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
                CopySubdirectories.Checked = ProfileManager.CurrentProfile.CopySubdirectories;
                CopySubdirectoriesIncludingEmpty.Checked = ProfileManager.CurrentProfile.CopySubdirectoriesIncludingEmpty;
                Purge.Checked = ProfileManager.CurrentProfile.Purge;
            }
            Depth.Value = ProfileManager.CurrentProfile.Depth;
            MoveFiles.Checked = ProfileManager.CurrentProfile.MoveFiles;
            MoveFilesAndDirectories.Checked = ProfileManager.CurrentProfile.MoveFilesAndDirectories;
            CreateDirectoryAndFileTree.Checked = ProfileManager.CurrentProfile.CreateDirectoryAndFileTree;
            FatFiles.Checked = ProfileManager.CurrentProfile.FatFiles;
            TurnLongPathSupportOff.Checked = ProfileManager.CurrentProfile.TurnLongPathSupportOff;
            CopySymbolicLink.Checked = ProfileManager.CurrentProfile.CopySymobolicLink;
            DoNotUseWindowsCopyOffload.Checked = ProfileManager.CurrentProfile.DoNotUseWindowsCopyOffload;
            CheckPerFile.Checked = ProfileManager.CurrentProfile.CheckPerFile;
            if (ProfileManager.CurrentProfile.EnableEfsRawMode || ProfileManager.CurrentProfile.InterPacketGap > 0)
            {
                UseEfwRawMode.Checked = ProfileManager.CurrentProfile.EnableEfsRawMode;
                InterPacketGap.Value = ProfileManager.CurrentProfile.InterPacketGap;
                MultiThreadedCopies.Enabled = false;
            }
            else if (ProfileManager.CurrentProfile.MultiThreadedCopiesCount > 0)
            {
                MultiThreadedCopies.Value = ProfileManager.CurrentProfile.MultiThreadedCopiesCount;
                UseEfwRawMode.Enabled = false;
                InterPacketGap.Enabled = false;
            }
            RetryCount.Value = ProfileManager.CurrentProfile.RetryCount;
            RetryWaitTime.Value = ProfileManager.CurrentProfile.RetryWaitTime;

            // File Copy Flags
            if (ProfileManager.CurrentProfile.FileCopyFlags.Data) FileCopyFlags.SetItemChecked(0, true);
            if (ProfileManager.CurrentProfile.FileCopyFlags.Attributes) FileCopyFlags.SetItemChecked(1, true);
            if (ProfileManager.CurrentProfile.FileCopyFlags.TimeStamps) FileCopyFlags.SetItemChecked(2, true);
            if (ProfileManager.CurrentProfile.FileCopyFlags.Security) FileCopyFlags.SetItemChecked(3, true);
            if (ProfileManager.CurrentProfile.FileCopyFlags.Owner) FileCopyFlags.SetItemChecked(4, true);
            if (ProfileManager.CurrentProfile.FileCopyFlags.Auditing) FileCopyFlags.SetItemChecked(5, true);

            // Directory Copy Flags
            if (ProfileManager.CurrentProfile.DirectoryCopyFlags.Data) DirectoryCopyFlags.SetItemChecked(0, true);
            if (ProfileManager.CurrentProfile.DirectoryCopyFlags.Attributes) DirectoryCopyFlags.SetItemChecked(1, true);
            if (ProfileManager.CurrentProfile.DirectoryCopyFlags.TimeStamps) DirectoryCopyFlags.SetItemChecked(2, true);

            // Add Attributes
            if (ProfileManager.CurrentProfile.AddAttributes.ReadOnly) AddAttributes.SetItemChecked(0, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Archive) AddAttributes.SetItemChecked(1, true);
            if (ProfileManager.CurrentProfile.AddAttributes.System) AddAttributes.SetItemChecked(2, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Hidden) AddAttributes.SetItemChecked(3, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Compressed) AddAttributes.SetItemChecked(4, true);
            if (ProfileManager.CurrentProfile.AddAttributes.NotContentIndexed) AddAttributes.SetItemChecked(5, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Encrypted) AddAttributes.SetItemChecked(6, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Temporary) AddAttributes.SetItemChecked(7, true);
            if (ProfileManager.CurrentProfile.AddAttributes.Offline) AddAttributes.SetItemChecked(8, true);

            // Remove Attributes
            if (ProfileManager.CurrentProfile.RemoveAttributes.ReadOnly) RemoveAttributes.SetItemChecked(0, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Archive) RemoveAttributes.SetItemChecked(1, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.System) RemoveAttributes.SetItemChecked(2, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Hidden) RemoveAttributes.SetItemChecked(3, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Compressed) RemoveAttributes.SetItemChecked(4, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.NotContentIndexed) RemoveAttributes.SetItemChecked(5, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Encrypted) RemoveAttributes.SetItemChecked(6, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Temporary) RemoveAttributes.SetItemChecked(7, true);
            if (ProfileManager.CurrentProfile.RemoveAttributes.Offline) RemoveAttributes.SetItemChecked(8, true);

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
            ProfileManager.CurrentProfile.CopySubdirectories = CopySubdirectories.Checked;
        }

        private void EnableBackupMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.EnableBackupMode = EnableBackupMode.Checked;
        }

        private void CopySubdirectoriesIncludingEmpty_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.CopySubdirectoriesIncludingEmpty = CopySubdirectoriesIncludingEmpty.Checked;
        }

        private void EnableRestartMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.EnableRestartMode = EnableRestartMode.Checked;
        }

        private void UseUnbufferedIo_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.UseUnbufferedIo = UseUnbufferedIo.Checked;
        }

        private void Purge_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.Purge = Purge.Checked;
        }

        private void Mirror_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = ProfileManager.CurrentProfile.Mirror = Mirror.Checked;

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
            ProfileManager.CurrentProfile.FileFilter = FileFilter.Text;
        }

        private void FileCopyFlags_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FileCopyFlags.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ProfileManager.CurrentProfile.FileCopyFlags.Data = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.CurrentProfile.FileCopyFlags.Attributes = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.CurrentProfile.FileCopyFlags.TimeStamps = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.CurrentProfile.FileCopyFlags.Security = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.CurrentProfile.FileCopyFlags.Owner = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.CurrentProfile.FileCopyFlags.Auditing = FileCopyFlags.GetItemChecked(i);
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
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.Data = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.Attributes = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.TimeStamps = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.Security = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.Owner = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.CurrentProfile.DirectoryCopyFlags.Auditing = DirectoryCopyFlags.GetItemChecked(i);
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
                        ProfileManager.CurrentProfile.AddAttributes.ReadOnly = AddAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.CurrentProfile.AddAttributes.Archive = AddAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.CurrentProfile.AddAttributes.System = AddAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.CurrentProfile.AddAttributes.Hidden = AddAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.CurrentProfile.AddAttributes.Compressed = AddAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.CurrentProfile.AddAttributes.NotContentIndexed = AddAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        ProfileManager.CurrentProfile.AddAttributes.Encrypted = AddAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        ProfileManager.CurrentProfile.AddAttributes.Temporary = AddAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        ProfileManager.CurrentProfile.AddAttributes.Offline = AddAttributes.GetItemChecked(i);
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
                        ProfileManager.CurrentProfile.RemoveAttributes.ReadOnly = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        ProfileManager.CurrentProfile.RemoveAttributes.Archive = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        ProfileManager.CurrentProfile.RemoveAttributes.System = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        ProfileManager.CurrentProfile.RemoveAttributes.Hidden = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        ProfileManager.CurrentProfile.RemoveAttributes.Compressed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        ProfileManager.CurrentProfile.RemoveAttributes.NotContentIndexed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        ProfileManager.CurrentProfile.RemoveAttributes.Encrypted = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        ProfileManager.CurrentProfile.RemoveAttributes.Temporary = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        ProfileManager.CurrentProfile.RemoveAttributes.Offline = RemoveAttributes.GetItemChecked(i);
                        break;
                }
            }
        }

        private void MoveFiles_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.MoveFiles = MoveFiles.Checked;
        }

        private void MoveFilesAndDirectories_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.MoveFilesAndDirectories = MoveFilesAndDirectories.Checked;
        }

        private void CreateDirectoryAndFileTree_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.CreateDirectoryAndFileTree = CreateDirectoryAndFileTree.Checked;
        }

        private void FatFiles_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.FatFiles = FatFiles.Checked;
        }

        private void TurnLongPathSupportOff_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.TurnLongPathSupportOff = TurnLongPathSupportOff.Checked;
        }

        private void CopySymbolicLink_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.CopySymobolicLink = CopySymbolicLink.Checked;
        }

        private void DoNotUseWindowsCopyOffload_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.DoNotUseWindowsCopyOffload = DoNotUseWindowsCopyOffload.Checked;
        }

        private void CheckPerFile_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.CheckPerFile = CheckPerFile.Checked;
        }

        private void MultiThreadedCopies_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.MultiThreadedCopiesCount = (int)MultiThreadedCopies.Value;

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
            ProfileManager.CurrentProfile.InterPacketGap = (int)InterPacketGap.Value;

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
            ProfileManager.CurrentProfile.Depth = (int)Depth.Value;
        }

        private void UseEfwRawMode_CheckedChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.EnableEfsRawMode = UseEfwRawMode.Checked;

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
            ProfileManager.CurrentProfile.RetryCount = (int)RetryCount.Value;
        }

        private void RetryWaitTime_ValueChanged(object sender, EventArgs e)
        {
            ProfileManager.CurrentProfile.RetryWaitTime = (int)RetryWaitTime.Value;
        }

        private void ProfileName_TextChanged(object sender, EventArgs e)
        {
            ProfileManager.SetCurrentName(ProfileName.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}