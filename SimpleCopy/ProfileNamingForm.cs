using System;
using System.Windows.Forms;

namespace SimpleCopy
{
    internal class NameChoosenEventArgs : EventArgs
    {
        internal string Name { get; set; }
    }

    internal partial class ProfileNamingForm : Form
    {
        internal event EventHandler<NameChoosenEventArgs> NameChoosen;

        internal ProfileNamingForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                NameChoosen(this, new NameChoosenEventArgs
                {
                    Name = textBox1.Text
                });
            }

            Close();
        }
    }
}