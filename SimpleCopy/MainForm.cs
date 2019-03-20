using System;
using System.IO;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class MainForm : Form
    {
        private readonly string WorkDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        private readonly System.Timers.Timer SourceSaveTimer = new System.Timers.Timer(1000);
        private readonly System.Timers.Timer DestinationSaveTimer = new System.Timers.Timer(1000);

        private ProfileNamingForm _ProfileNamingForm;
        private ProfileEditorForm _ProfileEditorForm;
        private CopyForm _CopyForm;

        internal MainForm()
        {
            InitializeComponent();

            SourceSaveTimer.AutoReset = false;
            DestinationSaveTimer.AutoReset = false;

            SourceSaveTimer.Elapsed += SourceSaveTimer_Elapsed;
            DestinationSaveTimer.Elapsed += DestinationSaveTimer_Elapsed;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Auto-generated Form Components
                if (components != null) components.Dispose();

                // Manual disposal
                if (ProfileManager.Current != null) ProfileManager.Current.Dispose();
                if (_CopyForm != null) _CopyForm.Dispose();
            }

            base.Dispose(disposing);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProfileManager.ProfileLoaded += Profiles_ProfileLoaded;

            // Load last Profile
            ProfileManager.Init(WorkDir);

            // Init Job logger
            JobLogger.Init(WorkDir);
        }

        private void Profiles_ProfileLoaded(object sender, ProfileLoadedEventArgs e)
        {
            if (_ProfileEditorForm != null) _ProfileEditorForm.Close();

            Source.TextChanged -= Source_TextChanged;
            Destination.TextChanged -= Destination_TextChanged;

            // Set form control values
            Source.Text = ProfileManager.Current.Source;
            Destination.Text = ProfileManager.Current.Destination;

            // Set default paths for file/folder browsers
            if (!string.IsNullOrEmpty(ProfileManager.Current.Source))
            {
                SourceBrowser.SelectedPath = ProfileManager.Current.Source;
            }

            if (!string.IsNullOrEmpty(ProfileManager.Current.Destination))
            {
                DestinationBrowser.SelectedPath = ProfileManager.Current.Destination;
            }

            ProfileBrowser.InitialDirectory = ProfileManager.ProfilesDirectory;

            // Subscribe to form control events
            Source.TextChanged += new EventHandler(Source_TextChanged);
            Destination.TextChanged += new EventHandler(Destination_TextChanged);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_CopyForm != null) _CopyForm.Close();
            if (_ProfileEditorForm != null) _ProfileEditorForm.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ProfileEditorForm == null)
            {
                _ProfileEditorForm = new ProfileEditorForm();
                _ProfileEditorForm.FormClosed += _ProfileEditorForm_FormClosed;
                _ProfileEditorForm.Show();
            }
            else
            {
                _ProfileEditorForm.Focus();
            }
        }

        private void _ProfileEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ProfileEditorForm = null;
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            if (SourceBrowser.ShowDialog() == DialogResult.OK)
            {
                Source.Text = SourceBrowser.SelectedPath;
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (DestinationBrowser.ShowDialog() == DialogResult.OK)
            {
                Destination.Text = DestinationBrowser.SelectedPath;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            // Source/destination empty?
            if (string.IsNullOrEmpty(Source.Text))
            {
                MessageBox.Show("Source is not set.");

                Source.Focus();

                return;
            }

            if (string.IsNullOrEmpty(Destination.Text))
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
            }

            CopyButton.Enabled = false;

            // Open Copy form
            _CopyForm = new CopyForm();
            _CopyForm.FormClosed += _CopyForm_FormClosed;
            _CopyForm.Show();
        }

        private void _CopyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SourceSaveTimer.Enabled)
            {
                SourceSaveTimer.Stop();

                SourceSaveTimer_Elapsed(this, null);

                SourceSaveTimer.Dispose();
            }

            if (DestinationSaveTimer.Enabled)
            {
                DestinationSaveTimer.Stop();

                DestinationSaveTimer_Elapsed(this, null);

                DestinationSaveTimer.Dispose();
            }

            _CopyForm.Dispose();
            _CopyForm = null;

            CopyButton.Enabled = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CopyButton_Click(this, null);
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableControls();

            if (ProfileBrowser.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ProfileBrowser.FileName) != ".xml")
                {
                    MessageBox.Show("Not a valid profile. File must have .xml extension.");

                    return;
                }

                ProfileManager.LoadFile(ProfileBrowser.FileName);
            }

            EnableControls();
        }

        private void Source_TextChanged(object sender, EventArgs e)
        {
            if (SourceSaveTimer.Enabled)
            {
                SourceSaveTimer.Stop();
            }

            SourceSaveTimer.Start();
        }

        private void SourceSaveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string Source = Utilities.RemoveTrailingSlash(this.Source.Text);

            if (!Source.Equals(this.Source.Text))
            {
                BeginInvoke((Action)(() =>
                {
                    this.Source.TextChanged -= Source_TextChanged;

                    this.Source.Text = Source;

                    this.Source.TextChanged += Source_TextChanged;
                }));
            }

            ProfileManager.Current.Source = Source;
        }

        private void Destination_TextChanged(object sender, EventArgs e)
        {
            if (DestinationSaveTimer.Enabled)
            {
                DestinationSaveTimer.Stop();
            }

            DestinationSaveTimer.Start();
        }

        private void DestinationSaveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string Destination = Utilities.RemoveTrailingSlash(this.Destination.Text);

            if (!Destination.Equals(this.Destination.Text))
            {
                BeginInvoke((Action)(() =>
                {
                    this.Destination.TextChanged -= Destination_TextChanged;

                    this.Destination.Text = Destination;

                    this.Destination.TextChanged += Destination_TextChanged;
                }));
            }

            ProfileManager.Current.Destination = Destination;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ProfileNamingForm = new ProfileNamingForm();
            _ProfileNamingForm.FormClosed += _ProfileNamingForm_FormClosed;
            _ProfileNamingForm.Show();

            DisableControls();
        }

        private void DisableControls()
        {
            LoadToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            SourceButton.Enabled = false;
            DestinationButton.Enabled = false;
            CopyButton.Enabled = false;
        }

        private void EnableControls()
        {
            LoadToolStripMenuItem.Enabled = true;
            newToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            SourceButton.Enabled = true;
            DestinationButton.Enabled = true;
            CopyButton.Enabled = true;
        }

        private void _ProfileNamingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_ProfileNamingForm.ChoosenName))
            {
                ProfileManager.Create(_ProfileNamingForm.ChoosenName);
                ProfileManager.Load(_ProfileNamingForm.ChoosenName);
            }

            _ProfileNamingForm = null;

            EnableControls();
        }
    }
}