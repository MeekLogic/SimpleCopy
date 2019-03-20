using RoboSharp;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class CopyForm : Form
    {
        private RoboCommand _RoboCommand;
        private Stopwatch _Stopwatch;
        private int FileCount = 0;
        private long TotalFileSize = 0;

        internal CopyForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null) components.Dispose();

                if (_RoboCommand != null) _RoboCommand.Dispose();
            }

            base.Dispose(disposing);
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            _RoboCommand = new RoboCommand();

            // event handlers
            _RoboCommand.OnCommandError += _RoboCommand_OnCommandError;
            _RoboCommand.OnError += _RoboCommand_OnError;
            _RoboCommand.OnCopyProgressChanged += _RoboCommand_OnCopyProgressChanged;
            _RoboCommand.OnFileProcessed += _RoboCommand_OnFileProcessed;
            _RoboCommand.OnCommandCompleted += _RoboCommand_OnCommandCompleted;

            // _RoboCommand options
            _RoboCommand.CopyOptions.Source = Profiles.Current.Source;
            //
            _RoboCommand.CopyOptions.Destination = Profiles.Current.Destination;
            //
            _RoboCommand.CopyOptions.FileFilter = Profiles.Current.FileFilter;
            //
            if (Profiles.Current.Mirror)
            {
                _RoboCommand.CopyOptions.Mirror = true;
            }
            else
            {
                if (Profiles.Current.CopySubdirectoriesIncludingEmpty)
                {
                    _RoboCommand.CopyOptions.CopySubdirectoriesIncludingEmpty = true;
                }
                else
                {
                    _RoboCommand.CopyOptions.CopySubdirectories = Profiles.Current.CopySubdirectories;
                }
                //
                _RoboCommand.CopyOptions.Purge = Profiles.Current.Purge;
            }
            //
            if (Profiles.Current.EnableRestartMode && Profiles.Current.EnableBackupMode)
            {
                _RoboCommand.CopyOptions.EnableRestartModeWithBackupFallback = true;
            }
            else
            {
                _RoboCommand.CopyOptions.EnableRestartMode = Profiles.Current.EnableRestartMode;
                _RoboCommand.CopyOptions.EnableBackupMode = Profiles.Current.EnableBackupMode;
            }
            //
            _RoboCommand.CopyOptions.UseUnbufferedIo = Profiles.Current.UseUnbufferedIo;
            //
            if (Profiles.Current.EnableEfsRawMode || Profiles.Current.InterPacketGap > 0)
            {
                _RoboCommand.CopyOptions.EnableEfsRawMode = Profiles.Current.EnableEfsRawMode;
                _RoboCommand.CopyOptions.InterPacketGap = Profiles.Current.InterPacketGap;
            }
            else
            {
                _RoboCommand.CopyOptions.MultiThreadedCopiesCount = Profiles.Current.MultiThreadedCopiesCount;
            }
            //
            _RoboCommand.CopyOptions.Depth = Profiles.Current.Depth;
            //
            _RoboCommand.CopyOptions.FatFiles = Profiles.Current.FatFiles;
            //
            _RoboCommand.CopyOptions.TurnLongPathSupportOff = Profiles.Current.TurnLongPathSupportOff;
            //
            _RoboCommand.CopyOptions.CopySymbolicLink = Profiles.Current.CopySymobolicLink;
            //
            _RoboCommand.CopyOptions.DoNotUseWindowsCopyOffload = Profiles.Current.DoNotUseWindowsCopyOffload;
            //
            _RoboCommand.CopyOptions.CheckPerFile = Profiles.Current.CheckPerFile;
            //
            _RoboCommand.CopyOptions.CopyFlags = Profiles.Current.FileCopyFlags.ToString();
            //
            _RoboCommand.CopyOptions.DirectoryCopyFlags = Profiles.Current.DirectoryCopyFlags.ToString();
            //
            _RoboCommand.CopyOptions.AddAttributes = Profiles.Current.AddAttributes.ToString();
            //
            _RoboCommand.CopyOptions.RemoveAttributes = Profiles.Current.RemoveAttributes.ToString();
            //
            /*_RoboCommand.CopyOptions.MoveFiles = Profiles.Current.MoveFiles;
            //
            _RoboCommand.CopyOptions.MoveFilesAndDirectories = Profiles.Current.MoveFilesAndDirectories;
            //
            _RoboCommand.CopyOptions.CreateDirectoryAndFileTree = Profiles.Current.CreateDirectoryAndFileTree;*/
            //
            _RoboCommand.RetryOptions.RetryCount = Profiles.Current.RetryCount;
            //
            _RoboCommand.RetryOptions.RetryWaitTime = Profiles.Current.RetryWaitTime;

            _Stopwatch = new Stopwatch();
            _Stopwatch.Start();

            _RoboCommand.Start();

            PauseResumeButton.Enabled = true;
        }

        private void CopyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _RoboCommand.OnCopyProgressChanged -= _RoboCommand_OnCopyProgressChanged;
            _RoboCommand.OnFileProcessed -= _RoboCommand_OnFileProcessed;
            _RoboCommand.OnCommandCompleted -= _RoboCommand_OnCommandCompleted;

            _RoboCommand.Stop();

            _RoboCommand.Dispose();
        }

        private void _RoboCommand_OnCommandError(object sender, ErrorEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show(e.Error.ToString());
            }));
        }

        private void _RoboCommand_OnError(object sender, ErrorEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show(e.Error.ToString());
            }));
        }

        private void _RoboCommand_OnCopyProgressChanged(object sender, CopyProgressEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                TaskbarProgress.SetValue(Handle, (int)e.CurrentFileProgress, 100);

                CurrentFileProgress.Value = (int)e.CurrentFileProgress;
            }));
        }

        private void _RoboCommand_OnFileProcessed(object sender, FileProcessedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                if (e.ProcessedFile.FileClassType == FileClassType.SystemMessage)
                {
                    SystemMessage.Text = e.ProcessedFile.Name;
                }
                else
                {
                    CurrentFile.Text = e.ProcessedFile.FileClass + ": " + e.ProcessedFile.Name;

                    if (e.ProcessedFile.FileClassType == FileClassType.File)
                    {
                        CurrentSize.Text = Utilities.GetBytesReadable(e.ProcessedFile.Size);
                    }
                }

                if (e.ProcessedFile.FileClassType == FileClassType.File)
                {
                    FileCount++;
                    TotalFileSize += e.ProcessedFile.Size;
                }
            }));
        }

        private void _RoboCommand_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                _Stopwatch.Stop();

                CurrentFileProgress.Value = 100;

                TaskbarProgress.SetValue(Handle, 100, 100);

                PauseResumeButton.Enabled = false;

                Text = "Finished";

                JobLogger.Log(new Job
                {
                    TotalMillseconds = _Stopwatch.ElapsedMilliseconds,
                    TotalBytes = TotalFileSize,
                    TotalFiles = FileCount
                });

                Activate();
            }));
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (_RoboCommand.IsPaused)
            {
                _RoboCommand.Resume();

                _Stopwatch.Start();

                PauseResumeButton.Text = "Pause";
            }
            else
            {
                _RoboCommand.Pause();

                _Stopwatch.Stop();

                PauseResumeButton.Text = "Resume";
            }
        }
    }
}