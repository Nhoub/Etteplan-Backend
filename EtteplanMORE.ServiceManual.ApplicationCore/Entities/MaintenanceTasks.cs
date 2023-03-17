using System;
using System.ComponentModel.DataAnnotations;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class MaintenanceTasks
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Fill in a correct date time!")]
        public DateTime RegisteredTimeTask { get; set; }
        [Required(ErrorMessage = "Fill in a discription, characters only!")]
        public string DiscriptionTask { get; set; }
        [Required(ErrorMessage = "Value can only bee Critical, Important or Unimportant")]
        public SeverityTask SeverityTask { get; set; }
        [Required(ErrorMessage = "Value can only be Open or Closed!")]
        public StatusTask StatusTask { get; set; }
        [Required(ErrorMessage = "DevideId not found")]
        public int DeviceId { get; set; }
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

