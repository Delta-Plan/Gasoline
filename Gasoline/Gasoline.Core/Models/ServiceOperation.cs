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
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IVechicle Vechicle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMileage Mileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime OperationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOperationType OperationType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
