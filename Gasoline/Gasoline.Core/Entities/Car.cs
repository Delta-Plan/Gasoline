using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Data.Entities
{
    [Serializable]
    public class Car
    {
        /// <summary>
        /// Марка и модель машины
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// Краткое описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Короткое название машины
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// Инвормация о заправках
        /// </summary>
        public List<FuelDetail> FuelDetails { get; set; }
    }
}
