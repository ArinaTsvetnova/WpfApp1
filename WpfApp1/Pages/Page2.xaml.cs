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
        }
        private void Button2GoForward_Click(object sender, RoutedEventArgs e)
        {
            FramePage2.Navigate(new Page3());
            if (FramePage2.CanGoForward)
            {
                FramePage2.GoForward();
            }
        }
        private void Button2GoBack_Click(object sender, RoutedEventArgs e)
        {
            //FramePage2.Navigate(new MainWindow());
            if (FramePage2.CanGoBack)
            {
                FramePage2.GoBack();
            }
        }
    }
}
