using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private const string initVector = "pemgail9uzpgzl88";
        // This constant is used to determine the keysize of the encryption algorithm
        private const int keysize = 256;
        //Encrypt
        public static string EncryptString(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);
        }
        //Decrypt
        public static string DecryptString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Size = new Size(284, 109);

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("resources.txt");

            //Read the first line of text
            string str1 = sr.ReadLine(); // sr.ReadToEnd -> read all text in notepad
            string encrpt = str1;
            sr.Close();
            //
            //txt_oldpass.Text = encrpt;
            string decrot = "";
            try
            {
                decrot = DecryptString(encrpt, txt_oldpass.Text);
                groupBox1.Enabled = false;
                this.Size = new Size(284, 277);
            }
            catch
            {
                MessageBox.Show("Incorect..!");
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text.Trim() != "" && txt_conpass.Text.Trim() != "")
            {
                if (txt_newpass.Text.Trim() == txt_conpass.Text.Trim())
                {
                    string encrpt = EncryptString("famenfc123@", txt_newpass.Text.Trim());
                    //MessageBox.Show(encrpt);
                    StreamWriter log1 = new StreamWriter("resources.txt");
                    log1.WriteLine(encrpt);
                    log1.Close();

                    MessageBox.Show("Password Successfully Updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password did not Match.");
                }
            }
            else { MessageBox.Show("Must Fill-up All filed."); }
        }

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {
            if(txt_newpass.Text.Trim().Length >= 8)
            { btn_save.Enabled = true; }
            else
            { btn_save.Enabled = false; }
        }
    }
}
