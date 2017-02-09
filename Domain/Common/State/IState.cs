using System.Collections.Generic;

namespace VehicleMaintenance.Domain.Common.State
{
    public interface IState
    {
        int Id { get; }
        List<int> NextStates { get; }
    }
}
