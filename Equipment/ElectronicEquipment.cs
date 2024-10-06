using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    internal abstract class ElectronicEquipment(ushort voltage, InitializationParams initParams) : AnalyticalEquipment(initParams)
    {
        protected ushort Voltage { get; init; } = voltage;

        public void TurnOn() { }
        public void TurnOff() { }  
    }
}
