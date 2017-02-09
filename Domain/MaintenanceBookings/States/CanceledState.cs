using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.State;

namespace VehicleMaintenance.Domain.MaintenanceBookings.States
{
    public class CanceledState : IState
    {
        public int Id
        {
            get
            {
                return MaintenanceBookingStates.CANCELED;
            }
        }

        public List<int> NextStates
        {
            get
            {
                return new List<int>();
            }
        }
    }
}
