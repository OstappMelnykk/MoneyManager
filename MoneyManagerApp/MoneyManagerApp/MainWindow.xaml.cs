//using Microsoft.EntityFrameworkCore;
//using MoneyManagerApp.DAL;
using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation;
using MoneyManagerApp.Presentation.Models;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
//using MoneyManagerApp.DAL.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoneyManagerApp
{

    public partial class MainWindow : Window
    {

        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {                               
            db.Database.EnsureCreated();
        }
        

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameOrEmailTextBox.Text;
            string password = PasswordTextBox.Password;

            User user = db.Users.FirstOrDefault(u => u.UsersName == username);

            if (user != null)
            {
                byte[] salt = Convert.FromBase64String(user.PasswordSalt);
                byte[] hash = PasswordHelper.GenerateHash(password, salt);

                string enteredPasswordHash = Convert.ToBase64String(hash);

                if (enteredPasswordHash == user.PasswordHash)
                {
                    // Successful login
                    MessageBox.Show("Login Successful!");
                    CurrentUser.SetCurrentUser(user.UsersId, user.UsersName);
                    
                }
                else
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.Content = "Не правильньний логін або пароль";
                    UsernameOrEmailTextBox.ToolTip = toolTip;
                    UsernameOrEmailTextBox.BorderBrush = Brushes.Red;
                    PasswordTextBox.BorderBrush = Brushes.Red;
                    ClearFields();
                    return;

                }
            }
            else
            {

                ToolTip toolTip = new ToolTip();
                toolTip.Content = "Не правильний логін або пароль";
                UsernameOrEmailTextBox.ToolTip = toolTip;
                UsernameOrEmailTextBox.BorderBrush = Brushes.Red;
                PasswordTextBox.BorderBrush = Brushes.Red;
                ClearFields();
                return;

            }
        }


        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
           
            Sing_Up signUpWindow = new Sing_Up();
            signUpWindow.Show();
            this.Close();

        }

        private void ClearFields()
        {
            UsernameOrEmailTextBox.Text = "";
            PasswordTextBox.Clear();

           

        }

    }
}
