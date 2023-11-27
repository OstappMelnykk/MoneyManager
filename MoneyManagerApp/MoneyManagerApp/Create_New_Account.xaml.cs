using System;
using System.Windows;
using MoneyManagerApp.Presentation.Models;

namespace MoneyManagerApp.Presentation
{
    public partial class Create_New_Account : Window
    {
        private ApplicationContext _dbContext; // Заміни це на свій контекст бази даних

        public Create_New_Account()
        {
            InitializeComponent();
            _dbContext = new ApplicationContext(); // Ініціалізуй контекст бази даних
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string accountName = AccountNameTextBox.Text;
            //int loggedInUserId = GetLoggedInUserId();

            if (!string.IsNullOrEmpty(accountName))
            {
                try
                {
                    // Створення нового об'єкту Account для збереження в базу даних
                    var newAccount = new Account
                    {
                        AccountsTitle = accountName
                    };

                    // Додавання нового об'єкту до DbSet в контексті бази даних
                    _dbContext.Accounts.Add(newAccount);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Account saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving account: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter an account name!");
            }
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
