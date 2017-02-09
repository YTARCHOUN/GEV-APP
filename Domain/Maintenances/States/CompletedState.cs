using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.State;

namespace VehicleMaintenance.Domain.Maintenances.States
{
    public class CompletedState : IState
    {
        public int Id
        {
            get
            {
                return MaintenanceStates.COMPLETED;
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
