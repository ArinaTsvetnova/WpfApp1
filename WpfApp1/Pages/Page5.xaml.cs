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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
            List<AutoModel> bibiki = new List<AutoModel>()
                {
                    new AutoModel
                    {
                        Name = "Ferrari",
                        Price = 12000000
                    },
                    new AutoModel
                    {
                        Name = "McLaren",
                        Price = 13000000
                    },
                    new AutoModel
                    {
                        Name = "Aston Martin",
                        Price = 15000000
                    }
                };
            AutoModelComboBox.ItemsSource = bibiki;
            AutoModelComboBox.DisplayMemberPath = "Name";
            AutoModelComboBox.SelectedIndex = 2;

            List<AutoType> type = new List<AutoType>()
                {
                    new AutoType
                    {
                        Name = "Fast",
                        Price = 750000
                    },
                    new AutoType
                    {
                        Name = "Super Fast",
                        Price = 1000000
                    },
                    new AutoType
                    {
                        Name = "Ultra Super Fast",
                        Price = 1500000
                    }
                };
            AutoTypeComboBox.ItemsSource = type;
            AutoTypeComboBox.DisplayMemberPath = "Name";
            AutoTypeComboBox.SelectedIndex = 0;
        }
        private void ButtonGoForward_Click(object sender, RoutedEventArgs e)
        {

            Car.Aum = AutoModelComboBox.SelectedItem as AutoModel;
            Car.Aut = AutoTypeComboBox.SelectedItem as AutoType;
            Car.c = Car.Aum.Price + Car.Aut.Price;
            MainWindow.schrt++;
            NavigationService.Navigate(new Page1());
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
