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

namespace bankkkkkk
{
    /// <summary>
    /// Логика взаимодействия для Avtorisation.xaml
    /// </summary>
    public partial class Avtorisation : Window
    {
        public Avtorisation()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Password = txtPassword.Password;
            string role = txtLogin.Text;

            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                if ((txtLogin.Text == "lol")
              && (txtPassword.Password == "123"))
                {
                    //MessageBox.Show("Registration successful!");
                    MainWindow window1 = new MainWindow();
                    window1.Show();
                    Close();
                }

                else
                {
                    MessageBox.Show("Неверно введен логин или пароль.");
                }



            }
            else
            {
                MessageBox.Show("Введите логин и пароль.");
            }



        }
    }
}
