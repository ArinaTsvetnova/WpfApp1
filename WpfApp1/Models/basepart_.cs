using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class basepart_
    {
        public string opis {
            get
            {
                switch (parttypeid)
                {
                    case 1:
                        return $"Тип сокета {cpu_.socket_.name}, \nчисло ядер {cpu_.numberofcores}, \nмаксимальная основная частота {cpu_.maxcorefrequency}, \nкэш l3 {cpu_.cachel3}, \nигпу {cpu_.igpu_.name}, \nтепловая мощность {cpu_.thermalpower}, \nимеет встроенное графическое ядро  {cpu_.hasigpu}";
                    case 2:
                        return $"";
                    default:
                        return "";
                }
            } 
        }
    }
}
