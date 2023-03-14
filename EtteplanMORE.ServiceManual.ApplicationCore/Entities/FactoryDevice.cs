using System;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDevice
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public int DeviceYear { get; set; }
        public string DeviceType { get; set; }
    }
}