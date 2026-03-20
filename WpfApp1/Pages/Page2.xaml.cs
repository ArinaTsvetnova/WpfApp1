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
        List<basepart_> detali;
        public Page2( int t)
        {
            InitializeComponent();
            detali = Core1.Context.basepart_.Where(b => b.parttypeid == t).ToList();
            DetaelLstBx.ItemsSource = detali;

            List<manufacturer_> manuf = new List<manufacturer_>()
            {
                new manufacturer_
                {
                    name = "Фильтрация"
                }
            };

            // = Core1.Context.manufacturer_.ToList(); //
            foreach (var d in detali)
            {
                if (manuf.Any(m => m.id == d.manufacturerid))
                {
                    continue;
                }
                manuf.Add(d.manufacturer_);
            }
            
            Sort.ItemsSource = null;
            Sort.ItemsSource = manuf.Select(s => s.name);
        }

        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Lists.Add(btn.DataContext as basepart_);
        }

        private void Poisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Poisc.Text))
            {
                DetaelLstBx.ItemsSource = detali;
            }
            else
            {
                DetaelLstBx.ItemsSource = detali.Where(d => d.name.ToLower().Contains(Poisc.Text.ToLower())).ToList();
            }
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sort.SelectedIndex == 0)
            {
                DetaelLstBx.ItemsSource = detali;
            }
            else
            {
                //Sort.SelectedValue  использовать в LINQ
                DetaelLstBx.ItemsSource = detali.Where(d => d.manufacturer_.name == Sort.SelectedValue);
            }
                
        }
    }
}
