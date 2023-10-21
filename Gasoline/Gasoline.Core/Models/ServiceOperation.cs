using Gasoline.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Core.Models
{
    public class ServiceOperation : IServiceOperation
    {
        public int Id { get; set; }
        public IVechicle Vechicle { get; set; }
        public IMileage Mileage { get; set; }
        public DateTime OperationDate { get; set; }
        public IOperationType OperationType { get; set; }
    }
}
