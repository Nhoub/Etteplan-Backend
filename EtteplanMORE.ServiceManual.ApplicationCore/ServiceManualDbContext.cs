using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EtteplanMORE.ServiceManual.ApplicationCore
{
    public class ServiceManualDbContext : DbContext
    {
        public ServiceManualDbContext(DbContextOptions<ServiceManualDbContext> options) : base(options) { }
        public DbSet<FactoryDevice> FactoryDevices { get; set; }
        public DbSet<MaintenanceTasks> MaintenanceTasks { get; set; }
    }

}
