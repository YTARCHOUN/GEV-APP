using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.State;

namespace VehicleMaintenance.Domain.MaintenanceBookings.States
{
    public class ConfirmedState : IState
    {
        public int Id
        {
            get
            {
                return MaintenanceBookingStates.CONFIRMED;
            }
        }

        public List<int> NextStates
        {
            get
            {
                return new List<int>() { MaintenanceBookingStates.CANCELED };
            }
        }
    }
}
