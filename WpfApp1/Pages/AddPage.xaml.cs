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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != null && Pass.Text != null && Role.Text != null && Name.Text != null && Phone.Text != null)
            {
                string Rotle = null;
                Rotle = Role.Text;
                DateTime today = DateTime.Today;
                List<Users> users = Core.Context.Users.ToList();
                Users user = new Users
                {
                    Login = login.Text,
                    PasswordHash = Pass.Text,
                    Role = Convert.ToInt32(Rotle),
                    FullName = Name.Text,
                    Phone = Phone.Text,
                    IsFrozen = false,
                    CreatedAt = today
                };
                Core.Context.Users.Add(user);
                Core.Context.SaveChanges();
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
