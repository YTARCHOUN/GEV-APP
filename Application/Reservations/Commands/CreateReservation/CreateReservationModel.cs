using System;
using System.Collections.Generic;
namespace Application.Reservations.Commands.CreateReservation
{
    public class CreateReservationModel
    {
        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string VehicleRegistrationNumber { get; set; }

        public DateTime VehicleRegistrationDate { get; set; }
        
        public DateTime ReservationDateTime { get; set; }

        public int BrandId { get; set; }

        public List<int> MaintenanceServicesIds { get; set; }
    }
}
