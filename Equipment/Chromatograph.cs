using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    internal class Chromatograph(string detectorType, string pumpType, ushort voltage, InitializationParams initParams) : ElectronicEquipment(voltage, initParams)
    {
        private string DetectorType { get; init; } = detectorType;
        private string PumpType { get; init; } = pumpType;

        public void StartPump() { }
        public void PurgeLines() { }
        public void RunAnalysis() { }
        public override void CorrectiveMaintenance() { }
        public override void PreventiveMaintenance() { }
    }
}
