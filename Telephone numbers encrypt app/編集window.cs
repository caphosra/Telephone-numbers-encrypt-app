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
    public partial class 編集window : Form
    {
        private bool create = false;

        public 編集window(bool create)
        {
            InitializeComponent();

            this.create = create;
            MinimumSize = MaximumSize = Size;

            if (create) Text = "新規作成";
            else
            {
                Text = "編集";
                password ps = new password();
                ps.ShowDialog();
                fileenc.DecryptFile(Program.path + "enc", Program.path, ps.str);
                ps.Dispose();
                string str = System.IO.File.ReadAllText(Program.path);
                string[] str2 = str.Split(';');
                textBox0.Text = str2[0];
                textBox1.Text = str2[1];
                textBox2.Text = str2[2];
                textBox3.Text = str2[3];
                textBox4.Text = str2[4];
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(create)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.FileName = "新しいファイル.phone";
                sfd.InitialDirectory = @"C:\";
                sfd.Filter = "すべてのファイル(*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.Title = "保存先のファイルを選択してください";
                sfd.RestoreDirectory = true;

                //ダイアログを表示する
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filename = sfd.FileName;
                    sfd.Dispose();
                    //OKボタンがクリックされたとき、選択されたファイル名を表示する
                    var task = Task.Run(() =>
                    {
                        System.IO.File.WriteAllText(filename, textBox0.Text + ";" +
                        textBox1.Text + ";" +
                        textBox2.Text + ";" +
                        textBox3.Text + ";" +
                        textBox4.Text);
                    });
                    task.Wait();
                    fileenc.EncryptFile(filename, filename + "enc", textBox4.Text);
                    System.IO.File.Delete(filename);
                    Close();
                }
            }
            else
            {
                System.IO.File.WriteAllText(Program.path, textBox0.Text + ";" + 
                    textBox1.Text + ";" + 
                    textBox2.Text + ";" + 
                    textBox3.Text + ";" + 
                    textBox4.Text);
                fileenc.EncryptFile(Program.path, Program.path + "enc", textBox4.Text);
                System.IO.File.Delete(Program.path);
                Close();
            }
        }
    }
}
