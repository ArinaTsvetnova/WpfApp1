using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Xml.Linq;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AppointmentListPageView.xaml
    /// </summary>
    public partial class AppointmentListPageView : Page
    {
        private ServiceTypes _service;
        private Users _master;
        List<Appointments> appoin;

        public AppointmentListPageView(ServiceTypes service, Users master)
        {
            InitializeComponent();
            _service = service;
            _master = master;

            appoin = Core.Context.Appointments.ToList();

            List<string> PayMet = new List<string>()
            {"Карта", "Наличые"};
            PayComboBox.ItemsSource = PayMet;
            PayComboBox.SelectedIndex = 0;

            Service.Text = _service.Name;
            Master.Text = _master.FullName;
            Price.Text = $"{_service.BasePrice} руб.";

            Calendar.BlackoutDates.Add(new CalendarDateRange(DateTime.MinValue, DateTime.Today.AddDays(-1)));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            appoin = Core.Context.Appointments.ToList();
            Appointments newappoin = new Appointments // создание нового пользователя
            {
                IdUsersC = AppSession.CurrentUser.IdUsers,
                IdUsersM = _master.IdUsers,
                IdServiceTypes = _service.IdServiceTypes,
                AppointmentDateTime = Calendar.SelectedDate ?? DateTime.Now,
                Status = false,
                PaymentMethod = PayComboBox.SelectedValue.ToString(),
                Comment = com.Text,
                FinalPrice = _service.BasePrice,
            };
            Core.Context.Appointments.Add(newappoin);
            Core.Context.SaveChanges();

            MessageBox.Show("Вы успешно записаны!");

            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Escape_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPageView());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
