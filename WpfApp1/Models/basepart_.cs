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
                        return $"Графический интерфейс {gpu_.gpuinterface_.name}, \nчастота микросхемы {gpu_.chipfrequency}, \nвидеопамять {gpu_.videomemory}, \nшина памяти {gpu_.memorybus}, \nрекомендуемая мощность {gpu_.recommendpower}";
                    case 3:
                        return $"Тип памяти {ram_.memorytype_.name}, \nвместимость {ram_.capacity}, \nколичество {ram_.count}, \nГгц {ram_.ghz}, \nтайминг {ram_.timings}";
                    case 4:
                        return $"Сокет {motherboard_.socket_.name}, \nформ-фактор {motherboard_.formfactor_.name}, \nслот память {motherboard_.memoryslots}, \nтип памяти {motherboard_.memorytype_.name}, \nслоты PCI {motherboard_.pcislots}, \nSATA-порты {motherboard_.sataports}, \nUSB-порты {motherboard_.usbports}";
                    case 5:
                        return $"Размер корпуса {case_.casesize_.name}, \nслоты расширения {case_.expansionslots}, \nвентилятор {case_.fans}";
                    case 6:
                        return $"Сила {powersupply_.power}, \nразмер вентилятора {powersupply_.fandimension_.name}, \nсертификация {powersupply_.certificate_.name}";
                    case 7:
                        return $"Размер вентиллятра {processorcooler_.fandimension_.name}, \nтепловые трубы {processorcooler_.heatpipes}, \nминимальная скорость {processorcooler_.minspeed}, \nмаксимальная скорость {processorcooler_.maxspeed}, \nуровень шума {processorcooler_.noiselevel}";
                    case 8:
                        return $"Вместимость {storagedevice_.capacity}, \nинтерфейс запоминающего устройства {storagedevice_.storagedeviceinterface_.name}, \nтип запоминающего устройства {storagedevice_.storagedevicetype_.name}";
                    default:
                        return "";
                }
            } 
        }
    }
}
