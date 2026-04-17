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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string login = TextLogin.Text.Trim();
            string password = TextPassword.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            var user = Core.Context.Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
            {
                MessageBox.Show("Пользователь с таким логином не найден.");
                return;
            }
            if (user.IsFrozen)
            {
                MessageBox.Show("Ваш аккаунт заблокирован. Обратитесь к администратору.");
                return;
            }
            if (user.PasswordHash != password)
            {
                MessageBox.Show("Неверный пароль.");
                return;
            }
            AppSession.CurrentUser = user;
            if (AppSession.CurrentUser != null)
            {
                switch (AppSession.CurrentUser.Role)
                {
                    case 0: // Клиент
                        NavigationService.Navigate(new AccountPageView());
                        break;
                    case 1: // Мастер
                        NavigationService.Navigate(new MasterPageView());
                        break;
                    case 2: // Менеджер
                        NavigationService.Navigate(new ManagerPageView());
                        break;
                    case 3: // Админ
                        NavigationService.Navigate(new AdminPageView());
                        break;
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            TextLogin.Clear();
            TextPassword.Clear();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
