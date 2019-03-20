using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    public partial class ProfileNamingForm : Form
    {
        internal string ChoosenName { get; private set; }

        public ProfileNamingForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChoosenName = textBox1.Text;

            Close();
        }
    }
}