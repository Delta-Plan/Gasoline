using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gasoline.Data.Entities;

namespace DataLoader
{
    public interface ILoader
    {
        void Save(Car car);
        Car Load();
    }
}
