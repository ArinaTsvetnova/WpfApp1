using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal static class Procent
    {
        static int r = 19; //годовая ставка
        static double i = 0.01583; //месечная процентная ставка
        public static int k;
        public static int n;
        public static int p;
        public static int s;
        public static double a;
        public static double schet() 
        {
            s = Car.c - p; //сумма кредита
            double v = Math.Pow(1 + i, n);
            double vv = Math.Pow(1 + i, n - 1);
            a = s * (i * v) / vv; //ежемесячный платеж
            return p = Car.c / 100 * k; //первоначальный взнос
        }
    }
}
