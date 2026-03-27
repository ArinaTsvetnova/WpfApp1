using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;

namespace WpfApp1.Models
{
    public static class Lists
    {
        public static ICollection<basepart_> sborka { get; } = new List<basepart_>();
        public static ICollection<string> erersb { get; } = new List<string>();
        public static decimal pr = 0;
        public static void Add(basepart_ i)
        {
            if (sborka.Count == 0)
            {
                sborka.Add(i);
                pr += i.price;
                MessageBox.Show("Деталь добавлена!");
            }
            else if (sborka.Any(s => s.parttypeid == i.parttypeid))
            {
                MessageBox.Show("Деталь уже добавлена!");
            }
            //else if (sborka.Any(s => s.cpu_.socketid == i.motherboard_.socketid))
            //{
            //    erersb.Add("Деталь добавлена!");
            //}
            else
            {
                sborka.Add(i);
                pr += i.price;
                MessageBox.Show("Деталь добавлена!");
            }
            Error();
        }

        public static void Error()
        {
            erersb.Clear();
            basepart_ CPU = sborka.FirstOrDefault(c => c.parttypeid == 1);
            basepart_ GPU = sborka.FirstOrDefault(c => c.parttypeid == 2);
            basepart_ RAM = sborka.FirstOrDefault(c => c.parttypeid == 3);
            basepart_ Motherboard = sborka.FirstOrDefault(c => c.parttypeid == 4);
            basepart_ Case = sborka.FirstOrDefault(c => c.parttypeid == 5);
            basepart_ PowerSupply = sborka.FirstOrDefault(c => c.parttypeid == 6);
            basepart_ ProcessorCooler = sborka.FirstOrDefault(c => c.parttypeid == 7);
            basepart_ StorageDevice = sborka.FirstOrDefault(c => c.parttypeid == 8);

            if (CPU != null && Motherboard != null && ProcessorCooler != null)
            {
                if (CPU.cpu_.socketid != Motherboard.motherboard_.socketid && ProcessorCooler.processorcooler_.socketprocessorcooler_.Any(s => s.socketid == CPU.cpu_.socketid))
                {
                    erersb.Add("Сокет процессора материнской платы и куллера охлаждения не соответствует!");
                }
            }
            if (Motherboard != null && Case != null)
            {
                if (Case.case_.boardformfactorcase_.Any(s => s.formfactorid == Motherboard.motherboard_.formfactorid))
                {
                    erersb.Add("Форм-фактор материнской платы и корпуса не совместимы!");
                }
            }
            if (Motherboard != null && RAM != null)
            {
                if (Motherboard.motherboard_.memorytypeid != RAM.ram_.memorytypeid)
                {
                    erersb.Add("Типы памяти материнской платы и оперативной памяти несовместимы!");
                }
            }
            if (PowerSupply != null && GPU != null)
            {
                if (PowerSupply.powersupply_.power != GPU.gpu_.recommendpower)
                {
                    erersb.Add("Несовместимы мощность блока питания с потреблением питания видеокартой!");
                }
            }
        }
            
        public static void Clean()
        {
            pr = 0;
            sborka.Clear();
            
            Error();
        }
        public static void Remove(basepart_ i)
        {
            pr -= i.price;
            if (sborka.Remove(i))
            {
                
                MessageBox.Show("Удалено");
            }
            else
            {
                MessageBox.Show("Не получилось удалить");
            }
            Error();
        }
    }
}
