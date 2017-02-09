namespace VehicleMaintenance.Domain.Common.State
{
    public abstract class StatefullEntity
    {
        private IState _state;
        

        public StatefullEntity(IState state)
        {
            _state = state;
        }

        public IState State {
            get
            {
                return _state;
            }
            internal set
            {
                _state = value;
            }
        }
    }
}
