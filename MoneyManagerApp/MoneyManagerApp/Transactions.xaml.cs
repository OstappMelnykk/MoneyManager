using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace MoneyManagerApp.Presentation
{
    public partial class Transactions : Window
    {
        public ObservableCollection<Transaction> TransactionList { get; set; }

        public Transactions()
        {
            InitializeComponent();
            LoadUserTransactions();
        }

        private void LoadUserTransactions()
        {
            List<Transaction> currentAccountTransactions = GetCurrentUserTransactions();
            TransactionList = new ObservableCollection<Transaction>(currentAccountTransactions);
            DataContext = this;
        }

        private List<Transaction> GetCurrentUserTransactions()
        {
            List<Transaction> userTransactions;

            using (var dbContext = new ApplicationContext())
            {
                var currentUserAccounts = dbContext.Accounts.Where(a => a.FkUsersId == CurrentUser.UserId).Select(a => a.AccountsId).ToList();

                userTransactions = dbContext.Transactions
                    .Where(t => currentUserAccounts.Contains((int)t.FkAccountsIdFrom) || currentUserAccounts.Contains((int)t.FkAccountsIdTo))
                    .ToList();
            }

            return userTransactions;
        }
        private void HomeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void AccountsLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Show();
            this.Close();

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
