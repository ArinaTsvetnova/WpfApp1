using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Models
{
    public static class Lists
    {
        public static List<basepart_> sborka { get; } = new List<basepart_>();
        public static List<string> erersb { get; } = new List<string>();  
        public static void Add(basepart_ i)
        {
            if (sborka.Count == 0)
            {
                sborka.Add(i);
                MessageBox.Show("Деталь добавлена!");
            }
            else if (sborka.Any(s => s.parttypeid == i.parttypeid))
            {
                MessageBox.Show("Деталь уже добавлена!");
            }
            else if (sborka.Any(s => s.motherboard_.socketid == i.cpu_.socketid))
            {
                sborka.Add(i);
                MessageBox.Show("Деталь добавлена!");
            }
            else if (sborka.Any(s => s.motherboard_.socketid != i.cpu_.socketid))
            {
                MessageBox.Show("Деталь не подходит!");
            }
            //else if (sborka.Any(s => s.cpu_.socketid == i.motherboard_.socketid))
            //{
            //    erersb.Add("Деталь добавлена!");
            //}

            else
            {
                sborka.Add(i);
                MessageBox.Show("Деталь добавлена!");
            }


        }

        public static void Clean() 
        {
            sborka.Clear();
        }
        public static void Remove(basepart_ i)
        {
            if (sborka.Remove(i))
            {
                MessageBox.Show("Удалено");
            }
            else
            {
                MessageBox.Show("Не получилось удалить");
            }
        }
    }
}
