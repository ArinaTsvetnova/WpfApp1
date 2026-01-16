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
using WpfApp1.Models;
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
        //{
        //    if (MainFrame.CanGoBack)
        //    {
        //        MainFrame.GoBack();
        //    }
        //}
        public static int schrt = 1;
        public MainWindow()
        {
            InitializeComponent();
            //MainFrame.Navigate(new Page5());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            Power.Value = schrt;
        }
    }
}
