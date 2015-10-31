using System;
using Moq;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    internal class PrimeTableFactoryTest
    {
        private IPrimeTableFactory _primeTableFactory;
        private Mock<IPrimeNumberGenerator> _primeNumberGeneratorMock;

        [SetUp]
        public void Setup()
        {
            _primeNumberGeneratorMock = new Mock<IPrimeNumberGenerator>();
            _primeTableFactory = new PrimeTableFactory(_primeNumberGeneratorMock.Object);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Create_Prime_Table_Rank_Lower_Then_1(int rank)
        {
            _primeTableFactory.Create(rank);
        }
    }
}
