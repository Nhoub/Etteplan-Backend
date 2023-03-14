using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class MaintenanceTasks
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public DateTime RegisteredTimeTask { get; set; }
        public string DiscriptionTask { get; set; }
        public SeverityTask SeverityTask { get; set; }
        public StatusTask StatusTask { get; set; }
    }
}
    public enum SeverityTask
    {
        Critical,
        Important,
        Unimportant
    }

    public enum StatusTask
    {
        Open,
        Closed
    }

