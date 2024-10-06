using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    internal class PhMeter(string electrodeType, ushort voltage, InitializationParams initParams) : ElectronicEquipment(voltage, initParams), ICalibratable
    {
        private DateTime _calibrationDate;

        public DateTime CalibrationDate
        {
            get
            {
                if (IsCalibrated)
                    return _calibrationDate;
                else throw new Exception("pH-meter is not calibrated");
            }
            private set { _calibrationDate = value; }
        }
        public string ElectrodeType { get; private set; } = electrodeType;
        private bool IsCalibrated { get; set; } = false;
        private byte Temperature { get; set; }

        public void Measure() { Temperature = 20; }
        public void Calibrate() { SetCalibrationDate(); IsCalibrated = true; }
        public void SetCalibrationDate() { _calibrationDate = System.DateTime.Now; }
        public DateTime GetCalibrationDate() { return CalibrationDate; }
        public void ChangeElectrode(string electrode) { ElectrodeType = electrode; }
        public override void CorrectiveMaintenance() { }
        public override void PreventiveMaintenance() { }
    }
}
