using System.Windows.Controls;
using WpfApp1.Models;
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
            Load();
        }

        private void Chois_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            switch((sender as Button).Tag)
            {
                case "1":
                    NavigationService.Navigate(new Page2(1));
                    break;
                case "2":
                    NavigationService.Navigate(new Page2(2));
                    break;
                case "3":
                    NavigationService.Navigate(new Page2(3));
                    break;
                case "4":
                    NavigationService.Navigate(new Page2(4));
                    break;
                case "5":
                    NavigationService.Navigate(new Page2(5));
                    break;
                case "6":
                    NavigationService.Navigate(new Page2(6));
                    break;
                case "7":
                    NavigationService.Navigate(new Page2(7));
                    break;
                case "8":
                    NavigationService.Navigate(new Page2(8));
                    break;
            }
        }

        private void Clear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Lists.Clean();
            Load();
        }

        private void Load()
        {
            DetailsChois.ItemsSource = null;
            DetailsChois.ItemsSource = Lists.sborka;
            
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Load();
        }

        private void Del_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Button b = sender as Button;
            Lists.Remove(b.DataContext as basepart_);
            Load();
        }
    }
}
