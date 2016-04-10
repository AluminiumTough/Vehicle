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
                if (value > 100)
                    throw new InvalidOperationException("!");
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
            set { _modelName = value; }
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
                if (value < 1980)
                    throw new InvalidOperationException("!");
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
                    throw new InvalidOperationException("!");
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