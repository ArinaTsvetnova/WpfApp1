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
    /// Логика взаимодействия для MasterPageView.xaml
    /// </summary>
    public partial class MasterPageView : Page
    {
        List<Appointments> appointments;
        List<MasterServices> serviceTypes;
        public MasterPageView()
        {
            InitializeComponent();
            Load();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Load()
        {
            appointments = Core.Context.Appointments.Where(a => a.IdUsersM == AppSession.CurrentUser.IdUsers).ToList();
            serviceTypes = AppSession.CurrentUser.MasterServices.ToList();// Core.Context.ServiceTypes.ToList();
            Zapis.ItemsSource = null;
            Zapis.ItemsSource = appointments;
            Yslug.ItemsSource = null;
            Yslug.ItemsSource = serviceTypes;
        }

        private void AddYslug_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddYslPage());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Look_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            NavigationService.Navigate(new PodrobPage(b.DataContext as Appointments));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
