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
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
            MaximumSize = MinimumSize = Size;
        }

        private void ToolStripMenuItem1_1_Click(object sender, EventArgs e)
        {
            編集window h = new 編集window(true);
            h.ShowDialog();
        }

        private void ToolStripMenuItem1_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "default.phoneenc";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "暗号化された電話帳ファイル(*.phoneenc)|*.phoneenc";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Program.path = ofd.FileName;
                編集window h = new 編集window(false);
                h.ShowDialog();
            }

        }

        private void ToolStripMenuItem2_1_Click(object sender, EventArgs e)
        {
            検索 k = new 検索();
            k.ShowDialog();
        }
    }
}
