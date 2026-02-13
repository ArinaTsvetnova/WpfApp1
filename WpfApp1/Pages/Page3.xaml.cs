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
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            UName.Text = $"Здравствуй, {UserInfo.kupt.Name}!";
            List<Film> film = Core.Context.Film.ToList();
            List<Ticket> ticket = Core.Context.Ticket.Where(t => t.UserID == UserInfo.kupt.ID).ToList();
            UserInfoListBox.ItemsSource = ticket;

        }
    }
}
