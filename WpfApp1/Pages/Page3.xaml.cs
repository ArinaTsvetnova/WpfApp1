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
        List<assembly_> sborkapk;
        public Page3()
        {
            InitializeComponent();
            sborkapk = Core.Context.assembly_.ToList();
            SborkaBx.ItemsSource = sborkapk;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void SborkaBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var g = SborkaBx.SelectedItem as assembly_;
            if (g != null)
            {
                Opis.Visibility = Visibility;
                Opis.ItemsSource = g.partassembly_;
            }
            else
            {
                MessageBox.Show("Ничего не выбранно");
            }
        }
    }
}
