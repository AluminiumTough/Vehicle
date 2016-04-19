using System;

namespace Model
{
    public class Helicopter : IVehicle
    {
        /// <summary>
        /// Расход керосина у вертолета на 100 км
        /// </summary>
        private int _fuelConsumptionPer100km;
        /// <summary>
        /// у ветолета расход всегда больше 100 литров керосина на сотню
        /// </summary>
       public int FuelConsumptionPer100km
        {
            get
            {
                return _fuelConsumptionPer100km;
            } 
           set
            {
                if (value < 100 || value > 350)
                    throw new InvalidOperationException("Неверно задан расход керосина у вертолета");
                _fuelConsumptionPer100km = value;
            }
        }
        /// <summary>
        /// Имя модели
        /// </summary>
        public string _modelName = "Helicopter";
        /// <summary>
        /// Имя модели
        /// </summary>
        public string ModelName
        {
            get { return _modelName; }

            set
            {
                if (!(value is string))
                    throw new ArgumentException("Неверное имя у вертолета");
                _modelName = value;
            }
        }

        public int _dateOfManufacture;

        /// <summary>
        /// год выпуска
        /// </summary>
        public int DateOfManufacture
        {
            get { return _dateOfManufacture; }
            set
            {
                if (value < 1955 || value > 2016)
                    throw new InvalidOperationException("Неверно задан год выпуска у вертолета");
                _dateOfManufacture = value;
            }
        }
        /// <summary>
        /// расстояние
        /// </summary>
        private int _distance;
        /// <summary>
        /// Дистанция
        /// </summary>
        public int Distance
        {
            get { return _distance; }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Неверно задан пробег у вертолета");
                _distance = value;
            }
        }
        /// <summary>
        /// метод расчета расхода топлива
        /// </summary>
        /// <param name="Distance"> дистанция</param>
        /// <returns>расход топлива </returns>
        public int GoTheDistance(int Distance)
        {
           return FuelConsumptionPer100km * 100 / Distance;
        }
    }
}