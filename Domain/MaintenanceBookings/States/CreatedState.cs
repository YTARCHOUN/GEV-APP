using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.State;

namespace VehicleMaintenance.Domain.MaintenanceBookings.States
{
    public class CreatedState : IState
    {
        public int Id
        {
            get
            {
                return MaintenanceBookingStates.CREATED;
            }
        }

        public List<int> NextStates
        {
            get
            {
                return new List<int>() { MaintenanceBookingStates.CONFIRMED, MaintenanceBookingStates.CANCELED };
            }
        }
    }
}
