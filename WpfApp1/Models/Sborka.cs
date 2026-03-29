using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfApp1.Models;

namespace WpfApp1
{
    public static class Sborka
    {
        static List<assembly_> assembly = Core2.Context.assembly_.ToList();
        public static void Add(assembly_ s)
        {
            if (Lists.sborka.Count != 0)
            {
                NameWindows nameWindows = new NameWindows();

                if (nameWindows.ShowDialog() == true)
                {
                    if (assembly.Where(s => s.name != Name))
                    {
                        MessageBox.Show("Сборка сохранена");
                        Lists.Clean();
                    }


                }
                else
                {
                    MessageBox.Show("Сборка не сохранена");
                }
            }
            else
            {
                MessageBox.Show("Добавьте минимум одну деталь!");
            }
        }
    }
}
