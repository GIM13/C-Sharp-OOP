namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        [TestCase("vv","bb")]
        public void CheckConstructor(string make, string model)
        {
            var phone = new Phone(make, model);

            Assert.AreEqual("vv",phone.Make);
            Assert.AreEqual("bb",phone.Model);
            Assert.AreEqual(0,phone.Count);
        }

        [Test]
        public void CheckConstructorForNullOnMake()
        {
            Assert.Throws<ArgumentException>(() => new Phone("", "model"));
        }

        [Test]
        public void CheckConstructorForNullOnModel()
        {
            Assert.Throws<ArgumentException>(() => new Phone("make", ""));
        }

        [Test]
        public void CheckAddContactForAddPersonAlreadyExists()
        {
            var phone = new Phone("make", "model");
            phone.AddContact("zaza", "4444");
            
            Assert.Throws<InvalidOperationException>(() => phone.AddContact("zaza", "4444"));
        }

        [Test]
        public void CheckCallForCallPersonDoesntExists()
        {
            var phone = new Phone("make", "model");
            phone.AddContact("zaza", "4444");
            
            Assert.Throws<InvalidOperationException>(() => phone.Call("zuzu"));
        }
    }
}