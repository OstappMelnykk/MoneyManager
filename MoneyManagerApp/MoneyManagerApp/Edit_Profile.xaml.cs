using Microsoft.Win32;
using MoneyManagerApp.DAL.Helpers;
using MoneyManagerApp.Presentation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

    public partial class Edit_Profile : Window
    {
        private ApplicationContext dbContext;
        public Edit_Profile()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
        }

        private byte[] newPhoto = null;
        private string textFromFirstTextBox = "";
        private string textFromSecondTextBox = "";
        private string textFromThirdTextBox = "";

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
            this.Close();
        }
            
            
            
            
            
            
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            textFromFirstTextBox = FirstTextBox.Text;
            textFromSecondTextBox = SecondTextBox.Text;
            textFromThirdTextBox = ThirdTextBox.Text;

            bool isChanged = false;

            using (var dbContext = new ApplicationContext())
            {
                var entityToUpdate = dbContext.Users.Where(x => x.UsersId == CurrentUser.UserId).FirstOrDefault();

                if (entityToUpdate != null)
                {

                    if(!string.IsNullOrEmpty(textFromFirstTextBox) && textFromFirstTextBox != entityToUpdate.UsersName)
                    {
                        entityToUpdate.UsersName = textFromFirstTextBox;
                        isChanged = true;
                    }
                    if (!string.IsNullOrEmpty(textFromSecondTextBox) && textFromSecondTextBox != entityToUpdate.UsersPhonenumber)
                    {
                        entityToUpdate.UsersPhonenumber = textFromSecondTextBox;
                        isChanged = true;
                    }
                    if (!string.IsNullOrEmpty(textFromThirdTextBox) && textFromThirdTextBox != entityToUpdate.UsersEmail)
                    {
                        entityToUpdate.UsersEmail = textFromThirdTextBox;
                        isChanged = true;
                    }
                    if (newPhoto != null && newPhoto != entityToUpdate.UsersPhoto)
                    {
                        entityToUpdate.UsersPhoto = newPhoto;
                        isChanged = true;
                    }


                    if (isChanged)
                    {
                        dbContext.SaveChanges();
                        FirstTextBox.Text = "";
                        SecondTextBox.Text = "";
                        ThirdTextBox.Text = "";
                        MessageBox.Show("Зміни успішно збережено.");
                    }
                    else
                    {
                        MessageBox.Show("Нічого не змінено.");
                    }
                }
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Change_Photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли зображень (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFileName = openFileDialog.FileName;

                byte[] imageBytes = System.IO.File.ReadAllBytes(selectedFileName);
                newPhoto = imageBytes;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = new MemoryStream(imageBytes);
                bitmap.EndInit();

                // Показати зображення на WPF
                NewPhotoImage.Source = bitmap;
                



                // Вам потрібно мати об'єкт користувача або модель даних, в яку ви збираєтесь зберігати ці байти.
                // Наприклад, якщо у вас є об'єкт user з полем UsersPhoto типу byte[], ви можете зберегти зображення таким чином:
                // user.UsersPhoto = imageBytes;

                // Тепер вам потрібно зберегти цього користувача у базу даних з використанням Entity Framework або ADO.NET.
                // Вам також потрібно знати які поля в базі даних відповідають полям моделі вашого користувача, і як правильно зберегти байтовий масив.
            }
        }
    }
}
