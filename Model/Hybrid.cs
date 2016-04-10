using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Hybrid : IVehicle
    {
        private int _fuelConsumptionPer100km;
        /// <summary>
        /// Расход топлива на 100 км
        /// </summary>
        int FuelConsumptionPer100km
        {
            set
            {
                if (value > 100)
                    throw new InvalidOperationException("!");
                _fuelConsumptionPer100km = value;
            }
            get { return _fuelConsumptionPer100km; }
        }

        private int _electricityConsumptionPer100km;
        /// <summary>
        /// Расход электричества на 100 км
        /// </summary>
        int ElectricityConsumptionPer100km
        {
            set
            {
                if (value < 25 || value > 65 )
                    throw new InvalidOperationException("!");
                _electricityConsumptionPer100km = value;
            }
            get { return _electricityConsumptionPer100km; }
        }

        private int _powerOfBattery;
        /// <summary>
        /// Мощность аккумулятора 
        /// </summary>
        public int PowerOfBattery
        {
            set
            {
                if (value < 50 || value > 80)
                    throw new InvalidOperationException("!");
                _powerOfBattery = value;
            }
            get { return _powerOfBattery; }
        }
        
        private int _volumeOfTheTank;
        /// <summary>
        /// Объем бака
        /// </summary>
        public int VolumeOfTheTank
        {
            set
            {
                if (value < 0 || value > 40)
                    throw new InvalidOperationException("!");
                _volumeOfTheTank = value;
            }
            get { return _volumeOfTheTank; }
        }
        /// <summary>
        /// Текущее количество топлива 
        /// </summary>
        private int _theCurrentAmountOfFuel;
        /// <summary>
        ///  Количество топлива
        /// </summary>
        public int TheCurrentAmountOfFuel
        {
            set
            {
                if (value < 0 || value > 40)
                    throw new InvalidOperationException("!");
                _theCurrentAmountOfFuel = value;
            }
            get { return _theCurrentAmountOfFuel; }
        }
        /// <summary>
        /// Количество электричества
        /// </summary>
        public int CurrentAmountOfElectricity
        { set; get; }

        private string _modelName = "Hybrid";
        /// <summary>
        /// Имя модели
        /// </summary>
        public string ModelName
        {
            set { _modelName = value; }
            get { return _modelName; }
        }
        /// <summary>
        /// Год выпуска
        /// </summary>
        private int _dateOfManufacture;

      
        public int DateOfManufacture
        {
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("!");
                _dateOfManufacture = value;
            }
            get { return _dateOfManufacture; }
        }
       
        private int _distance;
        /// <summary>
        /// Пробег
        /// </summary>
        public int Distance
        {
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("!");
                _distance = value;
            }

            get { return _distance; }
        }


        /// <summary>
        /// Метод расчета расхода топлива
        /// </summary>
        /// <param name="Distance"> Дистанция</param>
        /// <returns>Расход </returns>
        public int GoTheDistance(int Distance)
        {
            if (Distance <= 400) // Запас хода на эл-ве 400км
            {
                return CurrentAmountOfElectricity * 100 / Distance;
            }
            // 400 км на эл-ве, остальное на бензине
            return (CurrentAmountOfElectricity * 100 / 400) + (TheCurrentAmountOfFuel * 100 / (Distance - 400));
        }
    }
}