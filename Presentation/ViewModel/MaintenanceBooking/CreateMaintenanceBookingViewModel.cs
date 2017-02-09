using Application.MaintenanceBookings.Commands.CreateMaintenanceBooking;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VehicleMaintenance.ViewModel.MaintenanceBooking
{
    public class CreateMaintenanceBookingViewModel
    {
        public List<SelectListItem> Brands { get; set; }

        public List<SelectListItem> MaintenanceServices { get; set; }

        public CreateMaintenanceBookingModel CreateMaintenanceBookingModel { get; set; }
    }
}
