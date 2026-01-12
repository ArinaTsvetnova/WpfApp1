using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal static class Car
    {
        public static AutoModel Aum { get; set; }
        public static AutoType Aut { get; set; }
        public static AutoColor Auc { get; set; }
        public static AutoFunktion Auf { get; set; }
        public static int c;
        public static int Summa()
        {
            return c = Aum.Price + Aut.Price + Auc.Price + Auf.Price;
        }
    }
}
