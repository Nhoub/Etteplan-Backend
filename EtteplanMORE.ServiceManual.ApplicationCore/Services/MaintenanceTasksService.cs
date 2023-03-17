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
        /// Get the MaitenanceTasks correspinding with the given id, ordered first by severity and then by registered time
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

        /// <summary>
        /// Update the task given of the given task id is not null. The registered time does not need to be updateted 
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public MaintenanceTasks UpdateTask(MaintenanceTasks task)
        {
            var result = _serviceManualDbContext.MaintenanceTasks.FirstOrDefault(i => i.Id == task.Id);

            if(result != null)
            {
                result.Id = task.Id;
                result.DiscriptionTask = task.DiscriptionTask;
                result.SeverityTask = task.SeverityTask;
                result.StatusTask = task.StatusTask;

                _serviceManualDbContext.SaveChanges();
                return task;
            }

           return null;
        }

        /// <summary>
        /// Delete the maitenance task corrosponding with the given id
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Add a new task
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public MaintenanceTasks AddTask(MaintenanceTasks task)
        {
            task.RegisteredTimeTask = DateTime.Now;
            _serviceManualDbContext.Add(task);
            _serviceManualDbContext.SaveChanges();
            return task;

        }
    }
}
