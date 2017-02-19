using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VehicleMaintenance.Services.MaintenanceBookings;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using VehicleMaintenance.DataAccess.Vehicles.Queries;
using VehicleMaintenance.DataAccess.Maintenances.Queries;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking.Factory;
using VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer;
using VehicleMaintenance.DataAccess.Vehicles.Commands;
using VehicleMaintenance.DataAccess.Customers.Factory;
using VehicleMaintenance.DataAccess.Customers.Commands.CreateCustomer.Factory;
using VehicleMaintenance.DataAccess.Vehicles.Commands.CreateVehicle.Factory;
using VehicleMaintenance.DataAccess;

namespace VehicleMaintenance
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry(Configuration);
            services.AddMvc();
            AddDatabase(services);
            AddFactories(services);
            AddCommands(services);
            AddQueries(services);

        }

        private void AddDatabase(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("VehicleMaintenance");
            services.AddSingleton<IDatabaseService>(p => new DatabaseService(connectionString));
        }

        private void AddFactories(IServiceCollection services)
        {
            services.AddTransient<ICreateMaintenanceBookingsViewModelFactoy, CreateMaintenanceBookingsViewModelFactory>();
            services.AddTransient<IMaintenanceBookingFactory, MaintenanceBookingFactory>();
            services.AddTransient<ICustomerFactory, CustomerFactory>();
            services.AddTransient<IVehicleFactory, VehicleFactory>();
        }

        private void AddCommands(IServiceCollection services)
        {
            services.AddTransient<ICreateMaintenanceBookingCommand, CreateMaintenanceBookingCommand>();
            services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            services.AddTransient<ICreateVehicleCommand, CreateVehicleCommand>();
        }

        private void AddQueries(IServiceCollection services)
        {
            services.AddTransient<IGetBrandListQuery, GetBrandListQuery>();
            services.AddTransient<IGetMaintenanceOptionListQuery, GetMaintenanceOptionListQuery>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseApplicationInsightsExceptionTelemetry();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
