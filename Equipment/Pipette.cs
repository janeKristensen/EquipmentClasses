using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    internal class Pipette(ushort volumen, InitializationParams initParams) : AnalyticalEquipment(initParams), ICalibratable
    {
        private DateTime _calibrationDate;

        public ushort Volumen { get; init; } = volumen;
        public DateTime CalibrationDate 
        { 
            get 
            {
                if (IsCalibrated)
                    return _calibrationDate;
                else throw new Exception("Pipette is not calibrated");
            }
            private set { _calibrationDate = value; }
        }
        private bool IsCalibrated { get; set; } = false;

        public void Calibrate() { SetCalibrationDate(); IsCalibrated = true; }
        public void SetCalibrationDate() { _calibrationDate = System.DateTime.Now; }
        public DateTime GetCalibrationDate() { return _calibrationDate; }
        public override void CorrectiveMaintenance() { }
        public override void PreventiveMaintenance() { } 
    }
}
