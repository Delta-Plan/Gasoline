using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasoline.Data.Entities
{
    [Serializable]
    public class FuelDetail
    {
        /// <summary>
        /// Дата заправки
        /// </summary>
        public DateTime FuelDate { get; set; }
        /// <summary>
        /// Количество залитых литров горючего
        /// </summary>
        public decimal Liters { get; set; }
        /// <summary>
        /// Стоимость заправки
        /// </summary>
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Пробег автомобиля (в километрах)
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// Тип топлива
        /// </summary>
        public FuelType FuelType { get; set; }
    }

    [Serializable]
    public enum FuelType
    {
        Gasoline = 0,
        Diesel = 1,
        Electric = 2,
    }
}
