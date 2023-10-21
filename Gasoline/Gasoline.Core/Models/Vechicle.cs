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
        public int Id { get; set; }
        public IMileage CurrentMileage { get; set; }
        public IVechicleInfo VechicleInfo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
