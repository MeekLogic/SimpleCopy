using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class MainForm : Form
    {
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
            if (String.IsNullOrEmpty(sourceDirectory.Text))
            {
                MessageBox.Show("Source is not set.");

                return;
            }

            if (String.IsNullOrEmpty(destinationDirectory.Text))
            {
                MessageBox.Show("Destination is not set.");

                return;
            }

            CopyForm copy = new CopyForm();

            copy.Show();
        }

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
            Profiles.Current.Mirror = checkBox7.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Profiles.Current.FileFilter = textBox1.Text;
        }
    }
}
