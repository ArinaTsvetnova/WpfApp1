using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Button3GoForward_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt++;
            NavigationService.Navigate(new Page4());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Button3GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt--;
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
        private void ButtonMath_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Procenttt.Text, out int k);
            Procent.k = k;
            int.TryParse(Month.Text, out int n);
            Procent.n = n;
            if (n < 12 || n > 96)
            {
                MessageBox.Show("Неправильный ввод! Введите число в диапазоне от 12 до 96!");
                return;
            }
            OutputVsnos.Text = Procent.schet().ToString();
            OutputCredit.Text = Procent.s.ToString();
            OutputMoney.Text = Procent.a.ToString();
        }
    }
}
