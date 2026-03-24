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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        List<Session> sessions;
        public Film film { get; set; }
        public GenerFilm genref { get; set; }
        public Session session { get; set; }
        public Page5( Film f)
        {
            InitializeComponent();
            film = f;
            this.DataContext = this;
            foreach(var a in film.GenerFilm)
                ganre.Text = a.Genre.Genre1;
            sessions = Core1.Context.Session.ToList();
            FilmListBox.ItemsSource = sessions;
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Session selectSession = btn.DataContext as Session;
            if (selectSession == null)
            {
                MessageBox.Show("Фильм закрыт для проката, попробуйте зайти позднее");
            }
            NavigationService.Navigate(new Page6( selectSession));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
