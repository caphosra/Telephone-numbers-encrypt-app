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
    public partial class 検索 : Form
    {
        string path = "";

        public 検索()
        {
            InitializeComponent();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            fbd.Description = "フォルダを指定してください。";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = @"C:\Windows";
            
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
        }
    }
}
