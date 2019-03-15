using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class MainForm : Form
    {
        private ProfileEditorForm _ProfileEditorForm;
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

        private void Source_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Source = Source.Text;
        }

        private void Destination_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Destination = Destination.Text;
        }
    }
}