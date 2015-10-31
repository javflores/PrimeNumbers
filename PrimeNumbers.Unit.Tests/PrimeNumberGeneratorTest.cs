using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    internal class PrimeNumberGeneratorTest
    {
        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(5, 7)]
        [TestCase(7, 11)]
        [TestCase(11, 13)]
        public void Should_Generate_Prime_Number(int start, int expected)
        {
            //given
            var primeNumberGenerator = new PrimeNumberGenerator(start);

            //when
            var prime = primeNumberGenerator.GenerateNext();

            //then
            Assert.AreEqual(expected, prime);
        }
    }
}
