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

        private void button1_Click(object sender, EventArgs e)
        {
            if (sourceBrowser.ShowDialog() == DialogResult.OK)
            {
                sourceDirectory.Text = sourceBrowser.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (destinationBrowser.ShowDialog() != DialogResult.OK)
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
