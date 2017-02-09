using System.Collections.Generic;
using VehicleMaintenance.Domain.Common.State;

namespace VehicleMaintenance.Domain.Maintenances.States
{
    public class ProgressingState : IState
    {
        public int Id
        {
            get
            {
                return MaintenanceStates.PROGRESSING;
            }
        }

        public List<int> NextStates
        {
            get
            {
                return new List<int>() { MaintenanceStates.COMPLETED };
            }
        }
    }
}
