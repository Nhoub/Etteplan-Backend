using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Services
{
    public class FactoryDeviceService : IFactoryDeviceService
    {
        private readonly ServiceManualDbContext _serviceManualDbContext;

        public FactoryDeviceService(ServiceManualDbContext serviceManualDbContext)
        {
            _serviceManualDbContext = serviceManualDbContext;
        }
        public async Task<IEnumerable<FactoryDevice>> GetAll()
        {
            return await Task.FromResult(_serviceManualDbContext.FactoryDevices);
        }

        public async Task<FactoryDevice> Get(int id)
        {
            return await Task.FromResult(_serviceManualDbContext.FactoryDevices.FirstOrDefault(device => device.Id == id));
        }
    }
}