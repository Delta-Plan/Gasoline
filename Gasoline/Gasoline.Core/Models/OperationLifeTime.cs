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
        public IOperationType OperationType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IVechicle Vechicle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMileage LifeTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
