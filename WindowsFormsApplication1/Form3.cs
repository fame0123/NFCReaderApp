using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace WindowsFormsApplication1
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            
            
        }

        private void form_login_Load(object sender, EventArgs e)
        {
           


            //txt_uname.Text = "Enter Username.";
            txt_pass.Text = "Enter Password.";
            if (txt_uname.Text.Trim() == "admin")
            { }
            else
            {
                txt_uname.ForeColor = Color.Gray;
            }
            txt_pass.ForeColor = Color.Gray;

            //btn_login.mouse;
        }

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




        private void txt_uname_Enter(object sender, EventArgs e)
        {
            if (txt_uname.Text == "Enter Username.")
            {
                txt_uname.Text = "";
                txt_uname.ForeColor = Color.Black;
                
            }
        }

        private void txt_uname_Leave(object sender, EventArgs e)
        {
            if (txt_uname.Text == "")
            {
                txt_uname.Text = "Enter Username.";
                txt_uname.ForeColor = Color.Gray;
                
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Enter Password.")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Black;
                txt_pass.PasswordChar = '◕';
            }
            
            //Bunifu.Framework.UI.BunifuFlatButton btn_login = this.btn_login;
            //this.AcceptButton = btn_login;
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Enter Password.";
                txt_pass.ForeColor = Color.Gray;
                this.txt_pass.PasswordChar = '\0';
            }
            
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btn_login_Click(this, new EventArgs());
                login();
            }
        }

        private void btn_openfb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007422016329");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fame.systems/");
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
          
            login();
        }
        private void login()
        {
            var currentDate = DateTime.Now.ToString("yyyy-M-d");
            var expiredDate = DateTime.Now.ToString("2022-2-28");

            if (currentDate == expiredDate)
            {
                MessageBox.Show("Sorry your application has been expired. Please contact the product owner thank you.");
                Application.Exit();
            }
            StreamReader sr = new StreamReader("resources.txt");

            //Read the first line of text
            var str1 = sr.ReadLine(); // sr.ReadToEnd -> read all text in notepad
            string encrpt = str1;

            sr.Close();

            //MessageBox.Show(str2[0] +"-"+str2[1]);


            if (txt_uname.Text.Trim() == "admin" && txt_pass.Text.Trim() == "famenfc123@")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    string passwords = DecryptString(encrpt, txt_pass.Text); // decripting

                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();

                }
                catch
                {
                    MessageBox.Show("Please Make sure you Entered the Rigth Key word. Please Try Again.");
                    txt_pass.Clear();
                }
            }
        }
    }
}
