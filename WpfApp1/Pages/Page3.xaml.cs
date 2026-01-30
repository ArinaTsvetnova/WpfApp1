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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            List<Product> product = Core.Context.Product.ToList();
            List<Order> order = Core.Context.Order.ToList();
            List<OrderProduct> ordpro = Core.Context.OrderProduct.ToList();
            ProductListBox3.ItemsSource = Class1.basket;
            int c = 0;
            foreach (Product pro in Class1.basket)
                c += pro.price;
            FullPrice.Text = c.ToString();
        }
        private void ButtonSafe_Click(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order // создание нового пользователя
            {
                username = ,
                mail = ,
                address = 
            };
            Core.Context.Order.Add(newOrder);
            Core.Context.SaveChanges();
        }
    }
}
