using RoboSharp;
using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class CopyForm : Form
    {
        private string sourceDirectory;
        private string destinationDirectory;

        public CopyForm(string source, string destination)
        {
            InitializeComponent();

            sourceDirectory = source;
            destinationDirectory = destination;
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            RoboCommand backup = new RoboCommand();

            // events
            backup.OnFileProcessed += backup_OnFileProcessed;
            backup.OnCommandCompleted += backup_OnCommandCompleted;

            // copy options
            backup.CopyOptions.Source = sourceDirectory;
            backup.CopyOptions.Destination = destinationDirectory;
            backup.CopyOptions.CopySubdirectories = true;
            backup.CopyOptions.UseUnbufferedIo = true;

            // select options
            backup.SelectionOptions.OnlyCopyArchiveFilesAndResetArchiveFlag = true;

            // retry options
            backup.RetryOptions.RetryCount = 60;
            backup.RetryOptions.RetryWaitTime = 10;

            backup.Start();
        }

        void backup_OnFileProcessed(object sender, FileProcessedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                CurrentOperation.Text = e.ProcessedFile.FileClass;
                CurrentFile.Text = e.ProcessedFile.Name;
                CurrentSize.Text = e.ProcessedFile.Size.ToString();
            }));
        }

        void backup_OnCommandCompleted(object sender, RoboCommandCompletedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                MessageBox.Show("Backup Complete!");
            }));
        }
    }
}
