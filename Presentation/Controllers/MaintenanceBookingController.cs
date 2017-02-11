using Microsoft.AspNetCore.Mvc;
using VehicleMaintenance.Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using VehicleMaintenance.Services.MaintenanceBookings;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

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
            return View();
        }

        public IActionResult Create()
        {
            var viewModel = _factory.Create();
            return View(viewModel);
        }
    }
}
