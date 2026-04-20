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
    /// Логика взаимодействия для PodrobPage.xaml
    /// </summary>
    public partial class PodrobPage : Page
    {
        List<Appointments> appointments;
        public PodrobPage(Appointments b)
        {
            InitializeComponent();
            appointments = Core.Context.Appointments.Where(ap=>ap.IdServiceTypes == b.IdServiceTypes).ToList(); ;
            Load();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MasterPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Load()
        {
            Podrob.ItemsSource = null;
            Podrob.ItemsSource = appointments;
        }
    }
}
