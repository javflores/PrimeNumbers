using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Integration.Tests
{
    [TestFixture]
    internal class PrimeTableFactoryTest
    {
        private IPrimeTableFactory _primeTableFactory;
        private IPrimeNumberGenerator _primeNumberGenerator;

        [SetUp]
        public void Setup()
        {
            _primeNumberGenerator = new PrimeNumberGenerator();
            _primeTableFactory = new PrimeTableFactory(_primeNumberGenerator);
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
