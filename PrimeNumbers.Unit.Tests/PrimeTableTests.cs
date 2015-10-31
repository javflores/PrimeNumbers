using System;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    internal class PrimeTableTests
    {
        [Test]
        [TestCase(0, 0, 4)]
        [TestCase(0, 1, 6)]
        [TestCase(1, 1, 9)]
        public void Should_Return_Table_Cell_Value(int x, int y, int expectedValue)
        {
            //given
            var axis = new []{2, 3, 5};
            var table = new PrimeTable(axis);

            //when
            var cellValue = table.GetCellValue(x, y);

            //then
            Assert.AreEqual(expectedValue, cellValue);
        }

        [Test]
        [TestCase(0, 10)]
        [TestCase(-1, 1)]
        public void Should_Throw_Exception_When_IndexOutOfRange(int x, int y)
        {
            //given
            var axis = new[] { 2, 3, 5 };
            var table = new PrimeTable(axis);

            //when
            Assert.Throws<IndexOutOfRangeException>(() => table.GetCellValue(x, y));
        }
    }
}
