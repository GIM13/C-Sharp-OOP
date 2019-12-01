namespace Tests
{
    using NUnit.Framework;
    using Database;
    using System;

    public class DatabaseTests
    {
        [TestCase(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]
        public void ConstructorMustReturnIntArray16(params int[] data)
        {
            var result = new Database(data);

            Assert.AreEqual(16, result.Count);
        }

        [TestCase()]
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

        [TestCase()]
        public void RemoveMustReturnException()
        {
            var result = new Database();

            Assert.Throws<InvalidOperationException>(() => result.Remove(), "The collection is empty!");
        }

        [TestCase()]
        public void RemoveMustReturnCountMinus1()
        {
            var result = new Database(1, 2, 3, 4);

            result.Remove();

            Assert.AreEqual(3, result.Count);
        }

        [TestCase()]
        public void FetchMustReturnCoppyArray()
        {
            var fetch = new Database(1, 2, 3, 4, 5, 6, 7);

            int[] forComparison = { 1, 2, 3, 4, 5, 6, 7 };

            Assert.AreEqual(forComparison, fetch.Fetch());
        }
    }
}