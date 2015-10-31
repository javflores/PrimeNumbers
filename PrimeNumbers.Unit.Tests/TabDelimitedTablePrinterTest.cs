using System;
using System.IO;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.Unit.Tests
{
    [TestFixture]
    public class TabDelimitedTablePrinterTest
    {
        private ITablePrinter _tablePrinter;
        private StringWriter _consoleOutWriter;

        [SetUp]
        public void Setup()
        {
            _consoleOutWriter = new StringWriter();
            Console.SetOut(_consoleOutWriter);

            _tablePrinter = new TabDelimitedTablePrinter();
        }

        [Test]
        public void Should_Not_Print_Null_Prime_Table()
        {
            //given
            var expectedOutput = String.Empty;
            PrimeTable table = null;

            //when
            _tablePrinter.Print(table);

            //then
            var consoleOutput = _consoleOutWriter.ToString();
            Assert.AreEqual(expectedOutput, consoleOutput);
        }

        [Test]
        public void Should_Not_Print_Empty_Prime_Table()
        {
            //given
            var expectedOutput = String.Empty;
            PrimeTable table = new PrimeTable(null);

            //when
            _tablePrinter.Print(table);

            //then
            var consoleOutput = _consoleOutWriter.ToString();
            Assert.AreEqual(expectedOutput, consoleOutput);
        }

        [Test]
        public void Should_Print_Prime_Table_Rank_3()
        {
            //given
            var expectedOutput = GetExpectedOutputForRank3Table();

            var tableAxis = new[] { 2, 3, 5 };
            var table = new PrimeTable(tableAxis);

            //when
            _tablePrinter.Print(table);

            //then
            var consoleOutput = _consoleOutWriter.ToString();
            Assert.AreEqual(expectedOutput, consoleOutput);
        }

        private string GetExpectedOutputForRank3Table()
        {
            var raw1 = String.Format("{0}2{0}3{0}5{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw2 = String.Format("2{0}4{0}6{0}10{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw3 = String.Format("3{0}6{0}9{0}15{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw4 = String.Format("5{0}10{0}15{0}25{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);

            return raw1 + raw2 + raw3 + raw4;
        }
    }
}
