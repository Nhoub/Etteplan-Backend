using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Services
{
    public class MaintenanceTasksService : IMaintenanceTasksService
    {
        private readonly ServiceManualDbContext _serviceManualDbContext;

        public MaintenanceTasksService(ServiceManualDbContext serviceManualDbContext)
        {
            _serviceManualDbContext = serviceManualDbContext;
        }
    }
}
