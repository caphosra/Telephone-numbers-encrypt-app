using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_numbers_encrypt_app
{
    public partial class password : Form
    {
        public string str = "";

        public password(string text = "input")
        {
            InitializeComponent();
            MinimumSize = MaximumSize = Size;
            Text = text;
        }

        private void button_Click(object sender, EventArgs e)
        {
            str = textBox.Text;
            Close();
        }
    }
}
