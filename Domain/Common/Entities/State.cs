namespace VehicleMaintenance.Domain.Common.Entities
{
    public class State : IEntity
    {
        private State() { }
        public State(StatefullEntities Entity)
        {
            this.Entity = Entity;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public StatefullEntities Entity { get; set; }
    }
}
