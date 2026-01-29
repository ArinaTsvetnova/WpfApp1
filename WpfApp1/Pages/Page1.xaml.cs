using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            List<Product> product = Core.Context.Product.ToList();
            ProductListBox.ItemsSource = product;
        }
        private void ButtonBuy_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Product select_product = btn.DataContext as Product;
            Class1.basket.Add(select_product);
        }
        private void ButtonGoForward_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt++;
            NavigationService.Navigate(new Page2());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
