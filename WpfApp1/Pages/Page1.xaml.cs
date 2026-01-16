using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        

        public Page1()
        {
            InitializeComponent();
            List<AutoColor> color = new List<AutoColor>()
                {
                    new AutoColor
                    {
                        Name = "Gold",
                        Price = 70000
                    },
                    new AutoColor
                    {
                        Name = "Purple",
                        Price = 13000
                    },
                    new AutoColor
                    {
                        Name = "Gray",
                        Price = 15000
                    },
                    new AutoColor
                    {
                        Name = "Black",
                        Price = 18000
                    },
                    new AutoColor
                    {
                        Name = "Red",
                        Price = 12000
                    }
                };

            AutoColorComboBox.ItemsSource = color;
            AutoColorComboBox.DisplayMemberPath = "Name";
            AutoColorComboBox.SelectedIndex = 0;

            List<AutoFunktion> type = new List<AutoFunktion>()
                {
                    new AutoFunktion
                    {
                        Name = "Nothing",
                        Price = 0
                    },
                    new AutoFunktion
                    {
                        Name = "Speed+",
                        Price = 1000000
                    },
                    new AutoFunktion
                    {
                        Name = "Custom",
                        Price = 1500000
                    },
                    new AutoFunktion
                    {
                        Name = "Probeg",
                        Price = 650000
                    }
                };
            AutoFunktionComboBox.ItemsSource = type;
            AutoFunktionComboBox.DisplayMemberPath = "Name";
            AutoFunktionComboBox.SelectedIndex = 0;
        }
        private void Button1GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
        private void Button1GoForward_Click(object sender, RoutedEventArgs e)
        {
            Car.Auc = AutoColorComboBox.SelectedItem as AutoColor;
            Car.Auf = AutoFunktionComboBox.SelectedItem as AutoFunktion;
            Car.c = Car.Auc.Price + Car.Auf.Price;
            NavigationService.Navigate(new Page2());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
