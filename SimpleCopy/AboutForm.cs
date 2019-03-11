using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        public static bool Open { get; set; }

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
