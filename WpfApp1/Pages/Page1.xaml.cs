using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Chois1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }   
        }

        private void Chois3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois4_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois5_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page6());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois6_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page7());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois7_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page8());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Chois8_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page9());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
