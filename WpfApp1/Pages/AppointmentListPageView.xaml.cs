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
            //TxtServiceName.Text = _service.Name;
            //TxtMasterName.Text = _master.FullName;
            //TxtPrice.Text = $"{_service.BasePrice} руб."; // Или цена из MasterServices

            // Можно сразу подставить клиента, если он есть в сессии
            if (AppSession.CurrentUser != null)
            {
                // Если нужно отображать данные клиента
            }
        }
    }
}
