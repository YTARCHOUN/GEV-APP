using Application.Reservations.Commands.CreateReservation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace VehicleMaintenance.ViewModel.Reservation
{
    public class CreateReservationViewModel
    {
        public List<SelectListItem> Brands { get; set; }

        public List<SelectListItem> MaintenanceServices { get; set; }

        public CreateReservationModel CreateReservationModel { get; set; }
    }
}
