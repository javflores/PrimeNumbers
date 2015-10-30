using System;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    internal class PrimeTableFactoryTest
    {
        private IPrimeTableFactory _primeTableFactory;

        [SetUp]
        public void Setup()
        {
            _primeTableFactory = new PrimeTableFactory();
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Create_Prime_Table_Rank_Lower_Then_1(int rank)
        {
            _primeTableFactory.Create(rank);
        }

        [Test]
        public void Should_Create_Prime_Table_Rank_3()
        {
            //given
            const int rank = 3;
            var tableAxis = new[] { 2, 3, 5 };
            var expectedTable = new PrimeTable(tableAxis);

            //when
            var table = _primeTableFactory.Create(rank);

            //then
            Assert.AreEqual(expectedTable.AxisX, table.AxisX);
            Assert.AreEqual(expectedTable.AxisY, table.AxisY);
        }
    }
}
