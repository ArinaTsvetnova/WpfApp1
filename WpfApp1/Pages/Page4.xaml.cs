using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Button4GoForward_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void Button4GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.schrt--;
            //if (HasUnsavedChanges())
            //{
            //    var result = MessageBox.Show("Есть несохранённые изменения. Покинуть страницу?", "Подтверждение",
            //      MessageBoxButton.YesNo);
            //    if (result == MessageBoxResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }
        private void OnNavigating(object sender, NavigatingCancelEventArgs e)
        {
            //if (HasUnsavedChanges())
            //{
            //    var result = MessageBox.Show("Есть несохранённые изменения. Покинуть страницу?", "Подтверждение",
            //      MessageBoxButton.YesNo);
            //    if (result == MessageBoxResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }
    }
}
