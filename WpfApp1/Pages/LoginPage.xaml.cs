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

            // 1. Базовая валидация
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
                // 2. Поиск пользователя в БД
                var user = Core.Context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с таким логином не найден.");
                    return;
                }

                // 3. Проверка блокировки (IsFrozen)
                if (user.IsFrozen)
                {
                    MessageBox.Show("Ваш аккаунт заблокирован. Обратитесь к администратору.");
                    return;
                }

                // 4. Проверка пароля
                // В учебных проектах часто хранят пароль как строку.
                // В реальном приложении здесь сравниваются хеши (например, через BCrypt).
                if (user.PasswordHash != password)
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }

                // 5. Успешная авторизация
                // Сохраняем пользователя в глобальную сессию
                AppSession.CurrentUser = user;

                // Закрываем окно и возвращаем успех
                this.DialogResult = true;
                this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

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
