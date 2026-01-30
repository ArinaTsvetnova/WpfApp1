using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
                username = Name.Text,
                mail = Mail.Text,
                address = Address.Text
            };
            Core.Context.Order.Add(newOrder);
            Core.Context.SaveChanges();
            foreach (Product pr in Class1.basket)
            {
                OrderProduct newOrdpro = new OrderProduct
                {
                    ProductID = pr.ID,
                    OrderID = newOrder.ID
                };
                Core.Context.OrderProduct.Add(newOrdpro);
                Core.Context.SaveChanges();
            }
            
        }
    }
}
