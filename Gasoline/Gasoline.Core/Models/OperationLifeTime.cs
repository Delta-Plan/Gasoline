using Gasoline.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Core.Models
{
    public class OperationLifeTime : IOperationLifeTime
    {
        public IOperationType OperationType { get; set; }
        public IVechicle Vechicle { get; set; }
        public IMileage LifeTime { get; set; }
    }
}
