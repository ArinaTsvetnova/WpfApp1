using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            string N = name.Text;
            string E = email.Text;
            string P = password.Text;
            Reg(N, E, P);
            if (Reg(N, E, P) == true)
            {
                NavigationService.Navigate(new Page3());
                if (NavigationService.CanGoForward)
                {
                    NavigationService.GoForward();
                }
            }
        }
        public bool Reg(string N, string E, string P)
        {
            if (N != "" && E != "" && P != "" && N != " " && E != " " && P != " ")
            {
                List<User> users = Core1.Context.User.ToList();
                User newUser = new User // создание нового пользователя
                {
                    Name = N,
                    Email = E,
                    Password = P
                };
                Core1.Context.User.Add(newUser);
                Core1.Context.SaveChanges();
                UserInfo.kupt = newUser;
                return true;
            }
            else
            {
                MessageBox.Show("Ошибка ввода полей");
                return false; 
            }
        }
    }
}
