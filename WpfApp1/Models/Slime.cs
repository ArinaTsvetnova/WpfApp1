using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal class Slime : Enemy
    {
        public Slime() : base("Слизень", 35, 6, 5) { }

        public override int CalculateDamage(Player player)
        {
            return Attack;
        }
        public override void ApplySpecialEffect(Player player) { }

        public override void TakeDamage(int damage)
        {
            int reducedDamage = Math.Max(1, damage - 2);
            if (damage != reducedDamage)
            {
                Console.WriteLine("Слизень поглощает часть урона! Урон уменьшен на 2.");
            }
            base.TakeDamage(reducedDamage);
        }
    }
}
