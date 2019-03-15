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
            FileFilter.Text = Profiles.Current.FileFilter;
            CopySubdirectories.Checked = Profiles.Current.CopySubdirectories;
            CopySubdirectoriesIncludingEmpty.Checked = Profiles.Current.CopySubdirectoriesIncludingEmpty;
            EnableRestartMode.Checked = Profiles.Current.EnableRestartMode;
            EnableBackupMode.Checked = Profiles.Current.EnableBackupMode;
            UseUnbufferedIo.Checked = Profiles.Current.UseUnbufferedIo;
            UseEfwRawMode.Checked = Profiles.Current.EnableEfsRawMode;
            Mirror.Checked = Profiles.Current.Mirror;
            Purge.Checked = Profiles.Current.Purge;
            Depth.Value = Profiles.Current.Depth;
            MoveFiles.Checked = Profiles.Current.MoveFiles;
            MoveFilesAndDirectories.Checked = Profiles.Current.MoveFilesAndDirectories;
            CreateDirectoryAndFileTree.Checked = Profiles.Current.CreateDirectoryAndFileTree;
            FatFiles.Checked = Profiles.Current.FatFiles;
            TurnLongPathSupportOff.Checked = Profiles.Current.TurnLongPathSupportOff;
            CopySymbolicLink.Checked = Profiles.Current.CopySymobolicLink;
            DoNotUseWindowsCopyOffload.Checked = Profiles.Current.DoNotUseWindowsCopyOffload;
            CheckPerFile.Checked = Profiles.Current.CheckPerFile;
            MultiThreadedCopies.Value = Profiles.Current.MultiThreadedCopiesCount;
            InterPacketGap.Value = Profiles.Current.InterPacketGap;

            // File Copy Flags
            if (Profiles.Current.FileCopyFlags.Data) FileCopyFlags.SetItemChecked(0, true);
            if (Profiles.Current.FileCopyFlags.Attributes) FileCopyFlags.SetItemChecked(1, true);
            if (Profiles.Current.FileCopyFlags.TimeStamps) FileCopyFlags.SetItemChecked(2, true);
            if (Profiles.Current.FileCopyFlags.Security) FileCopyFlags.SetItemChecked(3, true);
            if (Profiles.Current.FileCopyFlags.Owner) FileCopyFlags.SetItemChecked(4, true);
            if (Profiles.Current.FileCopyFlags.Auditing) FileCopyFlags.SetItemChecked(5, true);

            // Directory Copy Flags
            if (Profiles.Current.DirectoryCopyFlags.Data) DirectoryCopyFlags.SetItemChecked(0, true);
            if (Profiles.Current.DirectoryCopyFlags.Attributes) DirectoryCopyFlags.SetItemChecked(1, true);
            if (Profiles.Current.DirectoryCopyFlags.TimeStamps) DirectoryCopyFlags.SetItemChecked(2, true);

            // Add Attributes
            if (Profiles.Current.AddAttributes.ReadOnly) AddAttributes.SetItemChecked(0, true);
            if (Profiles.Current.AddAttributes.Archive) AddAttributes.SetItemChecked(1, true);
            if (Profiles.Current.AddAttributes.System) AddAttributes.SetItemChecked(2, true);
            if (Profiles.Current.AddAttributes.Hidden) AddAttributes.SetItemChecked(3, true);
            if (Profiles.Current.AddAttributes.Compressed) AddAttributes.SetItemChecked(4, true);
            if (Profiles.Current.AddAttributes.NotContentIndexed) AddAttributes.SetItemChecked(5, true);
            if (Profiles.Current.AddAttributes.Encrypted) AddAttributes.SetItemChecked(6, true);
            if (Profiles.Current.AddAttributes.Temporary) AddAttributes.SetItemChecked(7, true);
            if (Profiles.Current.AddAttributes.Offline) AddAttributes.SetItemChecked(8, true);

            // Remove Attributes
            if (Profiles.Current.RemoveAttributes.ReadOnly) RemoveAttributes.SetItemChecked(0, true);
            if (Profiles.Current.RemoveAttributes.Archive) RemoveAttributes.SetItemChecked(1, true);
            if (Profiles.Current.RemoveAttributes.System) RemoveAttributes.SetItemChecked(2, true);
            if (Profiles.Current.RemoveAttributes.Hidden) RemoveAttributes.SetItemChecked(3, true);
            if (Profiles.Current.RemoveAttributes.Compressed) RemoveAttributes.SetItemChecked(4, true);
            if (Profiles.Current.RemoveAttributes.NotContentIndexed) RemoveAttributes.SetItemChecked(5, true);
            if (Profiles.Current.RemoveAttributes.Encrypted) RemoveAttributes.SetItemChecked(6, true);
            if (Profiles.Current.RemoveAttributes.Temporary) RemoveAttributes.SetItemChecked(7, true);
            if (Profiles.Current.RemoveAttributes.Offline) RemoveAttributes.SetItemChecked(8, true);

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
        }

        private void CopySubdirectories_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CopySubdirectories = CopySubdirectories.Checked;
        }

        private void EnableBackupMode_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableBackupMode = EnableBackupMode.Checked;
        }

        private void CopySubdirectoriesIncludingEmpty_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CopySubdirectoriesIncludingEmpty = CopySubdirectoriesIncludingEmpty.Checked;
        }

        private void EnableRestartMode_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableRestartMode = EnableRestartMode.Checked;
        }

        private void UseUnbufferedIo_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.UseUnbufferedIo = UseUnbufferedIo.Checked;
        }

        private void Purge_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.Purge = Purge.Checked;
        }

        private void Mirror_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = Profiles.Current.Mirror = Mirror.Checked;

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
            Profiles.Current.FileFilter = FileFilter.Text;
        }

        private void FileCopyFlags_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FileCopyFlags.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        Profiles.Current.FileCopyFlags.Data = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        Profiles.Current.FileCopyFlags.Attributes = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        Profiles.Current.FileCopyFlags.TimeStamps = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        Profiles.Current.FileCopyFlags.Security = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        Profiles.Current.FileCopyFlags.Owner = FileCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        Profiles.Current.FileCopyFlags.Auditing = FileCopyFlags.GetItemChecked(i);
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
                        Profiles.Current.DirectoryCopyFlags.Data = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 1:
                        Profiles.Current.DirectoryCopyFlags.Attributes = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 2:
                        Profiles.Current.DirectoryCopyFlags.TimeStamps = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 3:
                        Profiles.Current.DirectoryCopyFlags.Security = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 4:
                        Profiles.Current.DirectoryCopyFlags.Owner = DirectoryCopyFlags.GetItemChecked(i);
                        break;

                    case 5:
                        Profiles.Current.DirectoryCopyFlags.Auditing = DirectoryCopyFlags.GetItemChecked(i);
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
                        Profiles.Current.AddAttributes.ReadOnly = AddAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        Profiles.Current.AddAttributes.Archive = AddAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        Profiles.Current.AddAttributes.System = AddAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        Profiles.Current.AddAttributes.Hidden = AddAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        Profiles.Current.AddAttributes.Compressed = AddAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        Profiles.Current.AddAttributes.NotContentIndexed = AddAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        Profiles.Current.AddAttributes.Encrypted = AddAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        Profiles.Current.AddAttributes.Temporary = AddAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        Profiles.Current.AddAttributes.Offline = AddAttributes.GetItemChecked(i);
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
                        Profiles.Current.RemoveAttributes.ReadOnly = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 1:
                        Profiles.Current.RemoveAttributes.Archive = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 2:
                        Profiles.Current.RemoveAttributes.System = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 3:
                        Profiles.Current.RemoveAttributes.Hidden = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 4:
                        Profiles.Current.RemoveAttributes.Compressed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 5:
                        Profiles.Current.RemoveAttributes.NotContentIndexed = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 6:
                        Profiles.Current.RemoveAttributes.Encrypted = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 7:
                        Profiles.Current.RemoveAttributes.Temporary = RemoveAttributes.GetItemChecked(i);
                        break;

                    case 8:
                        Profiles.Current.RemoveAttributes.Offline = RemoveAttributes.GetItemChecked(i);
                        break;
                }
            }
        }

        private void MoveFiles_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.MoveFiles = MoveFiles.Checked;
        }

        private void MoveFilesAndDirectories_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.MoveFilesAndDirectories = MoveFilesAndDirectories.Checked;
        }

        private void CreateDirectoryAndFileTree_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CreateDirectoryAndFileTree = CreateDirectoryAndFileTree.Checked;
        }

        private void FatFiles_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.FatFiles = FatFiles.Checked;
        }

        private void TurnLongPathSupportOff_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.TurnLongPathSupportOff = TurnLongPathSupportOff.Checked;
        }

        private void CopySymbolicLink_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CopySymobolicLink = CopySymbolicLink.Checked;
        }

        private void DoNotUseWindowsCopyOffload_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.DoNotUseWindowsCopyOffload = DoNotUseWindowsCopyOffload.Checked;
        }

        private void CheckPerFile_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CheckPerFile = CheckPerFile.Checked;
        }

        private void MultiThreadedCopies_ValueChanged(object sender, EventArgs e)
        {
            Profiles.Current.MultiThreadedCopiesCount = (int)MultiThreadedCopies.Value;

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
            Profiles.Current.InterPacketGap = (int)InterPacketGap.Value;

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
            Profiles.Current.Depth = (int)Depth.Value;
        }

        private void UseEfwRawMode_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableEfsRawMode = UseEfwRawMode.Checked;

            if (UseEfwRawMode.Checked || InterPacketGap.Value > 0)
            {
                MultiThreadedCopies.Enabled = false;
            }
            else
            {
                MultiThreadedCopies.Enabled = true;
            }
        }
    }
}