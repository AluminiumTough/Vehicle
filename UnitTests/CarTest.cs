using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace Model
{
    [TestFixture]

    public class CarTest
    {
        [Test]
        [TestCase(100)]
        public void FuelConsumptionPer100kmTest(int fuelConsumptionPer100km)
        {
            var Car = new Car();
            Car.FuelConsumptionPer100km = fuelConsumptionPer100km;
        }
    }
}
