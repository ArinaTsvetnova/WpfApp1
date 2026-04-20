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
    /// Логика взаимодействия для AccountPageView.xaml
    /// </summary>
    public partial class AccountPageView : Page
    {
        List<Appointments> appoin;
        List<Orders> order;

        public AccountPageView()
        {
            InitializeComponent();
            Name.Text = AppSession.CurrentUser.FullName;
            Phone.Text = AppSession.CurrentUser.Phone;
            appoin = Core.Context.Appointments.Where(a => a.IdUsersC == AppSession.CurrentUser.IdUsers).ToList();
            HistoryGo.ItemsSource = appoin;
            order = Core.Context.Orders.ToList();
            HistoryBuy.ItemsSource = order;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
