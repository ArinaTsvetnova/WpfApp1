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
    /// Логика взаимодействия для AdminPageView.xaml
    /// </summary>
    public partial class AdminPageView : Page
    {
        List<Users> users;
        public AdminPageView()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            users = Core.Context.Users.ToList();
            UserAll.ItemsSource = null;
            UserAll.ItemsSource = users;

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Users remouveUser = b.DataContext as Users;
            Core.Context.Users.Remove(remouveUser);
            Core.Context.SaveChanges();
            users.Remove(remouveUser);
            Load();
        }
    }
}
