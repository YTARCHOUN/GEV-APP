namespace VehicleMaintenance.Domain.Common.State
{
    public class StateMachine
    {
        private readonly StatefullEntity _statefullEntity;

        public StateMachine(StatefullEntity statefullEntity)
        {
            _statefullEntity = statefullEntity;
        }
        public void ApplyState(IState state)
        {
            if (_statefullEntity.State.NextStates.Contains(state.Id))
            {
                _statefullEntity.State = state;
            }
        }
    }
}
