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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для NameWindows.xaml
    /// </summary>
    public partial class NameWindows : Window
    {
        public NameWindows()
        {
            InitializeComponent();
        }

        public string Name
        {
            get
            {
                return NameSb.Text;
            }
        }
        public string Author
        {
            get
            {
                return AuthorSb.Text;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameSb.Text) && !string.IsNullOrWhiteSpace(AuthorSb.Text))
            {
                DialogResult = true;
            }
        }
    }
}
