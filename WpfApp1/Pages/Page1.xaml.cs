using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();
            List<Film> film = Core.Context.Film.ToList();
            FilmListBox.ItemsSource = film;
            List<Sortir> ssort = new List<Sortir>()
            {
                new Sortir
                {
                    Name = "-",
                },
                new Sortir
                {
                    Name = "По жанрам",
                },
                new Sortir
                {
                    Name = "По рейтингу",
                }
            };

            Sort.ItemsSource = ssort;
            Sort.DisplayMemberPath = "Name";
            Sort.SelectedIndex = 0;
            Shop.ssort = FilmListBox.SelectedItem as Sortir;
            Poisc.Text = string.Empty;
            //if ()
            //{ 

            //}
        }
        private void ButtonEntry_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void ButtonBuy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
