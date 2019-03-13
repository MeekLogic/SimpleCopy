using RoboSharp;
using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class CopyForm : Form
    {
        private RoboCommand _RoboCommand;

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
            _RoboCommand.CopyOptions.EnableEfsRawMode = Profiles.Current.EnableEfsRawMode;

            // retry options
            _RoboCommand.RetryOptions.RetryCount = 60;
            _RoboCommand.RetryOptions.RetryWaitTime = 10;

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

        private void _RoboCommand_OnCommandError(object sender, RoboSharp.ErrorEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show(e.Error.ToString());
            }));
        }

        private void _RoboCommand_OnError(object sender, RoboSharp.ErrorEventArgs e)
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
            }));
        }

        private void _RoboCommand_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                CurrentFileProgress.Value = 100;

                PauseResumeButton.Enabled = false;

                Text = "Finished";
            }));
        }

        private void PauseResumeButton_Click(object sender, EventArgs e)
        {
            if (_RoboCommand.IsPaused)
            {
                _RoboCommand.Resume();

                PauseResumeButton.Text = "Pause";
            }
            else
            {
                _RoboCommand.Pause();

                PauseResumeButton.Text = "Resume";
            }
        }
    }
}