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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            //int r = 19; //годовая ставка
            //double i = 0.01583; //месечная процентная ставка
            int.TryParse(Procent.Text, out int k);
            //int.TryParse(Month.Text, out int n);
            //if (n < 12 & n > 96)
            //{
            //    MessageBox.Show("Неправильный ввод! Введите число в диапазоне от 12 до 96!");
            //    return;
            //}
            //int p = c/100 * k; //первоначальный взнос
            //OutputVsnos.Text = p.ToString();
            //int s = c - p; //сумма кредита
            //OutputCredit.Text = s.ToString();
            //double v = pow(1 + i, n);
            //double vv = pow(1 + i, n - 1);
            //double a = s * (i * v) / vv; //ежемесячный платеж
            //OutputMoney.Text = a.ToString();
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
