using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Core.Interfaces
{
    public interface IDataStore
    {
        object GetById(int id);
        void Update(object data);
        int Create(object data);
    }
}
