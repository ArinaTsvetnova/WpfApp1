using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.Models
{
    internal class HealthPotion : Item
    {
        public HealthPotion() : base("Лечебное зелье") { }
        public override string ToString()
        {
            return $"{Name} (Восстанавливает всё здоровье)";
        }
    }
}
