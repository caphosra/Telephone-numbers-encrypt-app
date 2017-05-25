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

        public password()
        {
            InitializeComponent();
            MinimumSize = MaximumSize = Size;
        }

        private void button_Click(object sender, EventArgs e)
        {
            str = textBox.Text;
            Close();
        }
    }
}
