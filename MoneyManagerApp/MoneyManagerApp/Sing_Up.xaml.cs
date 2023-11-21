using MoneyManagerApp.Presentation.Models;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MoneyManagerApp.Presentation
{
    public partial class Sing_Up : Window
    {
        ApplicationContext db = new ApplicationContext();

        public Sing_Up()
        {
            InitializeComponent();
            SignUpButton.Click += SignUpButton_Click;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string emailOrPhoneNumber = EmailOrPhoneTextBox.Text;
            string password = PasswordTextBox.Text;


            signUp(username, emailOrPhoneNumber, password);

            /*Home HomeWindow = new Home();


            HomeWindow.Show();
            this.Close();*/
            //ClearFields();
        }

        private void signUp(string username, string emailOrPhoneNumber, string password)
        {
            if (db.Users.Any(u => u.UsersName == username || u.UsersEmail == emailOrPhoneNumber || u.UsersPhonenumber == emailOrPhoneNumber))
            {
                MessageBox.Show("Користувач з таким ім'ям, електронною поштою або номером телефону вже існує.");


                /*Home HomeWindow = new Home();


                HomeWindow.Show();
                this.Close();*/
                return;
            }

            (byte[], byte[]) T = PasswordHelper.GetHashAndSalt(password);

            byte[] salt = T.Item1;
            byte[] hash = T.Item2;


            User newUser = new User
            {
                UsersName = username,
                UsersPhonenumber = emailOrPhoneNumber,
                UsersEmail = emailOrPhoneNumber,
                PasswordHash = Convert.ToBase64String(hash),
                PasswordSalt = Convert.ToBase64String(salt)
            };

            db.Users.Add(newUser);
            db.SaveChanges();

           
            return;
        }
        


        private void ClearFields()
        {
            UsernameTextBox.Text = "";
            EmailOrPhoneTextBox.Text = "";
            PasswordTextBox.Text = "";

           /* Home HomeWindow = new Home();
            this.Close();

            HomeWindow.Show();*/
           
        }
    }



    public static class PasswordHelper
    {

        public static byte[] GenerateSalt(int length)
        {
            byte[] salt = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static byte[] GenerateHash(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32);
            }
        }

       
        public static (byte[], byte[]) GetHashAndSalt(string password)
        {
            byte[] salt = GenerateSalt(16); 
            byte[] hash = GenerateHash(password, salt);
            return (salt, hash);
        }
    }
}
