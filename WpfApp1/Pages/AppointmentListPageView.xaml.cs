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
        public AppointmentListPageView(ServiceTypes service, Users master)
        {
            InitializeComponent();
            _service = service;
            _master = master;

            // Заполняем интерфейс данными
            //ServiceName.Text = _service.Name;
            //MasterName.Text = _master.FullName;
            //Price.Text = $"{_service.BasePrice} руб."; // Или цена из MasterServices

            // Можно сразу подставить клиента, если он есть в сессии
            if (AppSession.CurrentUser != null)
            {
                // Если нужно отображать данные клиента
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //var newAppointment = new Appointments
            //{
            //    ClientId = AppSession.CurrentUser.Id,
            //    MasterId = _master.Id,
            //    ServiceTypeId = _service.Id,
            //    AppointmentDateTime = DpDate.SelectedDate.Value + TpTime.SelectedTime.Value,
            //    Status = "Scheduled",
            //    Comment = TxtComment.Text
            //};

            //Core.Context.Appointments.Add(newAppointment);
            //Core.Context.SaveChanges();

            //MessageBox.Show("Вы успешно записаны!");
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
