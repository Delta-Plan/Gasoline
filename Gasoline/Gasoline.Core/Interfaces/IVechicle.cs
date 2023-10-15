namespace Gasoline.Core.Interfaces
{
    public interface IVechicle
    {
        public int Id { get; set; }
        public IMileage CurrentMileage { get; set; }
        public IVechicleInfo VechicleInfo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
