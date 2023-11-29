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
    /// Interaction logic for Add_Transactions.xaml
    /// </summary>
    public partial class Add_Transactions : Window
    {
        public Add_Transactions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Transfer_To_Account_Click(object sender, RoutedEventArgs e)
        {
            Transfer_To_Account transfer_To_Account = new Transfer_To_Account();
            transfer_To_Account.Show();
            this.Close();
        }

        private void Button_Transfer_From_Account_Click(object sender, RoutedEventArgs e)
        {
            Transfer_From_Account transfer_From_Account = new Transfer_From_Account();
            transfer_From_Account.Show();
            this.Close();
        }

        private void Button_Transfer_Between_Accounts_Click(object sender, RoutedEventArgs e)
        {
            Transfer_Between_Accounts transfer_Between_Accounts = new Transfer_Between_Accounts();
            transfer_Between_Accounts.Show();
            this.Close();

        }
    }
}
