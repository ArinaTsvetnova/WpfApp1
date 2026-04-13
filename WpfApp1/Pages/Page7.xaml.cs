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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public SessionPlace sessio { get; set; }
        public Session sesions { get; set; }

        public Page7(SessionPlace ss, Session se)
        {
            InitializeComponent();
            sessio = ss;
            sesions = se;
            this.DataContext = this;
        }

        private void BYE_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
