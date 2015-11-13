using System.Linq;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    internal class PrimeNumberGeneratorTest
    {
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        public void Should_Generate_Prime_Number(int expected)
        {
            var primeNumberGenerator = new PrimeNumberGenerator();

            Assert.IsTrue(primeNumberGenerator.Any(prime => prime == expected));
        }
    }
}
