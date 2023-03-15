using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using System;
using System.Linq;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Services
{
    public class MaintenanceTasksService : IMaintenanceTasksService
    {
        private readonly ServiceManualDbContext _serviceManualDbContext;

        public MaintenanceTasksService(ServiceManualDbContext serviceManualDbContext)
        {
            _serviceManualDbContext = serviceManualDbContext;
        }


        /// <summary>
        /// Get the list of MaitenanceTasks, ordered first by severity and then by registered time
        /// </summary>
        /// <returns></returns>
        public MaintenanceTasks Get(int id)
        {
            var task = _serviceManualDbContext.MaintenanceTasks
                .Where(i => i.Id == id)
                .OrderBy(m => m.SeverityTask)
                .ThenByDescending(m => m.RegisteredTimeTask);

            return (MaintenanceTasks)task;
        }

        public MaintenanceTasks GetDeviceTask(int deviceId)
        {
            throw new NotImplementedException();
        }

        public MaintenanceTasks UpdateTask(MaintenanceTasks task)
        {
            task.RegisteredTimeTask = DateTime.Now;
            _serviceManualDbContext.Attach(task);
            _serviceManualDbContext.Add(task);
            return task;
        }

       

        public MaintenanceTasks DeleteTask(int taskId)
        {
            var result = _serviceManualDbContext.MaintenanceTasks.FirstOrDefault(task => task.Id == taskId);
            if(result != null)
            {
                _serviceManualDbContext.MaintenanceTasks.Remove(result);
                _serviceManualDbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public MaintenanceTasks AddTask(MaintenanceTasks task)
        {
            throw new NotImplementedException();
        }
    }
}
