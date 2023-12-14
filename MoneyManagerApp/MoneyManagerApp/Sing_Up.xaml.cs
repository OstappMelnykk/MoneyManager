using Microsoft.EntityFrameworkCore;
using MoneyManagerApp.DAL.Helpers;
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
        string username;
        string emailOrPhoneNumber;
        string password;


        ApplicationContext db = new ApplicationContext();

        public Sing_Up()
        {
            InitializeComponent();
           
        }


       /* public Sing_Up(ApplicationContext _db)
        {
            InitializeComponent();
            db = _db;
        }*/


        public string GetUsernameTextBox()
        {
            return UsernameTextBox.Text;
        }
        
        public string GetEmailOrPhoneTextBox()
        {
            return EmailOrPhoneTextBox.Text;
        }

        public string GetPasswordTextBox()
        {
            return PasswordTextBox.Password;
        }



        
        public void SetUsernameTextBox(string text)
        {
            UsernameTextBox.Text = text;
        }

        public void SetEmailOrPhoneTextBox(string text)
        {
            EmailOrPhoneTextBox.Text = text;
        }
         
        public void SetPasswordTextBox(string text)
        {
            PasswordTextBox.Password = text;
        }


        public Button GetSignUpButton()
        {
            return SignUpButton; // Повернення кнопки SignUpButton
        }

        public void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string emailOrPhoneNumber = EmailOrPhoneTextBox.Text;
            string password = PasswordTextBox.Password;


            bool containsOnlyDigits = emailOrPhoneNumber.All(char.IsDigit);
            bool containsAtSymbol = emailOrPhoneNumber.Contains('@');

            // Перевірка наявності користувача перед реєстрацією нового користувача
            if (IsUserAlreadyRegistered(username, emailOrPhoneNumber))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Content = "Користувач з таким ім'ям, електронною адресою або номером телефону вже існує";
                UsernameTextBox.ToolTip = toolTip;
                UsernameTextBox.BorderBrush = Brushes.Red;
                EmailOrPhoneTextBox.BorderBrush = Brushes.Red;
                return;
            }
            else{
                UsernameTextBox.ToolTip = null;
                UsernameTextBox.BorderBrush = Brushes.Black;
                if (containsOnlyDigits || containsAtSymbol)
                {

                }
                else
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.Content = "Не правильна електронна адреса або номер телефону";
                    EmailOrPhoneTextBox.ToolTip = toolTip;
                    EmailOrPhoneTextBox.BorderBrush = Brushes.Red;
                    return;
                }
            }

            

            // Реєстрація нового користувача
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


            CurrentUser.SetCurrentUser(newUser.UsersId, newUser.UsersName);


            Account newAccount = new Account();
            newAccount.AccountsTitle = "Account";
            newAccount.FkUsersId = CurrentUser.UserId;

 
            db.Accounts.Add(newAccount);
            db.SaveChanges();


            Home loginWindow = new Home(); // Замініть 'MainWindow' на вашу назву вікна входу
            loginWindow.Show();
            this.Close();
        }


        public bool CurrentUserHasAccount(int currentUserId)
        {
            using (var dbContext = new ApplicationContext()) // Замість YourDbContext вкажіть ваш контекст бази даних
            {
                var currentUserAccount = dbContext.Accounts.FirstOrDefault(a => a.FkUsersId == currentUserId);
                if (currentUserAccount != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        private bool IsUserAlreadyRegistered(string username, string emailOrPhoneNumber)
        {
            return db.Users.Any(u => u.UsersName == username || u.UsersEmail == emailOrPhoneNumber || u.UsersPhonenumber == emailOrPhoneNumber);
        }


        private void ClearFields()
        {
            UsernameTextBox.Text = "";
            EmailOrPhoneTextBox.Text = "";
            PasswordTextBox.Clear();

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
