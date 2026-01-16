using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public Page2()
        {
            InitializeComponent();
            Model.Text = Car.Aum.Name;
            Dvigatel.Text = Car.Aut.Name;
            Color.Text = Car.Auc.Name;
            Option.Text = Car.Auf.Name;
            Summa.Text = Car.c.ToString();
        }
        private void Button2GoForward_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt++;
            NavigationService.Navigate(new Page3());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Button2GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt--;
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Car.c = Car.Auc.Price + Car.Auf.Price + Car.Aum.Price + Car.Aut.Price;
            Model.Text = Car.Aum.Name;
            Dvigatel.Text = Car.Aut.Name;
            Color.Text = Car.Auc.Name;
            Option.Text = Car.Auf.Name;
            Summa.Text = Car.c.ToString();
        }
    }
}
