using NUnit.Framework;
using CarManager;
using System;

namespace Tests
{
    public class CarTests
    {
        [TestCase("volvo", "S80", 20, 60)]
        public void CheckTheConstructorCar(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual("volvo", car.Make);
            Assert.AreEqual("S80", car.Model);
            Assert.AreEqual(20, car.FuelConsumption);
            Assert.AreEqual(60, car.FuelCapacity);
        }

        [TestCase("", "S80", 20, 60)]
        public void CheckTheExceptionForNullOnMake(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Make cannot be null or empty!");
        }

        [TestCase("volvo", "", 20, 60)]
        public void CheckTheExceptionForNullOnModel(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Model cannot be null or empty!");
        }

        [TestCase("volvo", "S80", 0, 60)]
        public void CheckTheExceptionForZeroOnFuelConsumption(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Fuel consumption cannot be zero or negative!");
        }

        [TestCase("volvo", "S80", 20, 0)]
        public void CheckTheExceptionForZeroOnFuelCapacity(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Fuel capacity cannot be zero or negative!");
        }

        [TestCase(-10)]
        public void CheckTheExceptionForNegativeOnRefuel(double fuelToRefuel)
        {
            Car car = new Car("volvo", "S80", 20, 60);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel), "Fuel capacity cannot be zero or negative!");
        }

        [TestCase(70)]
        public void CheckTheTankOverflow(double fuelToRefuel)
        {
            Car car = new Car("volvo", "S80", 20, 60);
            car.Refuel(fuelToRefuel);

            Assert.AreEqual(60,car.FuelAmount);
        }

        [TestCase(110)]
        public void CheckTheExceptionForInsufficientFuel(double distance)
        {
            Car car = new Car("volvo", "S80", 20, 60);
            car.Refuel(10);

            Assert.Throws<InvalidOperationException>(() => car.Drive(distance), "You don't have enough fuel to drive!");
        }

        [TestCase]
        public void CheckTheFuelAmountNextDrive()
        {
            Car car = new Car("volvo", "S80", 20, 60);
            car.Refuel(60);
            car.Drive(100);

            Assert.AreEqual(40,car.FuelAmount);
        }
    }
}