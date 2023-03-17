using EtteplanMORE.ServiceManual.ApplicationCore.Entities;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Interfaces
{
    public interface IMaintenanceTasksService
    {
        public MaintenanceTasks Get(int id);
        public MaintenanceTasks GetDeviceTask(int deviceId);
        public MaintenanceTasks DeleteTask(int taskId);
        public MaintenanceTasks UpdateTask(MaintenanceTasks task);
        public MaintenanceTasks AddTask(MaintenanceTasks task);
    }
}
