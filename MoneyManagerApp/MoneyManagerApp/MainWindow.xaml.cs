//using Microsoft.EntityFrameworkCore;
using MoneyManagerApp.DAL;
using MoneyManagerApp.Presentation.Models;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // DBApplicationContext db = new DBApplicationContext();
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // гарантируем, что база данных создана
            
            
            
            
            db.Database.EnsureCreated();



            // загружаем данные из БД
            //db.Users.Load();
            // и устанавливаем данные в качестве контекста
            //DataContext = db.Users.Local.ToObservableCollection();
        }
    }
}
