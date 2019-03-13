using RoboSharp;
using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class CopyForm : Form
    {
        private RoboCommand copy;

        public CopyForm()
        {
            InitializeComponent();
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            copy = new RoboCommand();

            // event handlers
            copy.OnCommandError += Copy_OnCommandError;
            copy.OnError += Copy_OnError;
            copy.OnCopyProgressChanged += Copy_OnCopyProgressChanged;
            copy.OnFileProcessed += copy_OnFileProcessed;
            copy.OnCommandCompleted += copy_OnCommandCompleted;

            // copy options
            copy.CopyOptions.Source = Profiles.Current.Source;
            //
            copy.CopyOptions.Destination = Profiles.Current.Destination;
            //
            copy.CopyOptions.FileFilter = Profiles.Current.FileFilter;
            //
            if (Profiles.Current.Mirror)
            {
                copy.CopyOptions.Mirror = true;
            }
            else
            {
                if (Profiles.Current.CopySubdirectoriesIncludingEmpty)
                {
                    copy.CopyOptions.CopySubdirectoriesIncludingEmpty = true;
                }
                else
                {
                    copy.CopyOptions.CopySubdirectories = Profiles.Current.CopySubdirectories;
                }
                //
                copy.CopyOptions.Purge = Profiles.Current.Purge;
            }
            //
            if (Profiles.Current.EnableRestartMode && Profiles.Current.EnableBackupMode)
            {
                copy.CopyOptions.EnableRestartModeWithBackupFallback = true;
            }
            else
            {
                copy.CopyOptions.EnableRestartMode = Profiles.Current.EnableRestartMode;
                copy.CopyOptions.EnableBackupMode = Profiles.Current.EnableBackupMode;
            }
            //
            copy.CopyOptions.UseUnbufferedIo = Profiles.Current.UseUnbufferedIo;
            //
            copy.CopyOptions.EnableEfsRawMode = Profiles.Current.EnableEfsRawMode;

            // retry options
            copy.RetryOptions.RetryCount = 60;
            copy.RetryOptions.RetryWaitTime = 10;

            copy.Start();

            button2.Enabled = true;
        }

        private void Copy_OnCommandError(object sender, RoboSharp.ErrorEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show(e.Error.ToString());
            }));
        }

        private void Copy_OnError(object sender, RoboSharp.ErrorEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show(e.Error.ToString());
            }));
        }

        private void Copy_OnCopyProgressChanged(object sender, CopyProgressEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                progressBar1.Value = (int)e.CurrentFileProgress;
            }));
        }

        private void copy_OnFileProcessed(object sender, FileProcessedEventArgs e)
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
                        CurrentSize.Text = GetBytesReadable(e.ProcessedFile.Size);
                    }
                }
            }));
        }

        private void copy_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                progressBar1.Value = 100;

                button2.Enabled = false;

                Text = "Finished";
            }));
        }

        private void CopyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            copy.OnCopyProgressChanged -= Copy_OnCopyProgressChanged;
            copy.OnFileProcessed -= copy_OnFileProcessed;
            copy.OnCommandCompleted -= copy_OnCommandCompleted;

            copy.Stop();

            copy.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (copy.IsPaused)
            {
                copy.Resume();

                button2.Text = "Pause";
            }
            else
            {
                copy.Pause();

                button2.Text = "Resume";
            }
        }

        // Returns the human-readable file size for an arbitrary, 64-bit file size
        // The default format is "0.### XB", e.g. "4.2 KB" or "1.434 GB"
        public string GetBytesReadable(long i)
        {
            // Get absolute value
            long absolute_i = (i < 0 ? -i : i);
            // Determine the suffix and readable value
            string suffix;
            double readable;
            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (i >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (i >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (i >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (i >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (i >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = i;
            }
            else
            {
                return i.ToString("0 B"); // Byte
            }
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }
    }
}