namespace Gasoline.Core.Interfaces
{
    public interface IServiceOperation
    {
        public int Id { get; set; }
        public IVechicle Vechicle { get; set; }
        public IMileage Mileage { get; set; }
        public DateTime OperationDate { get; set; }
        public IOperationType OperationType { get; set; }
    }
}
