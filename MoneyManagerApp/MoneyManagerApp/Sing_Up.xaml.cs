using MoneyManagerApp.Presentation.Models;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
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

            if (db.Users.Any(u => u.UsersName == username || u.UsersEmail == emailOrPhoneNumber || u.UsersPhonenumber == emailOrPhoneNumber))
            {
                MessageBox.Show("Користувач з таким ім'ям, електронною поштою або номером телефону вже існує.");
                return;
            }

            var saltBytes = new byte[16];
            var rng = new SecureRandom();
            rng.NextBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);

            string passwordHash = HashPassword(password, salt);

            User newUser = new User
            {
                UsersName = username,
                UsersPhonenumber = emailOrPhoneNumber,
                UsersEmail = emailOrPhoneNumber,
                PasswordHash = passwordHash,
                PasswordSalt = salt
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            MessageBox.Show("Реєстрація успішна!");
            ClearFields();
        }

        private string HashPassword(string password, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);

            var pbkdf2 = new Pkcs5S2ParametersGenerator(new Sha256Digest());
            pbkdf2.Init(Encoding.UTF8.GetBytes(password), saltBytes, 10000);

            byte[] hash = ((KeyParameter)pbkdf2.GenerateDerivedParameters(256)).GetKey();

            return Convert.ToBase64String(hash);
        }

        private void ClearFields()
        {
            UsernameTextBox.Text = "";
            EmailOrPhoneTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
