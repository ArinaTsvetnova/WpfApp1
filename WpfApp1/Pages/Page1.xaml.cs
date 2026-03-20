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
        List<Film> film; //глобальный лист фильмов
        public Page1()
        {
            InitializeComponent();
            film = Core.Context.Film.ToList();
            FilmListBox.ItemsSource = film;
            List<Sortir> ssort = new List<Sortir>()
            {
                new Sortir
                {
                    Name = "По названию",
                },
                new Sortir
                {
                    Name = "По рейтингу",
                },
                new Sortir
                {
                    Name = "Фильтрация",
                }
            };

            Sort.ItemsSource = ssort;
            Sort.DisplayMemberPath = "Name";
            Sort.SelectedIndex = 2;
            Shop.ssort = FilmListBox.SelectedItem as Sortir;
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
            Button btn = sender as Button; //кнопка, которая запускает метод ButtonBuy_Click
            Film selectFilm = btn.DataContext as Film; //прировняли 
            if (selectFilm == null)
            {
                MessageBox.Show("Фильм закрыт для проката, попробуйте зайти позднее");
            }
            NavigationService.Navigate(new Page5( selectFilm));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Poisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Poisc.Text))
            {
                FilmListBox.ItemsSource = film;
            }
            else 
            {
                FilmListBox.ItemsSource = Core.Context.Film.Where(f => f.Name.Contains(Poisc.Text)).ToList(); //возвращает список фильмов, которые имеют символы как в поисковой строке и присваивает переменную листбоксу(которую мы привели к типу данных лист)
            }
        }
        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sort.SelectedIndex == 0)
            {
                FilmListBox.ItemsSource = null;
                FilmListBox.ItemsSource = Core.Context.Film.OrderBy(f => f.Name).ToList();
            }
            else if (Sort.SelectedIndex == 1)
            {
                FilmListBox.ItemsSource = null;
                FilmListBox.ItemsSource = Core.Context.Film.OrderByDescending(r => r.Rating).ToList();
            }
            else
            { }
        }
    }
}
