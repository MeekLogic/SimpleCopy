using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal partial class AboutForm : Form
    {
        internal AboutForm()
        {
            InitializeComponent();
        }

        internal static bool Open { get; set; }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Open = true;
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Open = false;
        }
    }
}