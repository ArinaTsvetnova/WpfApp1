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
    /// Логика взаимодействия для StorePage.xaml
    /// </summary>
    public partial class StorePage : Page
    {
        List<Products> product;
        public StorePage()
        {
            InitializeComponent();
            product = Core.Context.Products.ToList();
            ProductListBox.ItemsSource = product;
            List<Sortir> ssort = new List<Sortir>()
            {
                new Sortir
                {
                    Name = "По типу товара",
                },
                new Sortir
                {
                    Name = "По производителю",
                },
                new Sortir
                {
                    Name = "Фильтрация",
                }
            };

            Sort.ItemsSource = ssort;
            Sort.DisplayMemberPath = "Name";
            Sort.SelectedIndex = 2;
            Shop.ssort = ProductListBox.SelectedItem as Sortir;
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
