using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Car : IVehicle
    {
     /// <summary>
     ///Расход на 100 км
     /// </summary>
        private   int _fuelConsumptionPer100km;
        /// <summary>
        /// Расход на 100 км
        /// </summary>
       public int FuelConsumptionPer100km
        {
           get { return _fuelConsumptionPer100km; } 
           set
            {
                if (value > 100)
                    throw new InvalidOperationException("!");
                _fuelConsumptionPer100km = value;
            } 
        }

        /// <summary>
        /// Объем бака
        /// </summary>
        private  int _volumeOfTheTank;
        /// <summary>
        /// Объем бака
        /// </summary>
        private int VolumeOfTheTank
        {
            get 
            { 
                return _volumeOfTheTank; 
            }

            set
            {
                if (value < 0 || value > 85)
                    throw new InvalidOperationException("!");
                _volumeOfTheTank = value;
            }
        }
        /// <summary>
        /// Количество топлива
        /// </summary>
        private int _theCurrentAmountOfFuel;
        /// <summary>
        /// Количество топлива
        /// </summary>
        public int TheCurrentAmountOfFuel
        {
            get { return _theCurrentAmountOfFuel; }
            set
            {
                if (value < 0 || value > 70)
                    throw new InvalidOperationException("!");
                _theCurrentAmountOfFuel = value;
            }
        }

        private string _modelName = "Car";
        /// <summary>
        /// Имя модели
        /// </summary>
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }
        /// <summary>
        /// Год выпуска
        /// </summary>
        private int _dateOfManufacture;

        /// <summary>
        /// Год выпуска
        /// </summary>
       public int DateOfManufacture

        {
            get { return _dateOfManufacture; }
            set
            {
                if (value < 0 || value > 2016)
                    throw new InvalidOperationException("!");
                _dateOfManufacture = value;
            }
        }
        /// <summary>
        /// Дистанция
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
        /// Метод расчета расхода топлива
        /// </summary>
        /// <param name="Distance"> Дистанция</param>
        /// <returns> Расход топлива</returns>
        public int GoTheDistance(int Distance)
        {
            return TheCurrentAmountOfFuel * 100 / Distance;
        }
   }
}