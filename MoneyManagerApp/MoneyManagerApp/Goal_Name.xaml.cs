using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
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
    /// <summary>
    /// Interaction logic for Goal_Name.xaml
    /// </summary>
    public partial class Goal_Name : Window
    {
        private int goalId;
        private Goal currentGoal;
        public Goal_Name(int goalId)
        {
            this.goalId = goalId;
            currentGoal = GetCurrentGoal(goalId);
            InitializeComponent();
            LoadGoal();
            
        }

        private static Goal GetCurrentGoal(int goalId)
        {
            using (var dbContext = new ApplicationContext())
            {
                // Отримайте суму транзакцій типу 1 для поточного облікового запису
                Goal goal = dbContext.Goals.Where(g => g.GoalsId == goalId).FirstOrDefault();

                // Отримайте суму транзакцій типу 2 для поточного облікового запису

                return goal;
            }
        }

        private string GetAccountNameById(int accountId)
        {
            using (var dbContext = new ApplicationContext())
            {
                // Отримайте суму транзакцій типу 1 для поточного облікового запису
                Account account = dbContext.Accounts.Where(a => a.AccountsId == accountId).FirstOrDefault();

                // Отримайте суму транзакцій типу 2 для поточного облікового запису

                return account.AccountsTitle;
            }
        }

        private void LoadGoal()
        {
            NumberToCollectTextBlock.Text = currentGoal.GoalsAmounttocollect.ToString();
            AmmountToCollectTextBlock.Text = currentGoal.GoalsAmounttocollect.ToString();
            DescriptionTextBlock.Text = currentGoal.GoalsDescription;
            GoalNameTextBlock.Text = currentGoal.GoalsTitle;
            AccountTextBlock.Text = GetAccountNameById((int)currentGoal.FkAccountsId);
            TitleTextBlock.Text = currentGoal.GoalsTitle;
            GoalProgressBar.Value = (double)GetBalanceDifference((int)currentGoal.FkAccountsId);
            GoalProgressBar.Maximum = (double)currentGoal.GoalsAmounttocollect;
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
