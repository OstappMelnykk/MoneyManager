using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public ObservableCollection<Transaction> Transactions { get; set; }
        public Home()
        {
            InitializeComponent();
            int currentUserId = GetCurrentUserId(); // Отримання Id поточного користувача, наприклад, із збереженого значення
            if (CountOfOpenningHomePage.Count == 1)
            {
                GetCurrentUserAccount(currentUserId);
                CountOfOpenningHomePage.Count = 2;
            }
            string currentUserAccountName = CurrentAccount.AccountTitle; // Отримання назви облікового запису поточного користувача
            AccountNameLabel.Content = currentUserAccountName; // Встановлення назви акаунта у TextBox
            BalanceLabel.Content = GetBalanceDifference().ToString() + "₴";
            List<Transaction> currentAccountTransactions = GetCurrentAccountTransactions(CurrentAccount.AccountId);
            Transactions = new ObservableCollection<Transaction>(currentAccountTransactions);
            DataContext = this;
        }

        // Додайте цей метод до коду вашого вікна Home
       

        private int GetCurrentUserId()
        {
            return CurrentUser.UserId;
        }

        private void GetCurrentUserAccount(int currentUserId)
        {
            using (var dbContext = new ApplicationContext()) // Замість YourDbContext вкажіть ваш контекст бази даних
            {
                var currentUserAccount = dbContext.Accounts.FirstOrDefault(a => a.FkUsersId == currentUserId);
                CurrentAccount.SetCurrentAccount(currentUserAccount.AccountsId, currentUserAccount.AccountsTitle);
            }
        }
        private decimal GetBalanceDifference()
        {
            using (var dbContext = new ApplicationContext())
            {
                // Отримайте суму транзакцій типу 1 для поточного облікового запису
                decimal sumType1 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdTo == CurrentAccount.AccountId)
                    .Sum(t => t.TransactionsSum);

                // Отримайте суму транзакцій типу 2 для поточного облікового запису
                decimal sumType2 = dbContext.Transactions
                    .Where(t => t.FkAccountsIdFrom == CurrentAccount.AccountId)
                    .Sum(t => t.TransactionsSum);

                // Обчисліть різницю сум типу 1 та типу 2
                return sumType1 - sumType2;
            }
        }

        private List<Transaction> GetCurrentAccountTransactions(int currentAccountId)
        {
            using (var dbContext = new ApplicationContext())
            {
                var transactions = dbContext.Transactions
                    .Where(t => t.FkAccountsIdTo == currentAccountId || t.FkAccountsIdFrom == currentAccountId)
                    .ToList();

                return transactions;
            }
        }

        private void Button_See_More_Click(object sender, RoutedEventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }

        private void Button_Add_Transaction_Click(object sender, RoutedEventArgs e)
        {
            Add_Transactions add_Transactions = new Add_Transactions();
            add_Transactions.Show();
            this.Close();

        }

        private void Button_Account_Settings_Click(object sender, RoutedEventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
            this.Close();
        }

        private void HomeLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
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
