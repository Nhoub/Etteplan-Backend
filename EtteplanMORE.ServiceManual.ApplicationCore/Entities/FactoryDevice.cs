using System.Collections.Generic;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDevice
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public int DeviceYear { get; set; }
        public string DeviceType { get; set; }
        public ICollection<MaintenanceTasks> Maintenances { get; set; }
    }
}