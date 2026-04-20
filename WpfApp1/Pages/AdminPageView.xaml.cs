using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPageView.xaml
    /// </summary>
    public partial class AdminPageView : Page
    {
        List<Users> users;
        public AdminPageView()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            users = Core.Context.Users.ToList();
            UserAll.ItemsSource = null;
            UserAll.ItemsSource = users;

        }

        private void Fruzen_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Users editUsers = b.DataContext as Users;
            if (editUsers.IsFrozen == false)
            {
                editUsers.IsFrozen = true;

                Load();
            }
            else
            {
                editUsers.IsFrozen = false;
                Load();
            }

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
