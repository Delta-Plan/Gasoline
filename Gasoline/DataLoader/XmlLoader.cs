using Gasoline.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public class XmlLoader : ILoader
    {
        public Car Load()
        {
            var fileName = String.Empty; // todo
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(Car));
            var file = new StreamReader(fileName);
            var obj = (Car) reader.Deserialize(file);
            file.Close();
            return obj;
        }

        public void Save(Car car)
        {
            var fileName = String.Empty; // todo
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(Car));
            var file = new StreamWriter(fileName);
            writer.Serialize(file, car);
            file.Close();
        }
    }
}
