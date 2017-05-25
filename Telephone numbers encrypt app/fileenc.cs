using System.IO;
using System.Security.Cryptography;

namespace Telephone_numbers_encrypt_app
{
    public class fileenc
    {
        //
        //http://dobon.net/vb/dotnet/string/encryptfile.html を引用させていただきました。
        //

        /// <summary>
        /// パスワードから共有キーと初期化ベクタを生成する
        /// </summary>
        /// <param name="password">基になるパスワード</param>
        /// <param name="keySize">共有キーのサイズ（ビット）</param>
        /// <param name="key">作成された共有キー</param>
        /// <param name="blockSize">初期化ベクタのサイズ（ビット）</param>
        /// <param name="iv">作成された初期化ベクタ</param>
        private static void GenerateKeyFromPassword(string password,int keySize, out byte[] key, int blockSize, out byte[] iv)
        {
            //パスワードから共有キーと初期化ベクタを作成する
            //saltを決める
            byte[] salt = System.Text.Encoding.UTF8.GetBytes("saltは必ず8バイト以上");
            //Rfc2898DeriveBytesオブジェクトを作成する
            Rfc2898DeriveBytes deriveBytes =
                new Rfc2898DeriveBytes(password, salt);
            //.NET Framework 1.1以下の時は、PasswordDeriveBytesを使用する
            //System.Security.Cryptography.PasswordDeriveBytes deriveBytes =
            //    new System.Security.Cryptography.PasswordDeriveBytes(password, salt);
            //反復処理回数を指定する デフォルトで1000回
            deriveBytes.IterationCount = 1000;

            //共有キーと初期化ベクタを生成する
            key = deriveBytes.GetBytes(keySize / 8);
            iv = deriveBytes.GetBytes(blockSize / 8);
        }

        /// <summary>
        /// ファイルを暗号化する
        /// </summary>
        /// <param name="sourceFile">暗号化するファイルパス</param>
        /// <param name="destFile">暗号化されたデータを保存するファイルパス</param>
        /// <param name="password">暗号化に使用するパスワード</param>
        public static void EncryptFile(string sourceFile, string destFile, string password)
        {
            RijndaelManaged rijndael =
                new RijndaelManaged();

            //パスワードから共有キーと初期化ベクタを作成
            byte[] key, iv;
            GenerateKeyFromPassword(
                password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
            rijndael.Key = key;
            rijndael.IV = iv;

            //以下、前のコードと同じ
            FileStream outFs = new FileStream(
                destFile, FileMode.Create, FileAccess.Write);
            ICryptoTransform encryptor =
                rijndael.CreateEncryptor();
            CryptoStream cryptStrm =
                new CryptoStream(
                    outFs, encryptor,
                    CryptoStreamMode.Write);

            FileStream inFs = new FileStream(
                sourceFile, FileMode.Open, FileAccess.Read);
            byte[] bs = new byte[1024];
            int readLen;
            while ((readLen = inFs.Read(bs, 0, bs.Length)) > 0)
            {
                cryptStrm.Write(bs, 0, readLen);
            }

            inFs.Close();
            cryptStrm.Close();
            encryptor.Dispose();
            outFs.Close();
        }

        /// <summary>
        /// ファイルを復号化する
        /// </summary>
        /// <param name="sourceFile">復号化するファイルパス</param>
        /// <param name="destFile">復号化されたデータを保存するファイルパス</param>
        /// <param name="password">暗号化に使用したパスワード</param>
        public static void DecryptFile(string sourceFile, string destFile, string password)
        {
            RijndaelManaged rijndael =
                new RijndaelManaged();

            //パスワードから共有キーと初期化ベクタを作成
            byte[] key, iv;
            GenerateKeyFromPassword(
                password, rijndael.KeySize, out key, rijndael.BlockSize, out iv);
            rijndael.Key = key;
            rijndael.IV = iv;

            //以下、前のコードと同じ
            FileStream inFs = new FileStream(
                sourceFile, FileMode.Open, FileAccess.Read);
            ICryptoTransform decryptor =
                rijndael.CreateDecryptor();
            CryptoStream cryptStrm =
                new CryptoStream(
                    inFs, decryptor,
                    CryptoStreamMode.Read);

            FileStream outFs = new FileStream(
                destFile, FileMode.Create, FileAccess.Write);
            byte[] bs = new byte[1024];
            int readLen;
            while ((readLen = cryptStrm.Read(bs, 0, bs.Length)) > 0)
            {
                outFs.Write(bs, 0, readLen);
            }

            outFs.Close();
            cryptStrm.Close();
            decryptor.Dispose();
            inFs.Close();
        }
    }
}
