using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class MainForm : Form
    {
        private CopyForm copy;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load profile
            Profiles.Init();

            sourceDirectory.Text = Profiles.Current.Source;
            destinationDirectory.Text = Profiles.Current.Destination;
            textBox1.Text = Profiles.Current.FileFilter;
            checkBox1.Checked = Profiles.Current.CopySubdirectories;
            checkBox2.Checked = Profiles.Current.CopySubdirectoriesIncludingEmpty;
            checkBox3.Checked = Profiles.Current.EnableRestartMode;
            checkBox4.Checked = Profiles.Current.EnableBackupMode;
            checkBox5.Checked = Profiles.Current.UseUnbufferedIo;
            checkBox6.Checked = Profiles.Current.EnableEfsRawMode;
            checkBox7.Checked = Profiles.Current.Mirror;
            checkBox8.Checked = Profiles.Current.Purge;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AboutForm.Open)
            {
                (new AboutForm()).Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sourceBrowser.ShowDialog() == DialogResult.OK)
            {
                sourceDirectory.Text = sourceBrowser.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (destinationBrowser.ShowDialog() == DialogResult.OK)
            {
                destinationDirectory.Text = destinationBrowser.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Source/destination empty?
            if (String.IsNullOrEmpty(sourceDirectory.Text))
            {
                MessageBox.Show("Source is not set.");

                sourceDirectory.Focus();

                return;
            }

            if (String.IsNullOrEmpty(destinationDirectory.Text))
            {
                MessageBox.Show("Destination is not set.");

                destinationDirectory.Focus();

                return;
            }

            // Source/destination exists?
            if (!Directory.Exists(sourceDirectory.Text))
            {
                MessageBox.Show("Source does not exist.");

                sourceDirectory.Focus();

                return;
            }

            if (!Directory.Exists(destinationDirectory.Text))
            {
                Directory.CreateDirectory(destinationDirectory.Text);

                /*MessageBox.Show("Destination does not exist.");

                destinationDirectory.Focus();

                return;*/
            }

            button3.Enabled = false;

            // Open Copy form
            copy = new CopyForm();

            copy.FormClosed += Copy_FormClosed;

            copy.Show();
        }

        private void Copy_FormClosed(object sender, FormClosedEventArgs e)
        {
            button3.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (copy != null)
            {
                copy.Close();
                copy.Dispose();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button3_Click(this, null);
            }
        }

        #region Control Value Change Handling

        private void sourceDirectory_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Source = sourceDirectory.Text;
        }

        private void destinationDirectory_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.Destination = destinationDirectory.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CopySubdirectories = checkBox1.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableBackupMode = checkBox4.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.CopySubdirectoriesIncludingEmpty = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableRestartMode = checkBox3.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.UseUnbufferedIo = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.EnableEfsRawMode = checkBox6.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Profiles.Current.Purge = checkBox8.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = Profiles.Current.Mirror = checkBox7.Checked;

            checkBox1.Enabled = !enabled;
            //
            checkBox2.Checked = enabled;
            checkBox2.Enabled = !enabled;
            //
            checkBox8.Checked = enabled;
            checkBox8.Enabled = !enabled;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.FileFilter = textBox1.Text;
        }

        #endregion Control Value Change Handling

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) != "xml")
                {
                    MessageBox.Show("Not a valid profile. File must have .xml extension.");

                    return;
                }

                Profiles.LoadFile(openFileDialog1.FileName);
            }
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}