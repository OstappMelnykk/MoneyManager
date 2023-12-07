using Microsoft.EntityFrameworkCore;
using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MoneyManagerApp.Presentation
{
    public partial class Accounts : Window
    {
        public Accounts()
        {
            InitializeComponent();
            LoadUserAccounts();
        }

        private void LoadUserAccounts()
        {
            Style customButtonStyle = new Style(typeof(Button));

            // Adding setters to the style
            customButtonStyle.Setters.Add(new Setter(Border.CornerRadiusProperty, new CornerRadius(5)));

            // Assigning the style to Application.Current.Resources
            Application.Current.Resources["CustomButtonStyle"] = customButtonStyle;
            List<Account> userAccounts = GetUserAccounts();

            for (int i = 0; i < userAccounts.Count; i++)
            {
                TextBlock accountTextBlock = new TextBlock
                {
                    Text = userAccounts[i].AccountsTitle,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 160 + (80 * i), 410, 0),
                    TextWrapping = TextWrapping.Wrap,
                    VerticalAlignment = VerticalAlignment.Top,
                    FontSize = 23,
                    Height = 30,
                    Width = 100
                };

                TextBlock balanceTextBlock = new TextBlock
                {
                    Text = GetBalanceDifference(userAccounts[i].AccountsId).ToString(),
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 160 + (80 * i), 60, 0),
                    TextWrapping = TextWrapping.Wrap,
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 100,
                    FontSize = 23
                };

                Button chooseButton = new Button
                {
                    Content = "Choose",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(200, 160 + (80 * i), 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 80,
                    Height = 30,
                    FontSize = 20,
                    Tag = userAccounts[i],
                    Background = Brushes.Blue,
                    Foreground = Brushes.White,

                };
                
                chooseButton.Click += ChooseButton_Click;

                Button deleteButton = new Button
                {
                    Content = "Delete",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(450, 160 + (80 * i), 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 80,
                    Height = 30,
                    FontSize = 20,
                    Background = new SolidColorBrush(Color.FromRgb(170, 0, 215)),
                    Foreground = Brushes.White,
                    Tag = userAccounts[i],
                    Style = customButtonStyle,

                };

                

                deleteButton.Click += Delete_Button_Click;

                AccountsGrid.Children.Add(accountTextBlock);
                AccountsGrid.Children.Add(balanceTextBlock);
                AccountsGrid.Children.Add(chooseButton);
                AccountsGrid.Children.Add(deleteButton);
            }
        }


        private decimal GetBalanceDifference(int accountId)
        {
            using (var dbContext = new ApplicationContext())
            {
                // Отримайте суму транзакцій типу 1 для поточного облікового запису
                decimal sumType1 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdTo == accountId)
                    .Sum(t => t.TransactionsSum);

                // Отримайте суму транзакцій типу 2 для поточного облікового запису
                decimal sumType2 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdFrom == accountId)
                    .Sum(t => t.TransactionsSum);

                // Обчисліть різницю сум типу 1 та типу 2
                return sumType1 - sumType2;
            }
        }

        public void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Account selectedAccount)
            {


                using (var dbContext = new ApplicationContext())
                {
                    var accountToDelete = dbContext.Accounts.FirstOrDefault(a => a.AccountsId == selectedAccount.AccountsId);

                    if (accountToDelete != null)
                    {
                        // Видалення всіх транзакцій, пов'язаних з акаунтом
                        var transactionsToDelete = dbContext.Transactions.Where(t => t.FkAccountsIdFrom == selectedAccount.AccountsId || t.FkAccountsIdTo == selectedAccount.AccountsId);
                        dbContext.Transactions.RemoveRange(transactionsToDelete);

                        // Видалення акаунту
                        dbContext.Accounts.Remove(accountToDelete);

                        dbContext.SaveChanges();
                    }
                }
            }
            Accounts accounts = new Accounts();
            accounts.Show();
            this.Close();
        }

        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Account selectedAccount)
            {
                CurrentAccount.SetCurrentAccount(selectedAccount.AccountsId, selectedAccount.AccountsTitle);
            }
            Home home = new Home();
            home.Show();
            this.Close();
        }
        
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private List<Account> GetUserAccounts()
        {
            List<Account> currentUserAccounts;
            using (var dbContext = new ApplicationContext())
            {
                currentUserAccounts = dbContext.Accounts.Where(a => a.FkUsersId == CurrentUser.UserId).ToList();
            }
            return currentUserAccounts;
        }

        private void Button_Create_New_Account_Click(object sender, RoutedEventArgs e)
        {
            Create_New_Account create_New_Account = new Create_New_Account();
            create_New_Account.Show();
            this.Close();
        }
        private void HomeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void AccountsLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            

        }

        private void MyGoalsLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Close();
        }

        private void StatisticLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Line_Graph line_Graph = new Line_Graph();
            line_Graph.Show();
            this.Close();
        }

        private void MyProfileLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            My_Profile my_Profile1 = new My_Profile();
            my_Profile1.Show();
            this.Close();
        }


    }
}
