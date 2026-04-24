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
        List<Products> products;
        public StorePage()
        {
            InitializeComponent();
            products = Core.Context.Products.ToList();
            ProductListBox.ItemsSource = products;
            List<Sortir> ssort = new List<Sortir>()
            {
                new Sortir
                {
                    Name = "По типу товара",
                },
                new Sortir
                {
                    Name = "По рейтингу",
                },
                new Sortir
                {
                    Name = "Фильтрация",
                },
                new Sortir
                {
                    Name = "По производителю",
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
        private void Poisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Poisc.Text))
            {
                ProductListBox.ItemsSource = products;
            }
            else
            {
                ProductListBox.ItemsSource = Core.Context.Products.Where(f => f.Name.Contains(Poisc.Text)).ToList(); //возвращает список фильмов, которые имеют символы как в поисковой строке и присваивает переменную листбоксу(которую мы привели к типу данных лист)
            }
        }
        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sort.SelectedIndex == 0)
            {
                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = Core.Context.Products.OrderBy(f => f.Name).ToList();
            }
            else if (Sort.SelectedIndex == 1)
            {
                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = Core.Context.Products.OrderByDescending(r => r.Rating).ToList();
            }
            else if (Sort.SelectedIndex == 3)
            {
                ProductListBox.ItemsSource = null;
                ProductListBox.ItemsSource = Core.Context.Products.OrderByDescending(r => r.Manufacturers.Name).ToList();
            }
            else
            { }
        }

        private void See_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button; //кнопка, которая запускает метод ButtonBuy_Click
            Products selectPro = btn.DataContext as Products; //прировняли 
            if (selectPro == null)
            {
                MessageBox.Show("Товар отсутствует на складе");
            }
            else if (selectPro.IsFrozen == true)
            {
                MessageBox.Show("Товар заморожен!");
            }
            NavigationService.Navigate(new ProductInfoPage(selectPro));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
