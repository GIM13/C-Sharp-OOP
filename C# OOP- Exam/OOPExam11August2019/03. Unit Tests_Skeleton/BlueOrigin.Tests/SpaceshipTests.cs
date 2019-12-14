namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        [Test]
        public void CheckConstructor()
        {
            var spaceship = new Spaceship("zaza", 7);

            Assert.AreEqual("zaza", spaceship.Name);
            Assert.AreEqual(7, spaceship.Capacity);
            Assert.AreEqual(0, spaceship.Count);
        }

        [Test]
        public void CheckNameForNuly()
        {
            Assert.Throws<ArgumentNullException>(() => new Spaceship("", 7));
        }

        [Test]
        public void CheckCapacityForNegativeValue()
        {
            Assert.Throws<ArgumentException>(() => new Spaceship("zaza", -7));
        }

        [Test]
        public void CheckCapacityForFullException()
        {
            var spaceship = new Spaceship("zaza", 1);
            spaceship.Add(new Astronaut("gogo", 4));

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(new Astronaut("dodo", 4)));
        }

        [Test]
        public void CheckCapacityForAstronautDuplicationException()
        {
            var spaceship = new Spaceship("zaza", 7);
            spaceship.Add(new Astronaut("gogo", 4));

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(new Astronaut("gogo", 5)));
        }

        [Test]
        public void CheckRemove()
        {
            var spaceship = new Spaceship("zaza", 7);
            spaceship.Add(new Astronaut("gogo", 4));
            spaceship.Add(new Astronaut("pipi", 4));

            var result = spaceship.Remove("gogo");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void CheckAstronautOxygen()
        {
            var astronaut = new Astronaut("gogo", 5.5);

            Assert.AreEqual(5.5, astronaut.OxygenInPercentage);
        }
    }
}