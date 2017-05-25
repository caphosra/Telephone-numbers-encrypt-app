using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_numbers_encrypt_app
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0) Application.Run(new mainwindow());
            else
            {
                path = System.IO.Path.ChangeExtension(args[0], ".phone");
                Application.Run(new 編集window(false));
            }
        }

        public static string path = null;
    }
}
