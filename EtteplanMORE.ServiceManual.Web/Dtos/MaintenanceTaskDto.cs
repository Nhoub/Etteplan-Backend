namespace EtteplanMORE.ServiceManual.Web.Dtos
{
    public class MaintenanceTaskDto
    {
        private DateTime registeredTimeTask;
        public int TaskId { get; set; }
        public int DeviceId { get; set; }
        public string? DescriptionTask { get; set; }
        public string RegisteredTimeTask
        {
            get { return registeredTimeTask.ToString("dd:MM:yyyy HH:mm"); }
            set { registeredTimeTask = Convert.ToDateTime(value); }
        }
        public string? SeverityTask { get; set; }
        public string? StatusTask { get; set; }
    }
}
