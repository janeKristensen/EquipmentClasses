using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace Equipment
{
    public struct InitializationParams(ushort id, string name, string serialNumber, string vendor)
    {
        public ushort Id { get; init; } = id;
        public string Name { get; set; } = name;
        public string SerialNumber { get; init; } = serialNumber;
        public string Vendor { get; init; } = vendor;
    }

    internal abstract class AnalyticalEquipment(InitializationParams initParams)
    {
        protected ushort Id { get; init; } = initParams.Id;
        protected string Name { get; private set; } = initParams.Name;
        protected string SerialNumber { get; init; } = initParams.SerialNumber;
        protected string Vendor { get; init; } = initParams.Vendor;

        public abstract void PreventiveMaintenance();
        public abstract void CorrectiveMaintenance();

        public override string ToString()
        {
            return $"System ID: {Id} \nSystem name: {Name} \nSerial number: {SerialNumber} \nSystem vendor: {Vendor}";
        }

    }
}