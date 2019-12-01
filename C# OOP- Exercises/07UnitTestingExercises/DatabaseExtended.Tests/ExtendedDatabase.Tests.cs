namespace Tests
{
    using NUnit.Framework;
    using ExtendedDatabase;
    using Database;
    using System;

    public class ExtendedDatabaseTests
    {
        [TestCase(13, "Gigi")]
        public void ConstructorPersonMustReturnNewPersonProperty(long id, string userName)
        {
            var result = new Person(id, userName);

            Assert.AreEqual(13, result.Id);
            Assert.AreEqual("Gigi", result.UserName);
        }

        Person person1 = new Person(13, "Gigi1");
        Person person2 = new Person(14, "Gigi2");
        Person person3 = new Person(15, "Gigi3");
        Person person4 = new Person(16, "Gigi4");
        Person person5 = new Person(17, "Gigi5");
        Person person6 = new Person(18, "Gigi6");
        Person person7 = new Person(19, "Gigi7");
        Person person8 = new Person(20, "Gigi8");
        Person person9 = new Person(216, "Gigi9");
        Person person10 = new Person(147, "Gigi10");
        Person person11 = new Person(113, "Gigi11");
        Person person12 = new Person(141, "Gigi12");
        Person person13 = new Person(105, "Gigi13");
        Person person14 = new Person(116, "Gigi14");
        Person person15 = new Person(146, "Gigi15");
        Person person16 = new Person(170, "Gigi16");
        Person person17 = new Person(17, "Gigi17");

        [TestCase]
        public void AddMustReturnExceptionyFor17Parameters()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8
                                            , person9, person10, person11
                                            , person12, person13, person14
                                            , person15, person16);

            Assert.Throws<InvalidOperationException>(() => result.Add(person17), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase]
        public void AddMustReturnExceptionyForExistinName()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws<InvalidOperationException>(() => result.Add(person7), "There is already user with this username!");
        }

        [TestCase]
        public void AddMustReturnExceptionyForExistingId()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws<InvalidOperationException>(() => result.Add(person17), "There is already user with this username!");
        }

        [TestCase]
        public void ConstructorMustReturnPersonArray0()
        {
            var result = new ExtendedDatabase();

            Assert.AreEqual(0, result.Count);
        }

        [TestCase]
        public void ConstructorMustReturnException()
        {
            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(new Person[17]), "Provided data length should be inrange   [0..16]!");
        }

        [TestCase]
        public void RemoveMustReturnException()
        {
            var result = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => result.Remove(), "The collection is empty!");
        }

        [TestCase]
        public void RemoveMustReturnCountMinus1()
        {
            var result = new ExtendedDatabase(person1);

            result.Remove();

            Assert.AreEqual(0, result.Count);
        }

        [TestCase]
        public void FindByUsernameMustReturnExceptionForNameNull()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws<ArgumentNullException>(() => result.FindByUsername(string.Empty), "Username parameter is null!");
        }

        [TestCase]
        public void FindByUsernameMustReturnExceptionForNameFalse()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws< InvalidOperationException> (() => result.FindByUsername("bibi"), "No user is present by this username!");
        }

        [TestCase]
        public void FindByUsernameMustReturnrPerson()
        {
            Person person18 = new Person(1117, "Gigi18");

            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person18);


            Assert.AreEqual(person18, result.FindByUsername("Gigi18"));
        }

        [TestCase]
        public void FindByIdReturnExceptionForIdNegativ()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws<ArgumentOutOfRangeException>(() => result.FindById(-55), "Id should be a positive number!");
        }

        [TestCase]
        public void FindByIdMustReturnExceptionForIdFalse()
        {
            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person8);

            Assert.Throws< InvalidOperationException> (() => result.FindById(55), "No user is present by this ID!");
        }

        [TestCase]
        public void FindByIdMustReturnrId()
        {
            Person person18 = new Person(1117, "Gigi18");

            var result = new ExtendedDatabase(person1, person2, person3, person4
                                            , person5, person6, person7, person18);


            Assert.AreEqual(person18, result.FindById(1117));
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]
        public void ConstructorMustReturnIntArray16(params int[] data)
        {
            var result = new Database(data);

            Assert.AreEqual(16, result.Count);
        }

        [TestCase]
        public void ConstructorMustReturnIntArray0(params int[] data)
        {
            var result = new Database(data);

            Assert.AreEqual(0, result.Count);
        }

        [TestCase(1, 2, 3, 4, 5, 6)]
        public void ConstructorMustReturnIntArray6(params int[] data)
        {
            var result = new Database(data);

            Assert.AreEqual(6, result.Count);
        }

        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17)]
        public void ConstructorMustReturnException(params int[] data)
        {
            Assert.Throws<InvalidOperationException>(() => new Database(data), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase]
        public void RemoveMustReturnExceptionD()
        {
            var result = new Database();

            Assert.Throws<InvalidOperationException>(() => result.Remove(), "The collection is empty!");
        }

        [TestCase]
        public void RemoveMustReturnCountMinus1D()
        {
            var result = new Database(1, 2, 3, 4);

            result.Remove();

            Assert.AreEqual(3, result.Count);
        }

        [TestCase]
        public void FetchMustReturnCoppyArray()
        {
            var fetch = new Database(1, 2, 3, 4, 5, 6, 7);

            int[] forComparison = { 1, 2, 3, 4, 5, 6, 7 };

            Assert.AreEqual(forComparison, fetch.Fetch());
        }
    }
}