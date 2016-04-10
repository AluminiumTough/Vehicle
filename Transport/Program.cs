using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model
{
    class Program
    {
        static void Main()
        {
            var list = new List<IVehicle>();
            var car = new Car();
            car.TheCurrentAmountOfFuel = 40;
            list.Add(car);

            var hybrid = new Hybrid();
            hybrid.TheCurrentAmountOfFuel = 38;
            hybrid.CurrentAmountOfElectricity = 45;
            list.Add(hybrid);

            var helicopter = new Helicopter();
            helicopter.FuelConsumptionPer100km = 150;
            list.Add(helicopter);
            
            foreach (IVehicle vehicle in list)
            {
                Console.WriteLine("Средний расход топлива транспорта составляет {0} л",vehicle.GoTheDistance(100));
            }
             Console.ReadLine();
        }
    }
}