using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [Test]
        public void CheckConstructor()
        {
            var raceEntry = new RaceEntry();
        }

        [Test]
        public void CheckAddRider()
        {
            var unitMotorcycle = new UnitMotorcycle("motor", 100, 200);
            var unitRider = new UnitRider("lud", unitMotorcycle);

            var raceEntry = new RaceEntry();

            raceEntry.AddRider(unitRider);

            Assert.AreEqual(1, raceEntry.Counter);
        }

        [Test]
        public void CheckAddRiderForNull()
        {
            var raceEntry = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(null), "RiderInvalid");
        }

        [Test]
        public void CheckAddRiderForDuplication()
        {
            var unitMotorcycle = new UnitMotorcycle("motor", 100, 200);
            var unitRider = new UnitRider("lud", unitMotorcycle);

            var raceEntry = new RaceEntry();

            raceEntry.AddRider(unitRider);

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddRider(unitRider));
        }

        [Test]
        public void CheckCalculateAverageHorsePowerForException()
        {
            var unitMotorcycle = new UnitMotorcycle("motor", 100, 200);
            var unitRider = new UnitRider("lud", unitMotorcycle);

            var raceEntry = new RaceEntry();

            raceEntry.AddRider(unitRider);

            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CheckCalculateAverageHorsePower()
        {
            var unitMotorcycle = new UnitMotorcycle("motor", 100, 200);
            var unitRider1 = new UnitRider("lud1", unitMotorcycle);
            var unitRider2 = new UnitRider("lud2", unitMotorcycle);

            var raceEntry = new RaceEntry();

            raceEntry.AddRider(unitRider1);
            raceEntry.AddRider(unitRider2);

            Assert.AreEqual(100, raceEntry.CalculateAverageHorsePower());
        }
    }
}