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
        private static List<basepart_> sborka = new List<basepart_>();
        public static void Add(basepart_ i)
        {
            if (sborka.Count == 0)
            {
                sborka.Add(i);
            }
            else if (sborka.Any(s => s.parttypeid == i.parttypeid))
            {
                MessageBox.Show("Деталь уже добавлена!");
            }
        }
        public static void Clean(basepart_ i) 
        {
            sborka.Clear();
        }

    }
}
