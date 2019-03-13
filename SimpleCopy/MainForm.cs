using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class MainForm : Form
    {
        private CopyForm _CopyForm;

        internal MainForm()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Auto-generated Form Components
                if (components != null) components.Dispose();

                // Manual disposal
                if (Profiles.Current != null) Profiles.Current.Dispose();
                if (_CopyForm != null) _CopyForm.Dispose();
            }

            base.Dispose(disposing);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load last Profile
            Profiles.Init();

            // Set form control values
            Source.Text = Profiles.Current.Source;
            Destination.Text = Profiles.Current.Destination;
            FileFilter.Text = Profiles.Current.FileFilter;
            CopySubdirectories.Checked = Profiles.Current.CopySubdirectories;
            CopySubdirectoriesIncludingEmpty.Checked = Profiles.Current.CopySubdirectoriesIncludingEmpty;
            EnableRestartMode.Checked = Profiles.Current.EnableRestartMode;
            EnableBackupMode.Checked = Profiles.Current.EnableBackupMode;
            UseUnbufferedIo.Checked = Profiles.Current.UseUnbufferedIo;
            UseEfwRawMode.Checked = Profiles.Current.EnableEfsRawMode;
            Mirror.Checked = Profiles.Current.Mirror;
            Purge.Checked = Profiles.Current.Purge;

            // Subscribe to form control events
            Source.TextChanged += new EventHandler(Source_TextChanged);
            Destination.TextChanged += new EventHandler(Destination_TextChanged);
            EnableRestartMode.CheckedChanged += new EventHandler(EnableRestartMode_CheckedChanged);
            EnableBackupMode.CheckedChanged += new EventHandler(EnableBackupMode_CheckedChanged);
            UseEfwRawMode.CheckedChanged += new EventHandler(EnableEfwRawMode_CheckedChanged);
            UseUnbufferedIo.CheckedChanged += new EventHandler(UseUnbufferedIo_CheckedChanged);
            CopySubdirectoriesIncludingEmpty.CheckedChanged += new EventHandler(CopySubdirectoriesIncludingEmpty_CheckedChanged);
            Purge.CheckedChanged += new EventHandler(Purge_CheckedChanged);
            CopySubdirectories.CheckedChanged += new EventHandler(CopySubdirectories_CheckedChanged);
            Mirror.CheckedChanged += new EventHandler(Mirror_CheckedChanged);
            FileFilter.TextChanged += new EventHandler(FileFilter_TextChanged);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_CopyForm != null)
            {
                _CopyForm.Close();
                _CopyForm.Dispose();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AboutForm.Open)
            {
                (new AboutForm()).Show();
            }
        }

        private void SourceBrowseButton_Click(object sender, EventArgs e)
        {
            if (SourceBrowser.ShowDialog() == DialogResult.OK)
            {
                Source.Text = SourceBrowser.SelectedPath;
            }
        }

        private void DestinationBrowseButton_Click(object sender, EventArgs e)
        {
            if (DestinationBrowser.ShowDialog() == DialogResult.OK)
            {
                Destination.Text = DestinationBrowser.SelectedPath;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Source/destination empty?
            if (String.IsNullOrEmpty(Source.Text))
            {
                MessageBox.Show("Source is not set.");

                Source.Focus();

                return;
            }

            if (String.IsNullOrEmpty(Destination.Text))
            {
                MessageBox.Show("Destination is not set.");

                Destination.Focus();

                return;
            }

            // Source/destination exists?
            if (!Directory.Exists(Source.Text))
            {
                MessageBox.Show("Source does not exist.");

                Source.Focus();

                return;
            }

            if (!Directory.Exists(Destination.Text))
            {
                Directory.CreateDirectory(Destination.Text);

                /*MessageBox.Show("Destination does not exist.");

                destinationDirectory.Focus();

                return;*/
            }

            CopyButton.Enabled = false;

            // Open Copy form
            _CopyForm = new CopyForm();

            _CopyForm.FormClosed += _CopyForm_FormClosed;

            _CopyForm.Show();
        }

        private void _CopyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CopyButton.Enabled = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CopyButton_Click(this, null);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProfileBrowser.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ProfileBrowser.FileName) != "xml")
                {
                    MessageBox.Show("Not a valid profile. File must have .xml extension.");

                    return;
                }

                Profiles.LoadFile(ProfileBrowser.FileName);
            }
        }

        #region Control Value Change Handling

        private void Source_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Source = Source.Text;
        }

        private void Destination_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Destination = Destination.Text;
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

        private void EnableEfwRawMode_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableEfsRawMode = UseEfwRawMode.Checked;
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

        #endregion Control Value Change Handling
    }
}