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

        }

        private void ListServiceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListMasterType.ItemsSource = null;
            ListMasterType.IsEnabled = false;
            ComListBox.ItemsSource = null;

            if (ListServiceType.SelectedItem is ServiceTypes selectedService)
            {
                // Логика поиска мастеров:
                // 1. Берем таблицу связи MasterServices
                // 2. Фильтруем по ID выбранной услуги
                // 3. Джойним с таблицей Users, чтобы получить ФИО мастера
                
                TextName.Text = masterServices.Where(q => q.IdUsers == MasterUser.IdUsers);

                var mastersQuery = from ms in Core.Context.MasterServices
                                   join u in Core.Context.Users on ms.MasterId equals u.Id
                                   where ms.ServiceTypeId == selectedService.Id && u.Role == 1 // Только роль Мастер
                                   select u;

                var mastersList = mastersQuery.ToList();

                if (mastersList.Any())
                {
                    CmbMaster.ItemsSource = mastersList;
                    CmbMaster.DisplayMemberPath = "FullName";
                    CmbMaster.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Нет свободных мастеров для этой услуги.");
                }
            }
        }

        /// <summary>
        /// Срабатывает при выборе МАСТЕРА
        /// Задача: Показать в ListBox услуги, которые делает этот мастер
        /// </summary>
        private void ListMasterType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LbDetails.ItemsSource = null;

            if (CmbMaster.SelectedItem is Users selectedMaster)
            {
                // Логика поиска услуг мастера:
                // 1. Берем таблицу связи MasterServices
                // 2. Фильтруем по ID выбранного мастера
                // 3. Джойним с ServiceTypes, чтобы получить названия услуг

                var servicesQuery = from ms in Core.Context.MasterServices
                                    join st in Core.Context.ServiceTypes on ms.ServiceTypeId equals st.Id
                                    where ms.MasterId == selectedMaster.Id
                                    select st;

                var masterServicesList = servicesQuery.ToList();

                // Выводим результат в ListBox
                LbDetails.ItemsSource = masterServicesList;

                // Опционально: можно менять заголовок
                TxtListHeader.Text = $"Услуги мастера {selectedMaster.FullName}:";
            }
        }
        private void Shop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Account_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
