using System;
using System.Collections.Generic;
using System.Configuration;
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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void ButtonGoForward_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
        }
        public class AutoModel
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        public class AutoType
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        public MainWindow()
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
        
    }
}
