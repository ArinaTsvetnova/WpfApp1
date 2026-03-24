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
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = Core1.Context.User.ToList(); 
            User afuser = users.FirstOrDefault(U => U.Email.ToLower() == email.Text.ToLower());
            if (afuser == null)
                return;
            if (afuser.Password == password.Text)
            {
                UserInfo.kupt = afuser;
                NavigationService.Navigate(new Page3());
                if (NavigationService.CanGoForward)
                {
                    NavigationService.GoForward();
                }
            }
            else
            {
                MessageBox.Show("Неправильный ввод пароля! Попробуйте еще раз");
            }
        }
    }
}
