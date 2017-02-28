using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using Microsoft.AspNetCore.Mvc;
using VehicleMaintenance.DataAccess.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using VehicleMaintenance.Services.MaintenanceBookings;
using VehicleMaintenance.ViewModel.MaintenanceBooking;
using System.Linq;
using System.Collections.Generic;

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

        public IActionResult Create(CreateMaintenanceBookingViewModel viewModel)
        {
            var createMaintenanceBookingModel = new CreateMaintenanceBookingModel()
            {
                BrandId = viewModel.CreateMaintenanceBookingModel.BrandId,
                CustomerFirstName = viewModel.CreateMaintenanceBookingModel.CustomerFirstName,
                CustomerLastName = viewModel.CreateMaintenanceBookingModel.CustomerLastName,
                MaintenanceBookingDateTime = viewModel.CreateMaintenanceBookingModel.MaintenanceBookingDateTime,
                VehicleRegistrationDate = viewModel.CreateMaintenanceBookingModel.VehicleRegistrationDate,
                VehicleRegistrationNumber = viewModel.CreateMaintenanceBookingModel.VehicleRegistrationNumber,
                MaintenanceServicesIds = viewModel.MaintenanceOptions.FindAll(x => x.Selected = true).Select(item => int.Parse(item.Value)).ToList()
            };
            _createCommand.Execute(createMaintenanceBookingModel);
            return View("BookingConfirmation");
        }
        public IActionResult BookingConfirmation()
        {
             return View();
        }
    }
}
