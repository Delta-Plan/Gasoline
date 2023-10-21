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
        public int Id { get; set; }
        public int IVechicleId { get; set; }
        public IMileage StartMileage { get; set; }
        public IMileage EndMileage { get; set; }
    }
}
