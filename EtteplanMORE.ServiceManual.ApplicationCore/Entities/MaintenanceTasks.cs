using System;
using System.ComponentModel.DataAnnotations;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class MaintenanceTasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime RegisteredTimeTask { get; set; }
        [Required]
        public string DiscriptionTask { get; set; }
        [Required]
        public SeverityTask SeverityTask { get; set; }
        [Required]
        public StatusTask StatusTask { get; set; }
        /*[Required]
        public int DeviceId { get; set; }*/
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

