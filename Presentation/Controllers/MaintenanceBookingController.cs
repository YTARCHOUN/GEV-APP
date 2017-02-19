using Microsoft.AspNetCore.Mvc;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using VehicleMaintenance.Services.MaintenanceBookings;

namespace VehicleMaintenance.Controllers
{
    public class MaintenanceBookingController : Controller
    {
        private readonly ICreateMaintenanceBookingsViewModelFactoy _factory;
        private readonly ICreateMaintenanceBookingCommand _createCommand;
         
        public MaintenanceBookingController(
            ICreateMaintenanceBookingsViewModelFactoy factory,
            ICreateMaintenanceBookingCommand createCommand)
        {
            _factory = factory;
            _createCommand = createCommand;
        }
        public IActionResult Index()
        {
            var viewModel = _factory.Create();
            return View(viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = _factory.Create();
            return View(viewModel);
        }
    }
}
