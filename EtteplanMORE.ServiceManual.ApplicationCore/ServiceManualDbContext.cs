using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore
{
    public class ServiceManualDbContext : DbContext
    {
        public ServiceManualDbContext(DbContextOptions<ServiceManualDbContext> options) : base(options) { }
        public DbSet<FactoryDevice> FactoryDevices { get; set; }
        public DbSet<MaintenanceTasks> MaintenanceTasks { get; set; }
    }
}
