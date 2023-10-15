using Gasoline.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Core.Models
{
    public class Vechicle : IVechicle
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMileage CurrentMileage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IVechicleInfo VechicleInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
