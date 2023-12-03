﻿using System;
using System.Windows;
using System.Windows.Input;
using MoneyManagerApp.DAL.Helpers;
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

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            string accountName = AccountNameTextBox.Text;

            if (!string.IsNullOrEmpty(accountName))
            {
                try
                {
                    // Створення нового об'єкту Account для збереження в базу даних
                    Account newAccount = new Account();
                    newAccount.AccountsTitle = accountName;
                    newAccount.FkUsersId = CurrentUser.UserId;

                    // Додавання нового об'єкту до DbSet в контексті бази даних
                    _dbContext.Accounts.Add(newAccount);
                    _dbContext.SaveChanges();

                    Accounts accounts = new Accounts();
                    accounts.Show();
                    this.Close();
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
