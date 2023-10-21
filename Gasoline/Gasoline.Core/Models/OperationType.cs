using Gasoline.Core.Interfaces;

namespace Gasoline.Core.Models
{
    public class OperationType : IOperationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
