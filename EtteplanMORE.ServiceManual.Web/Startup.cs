using EtteplanMORE.ServiceManual.ApplicationCore;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using EtteplanMORE.ServiceManual.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;

namespace EtteplanMORE.ServiceManual.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ServiceManualDbContext>(option => option.UseSqlServer("DefaultConnection"));
            services.AddScoped<IFactoryDeviceService, FactoryDeviceService>();
            services.AddScoped<IMaintenanceTasksService, MaintenanceTasksService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ServiceManualDbContext serviceManualDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //serviceManualDbContext.Database.Migrate();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

