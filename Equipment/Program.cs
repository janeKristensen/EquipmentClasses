using System.Linq;

namespace Equipment
{
    internal class Program
    {
        static void Main()
        {
            PhMeter pH = new ("electrode", 220, new InitializationParams(1, "equipment name", "SE100001", "vendor name"));
            Pipette pip = new (200, new InitializationParams(2, "pipette", "KI23546", "Element"));

            List<AnalyticalEquipment> equipment = new() { pip, pH };
            equipment.ForEach(e => Console.WriteLine($"{e.ToString()} \n"));

            List<ICalibratable> calibratedEquipment = new () { pip, pH}; 
            calibratedEquipment.ForEach(e => e.Calibrate());
            calibratedEquipment.ForEach(e => Console.WriteLine($"{e.ToString()} \nCalibration date: {e.GetCalibrationDate().ToString()}\n"));
        }
    }
}
