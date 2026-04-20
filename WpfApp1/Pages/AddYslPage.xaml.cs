using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
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
    /// Логика взаимодействия для AddYslPage.xaml
    /// </summary>
    public partial class AddYslPage : Page
    {
        public AddYslPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MasterPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != null && Price.Text != null && Time.Text != null)
            {
                string Pricee = null;
                string Timee = null;
                Pricee = Price.Text;
                Timee = Time.Text;

                List<ServiceTypes> serviceTypes = Core.Context.ServiceTypes.ToList();
                ServiceTypes serviceType = new ServiceTypes
                {
                    Name = Name.Text,
                    BasePrice = Convert.ToInt32(Pricee),
                    DurationMinutes = (int)Convert.ToSingle(Timee)
                };
                Core.Context.ServiceTypes.Add(serviceType);
                MasterServices masterServices = new MasterServices
                {
                    IdUsers = AppSession.CurrentUser.IdUsers,
                    IdServiceTypes = serviceType.IdServiceTypes
                };
                Core.Context.MasterServices.Add(masterServices);
                Core.Context.SaveChanges();
                MessageBox.Show("Услуга добавлена!");
                Name.Clear();
                Price.Clear();
                Time.Clear();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
