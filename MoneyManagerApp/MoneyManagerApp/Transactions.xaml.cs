using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

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
    }
}
