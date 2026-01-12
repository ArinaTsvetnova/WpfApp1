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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            //int a,b;
            int.TryParse(Procent.Text, out int i);
            int.TryParse(Month.Text, out int j);
            if (j < 12 & j > 96)
            {
                MessageBox.Show("Неправильный ввод! Введите число в диапазоне от 12 до 96!");
                return;
            }
            
        }
        private void Button3GoForward_Click(object sender, RoutedEventArgs e)
        {
            FramePage3.Navigate(new Page4());
            if (FramePage3.CanGoForward)
            {
                FramePage3.GoForward();
            }
        }
        private void Button3GoBack_Click(object sender, RoutedEventArgs e)
        {
            //FramePage2.Navigate(new MainWindow());
            if (FramePage3.CanGoBack)
            {
                FramePage3.GoBack();
            }
        }
    }
}
