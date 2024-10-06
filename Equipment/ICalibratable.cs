using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment
{
    internal interface ICalibratable
    {
        public void SetCalibrationDate();
        public DateTime GetCalibrationDate ();

        public void Calibrate();
    }
}
