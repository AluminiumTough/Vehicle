using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   /// <summary>
/// Представляет общую информацию о любом виде транспорта
/// </summary>
    public interface IVehicle
    {   
        /// <summary>
        /// Название транспорта
        /// </summary>
        
        string ModelName { get; set; }
        /// <summary>
        /// Год выпуска
        /// </summary>
        int DateOfManufacture { get; set; }
        /// <summary>
        /// Пробег
        /// </summary>
        int Distance { get; set; }
        /// <summary>
        /// методы для расчета расхода топлива
        /// </summary>
        /// <param name="Distance">Пройденная дистанция</param>
        /// <returns>Расход топлива</returns>
        
       int GoTheDistance(int Distance);    
    }
}