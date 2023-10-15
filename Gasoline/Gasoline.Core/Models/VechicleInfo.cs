using Gasoline.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Core.Models
{
    public class VechicleInfo : IVechicleInfo
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IVechicleId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMileage StartMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMileage EndMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
