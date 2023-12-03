using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System.Collections.Generic;
using System.Linq;
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
                    Background = Brushes.Blue
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
                    Background = new SolidColorBrush(Color.FromRgb(170, 0, 215))
                };

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
                decimal sumType1 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdTo == accountId && t.FkAccountsIdFrom == null && t.TransactionsType == 1)
                    .Sum(t => t.TransactionsSum);

                decimal sumType2 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdTo == null && t.FkAccountsIdFrom == accountId && t.TransactionsType == 2)
                    .Sum(t => t.TransactionsSum);

                return sumType1 - sumType2;
            }
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
            Bar_Graph bar_Graph = new Bar_Graph();
            bar_Graph.Show();
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
