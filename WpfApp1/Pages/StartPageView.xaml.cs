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
    /// Логика взаимодействия для StartPageView.xaml
    /// </summary>
    public partial class StartPageView : Page
    {
        public static List<ServiceTypes> listsertype = Core.Context.ServiceTypes.ToList();
        public static List<Users> MasterUser = Core.Context.Users.ToList();
        public static List<MasterServices> masterServices = Core.Context.MasterServices.ToList();
        private ServiceTypes _selectedService;
        private Users _selectedMaster;
        public StartPageView()
        {
            InitializeComponent();
            ListServiceType.ItemsSource = listsertype;
            ListServiceType.DisplayMemberPath = "Name";
            ListServiceType.SelectedValuePath = "Id";
            ListServiceType.SelectedIndex = -1;

            ListMasterType.DisplayMemberPath = "FullName";
            ListMasterType.SelectedValuePath = "Id";
            ListMasterType.ItemsSource = MasterUser.Where(d => d.Role == 1);
            ListServiceType.SelectedIndex = -1;

            if (AppSession.CurrentUser != null)
            {
                if (AppSession.CurrentUser.Role == 0)
                {
                    Account.Visibility = Visibility.Visible;
                }
            }
        }

        private void ListServiceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedService = ListServiceType.SelectedItem as ServiceTypes;
            _selectedMaster = null;
            if (ListServiceType.SelectedItem is ServiceTypes selectedService)
            {
                var mastersQuery = from ms in Core.Context.MasterServices
                                   join u in Core.Context.Users on ms.IdUsers equals u.IdUsers
                                   where ms.IdServiceTypes == selectedService.IdServiceTypes && u.Role == 1
                                   select u;

                var mastersList = mastersQuery.ToList();

                if (mastersList.Any())
                {
                    ListMasterType.ItemsSource = mastersList;
                    ListMasterType.DisplayMemberPath = "FullName";
                    ListMasterType.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Нет свободных мастеров для этой услуги.");
                }
            }
        }
        private void ListMasterType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedMaster = ListMasterType.SelectedItem as Users;
            if (ListMasterType.SelectedItem is Users selectedMaster)
            {
                var servicesQuery = from ms in Core.Context.MasterServices
                                    join st in Core.Context.ServiceTypes on ms.IdServiceTypes equals st.IdServiceTypes
                                    where ms.IdUsers == selectedMaster.IdUsers
                                    select st;

                var masterServicesList = servicesQuery.ToList();
            }
        }
        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StorePage());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {
            if (AppSession.CurrentUser == null)
            {
                MessageBox.Show("Для записи необходимо войти в аккаунт.");
                NavigationService.Navigate(new LoginPage());
            }
            else
            {
                NavigationService.Navigate(new AccountPageView());
            }
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
            if (NavigationService.CanGoForward)
            { 
                NavigationService.GoForward();
            }
        }
        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {
            if (AppSession.CurrentUser == null)
            {
                MessageBox.Show("Для записи необходимо войти в аккаунт.");
                NavigationService.Navigate(new LoginPage());
            }
            else
            {
                NavigationService.Navigate(new AppointmentListPageView(_selectedService, _selectedMaster));
                var bookingPage = new AppointmentListPageView(_selectedService, _selectedMaster);
            }
        }
    }
}
