namespace Gasoline.Core.Interfaces
{
    public interface IOperationLifeTime
    {
        public IOperationType OperationType { get; set; }
        public IVechicle Vechicle { get; set; }
        public IMileage LifeTime { get; set; }
    }
}
