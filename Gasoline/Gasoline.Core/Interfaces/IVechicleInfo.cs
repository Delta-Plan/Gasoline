namespace Gasoline.Core.Interfaces
{
    public interface IVechicleInfo
    {
        public int Id { get; set; }
        public int IVechicleId { get; set; }
        public IMileage StartMileage { get; set; }
        public IMileage EndMileage { get; set; }
    }
}
