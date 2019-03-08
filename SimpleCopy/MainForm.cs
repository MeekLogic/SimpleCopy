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
            checkBox1.Checked = Profiles.Current.CopySubdirectories;
            checkBox2.Checked = Profiles.Current.CopySubdirectoriesIncludingEmpty;
            checkBox3.Checked = Profiles.Current.EnableRestartMode;
            checkBox4.Checked = Profiles.Current.EnableBackupMode;
            checkBox5.Checked = Profiles.Current.UseUnbufferedIo;
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

            CopyForm copy = new CopyForm(sourceDirectory.Text, destinationDirectory.Text);

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
    }
}
