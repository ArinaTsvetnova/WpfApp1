using System;
using System.Collections;
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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Session sessions { get; set; }
        public Page6(Session s)
        {
            InitializeComponent();
            sessions = s;
            this.DataContext = this;
            if (sessions != null)
            {
                SitListBox.ItemsSource = sessions.SessionPlace.Where(g => g.Occupied == false);
            }
            else 
            {
                MessageBox.Show("Свободных мест на сеанс нет!");
            }
        }

        private void sit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                SessionPlace selectSess = btn.DataContext as SessionPlace;
                if (selectSess != null)
                {
                    NavigationService.Navigate(new Page7(selectSess, sessions));
                    if (NavigationService.CanGoForward)
                    {
                        NavigationService.GoForward();
                    }
                }
            }
        }
    }
}
