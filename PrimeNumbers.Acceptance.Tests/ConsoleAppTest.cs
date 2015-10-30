using System;
using System.IO;
using NUnit.Framework;
using PrimeNumbers.BusinessLogic;
using PrimeNumbers.UI.ConsoleApp;

namespace PrimeNumbers.Acceptance.Tests
{
    [TestFixture]
    internal class ConsoleAppTest
    {
        [Test]
        public void Should_Create_And_Print_Prime_Numbers_Table()
        {
            //given
            var input = "3";
            var expectedOutput = GetExpectedOutputForRank3Table();

            //when
            string output;
            using (var writer = new StringWriter())
            {
                using (var reader = new StringReader(input))
                {
                    Console.SetOut(writer);
                    Console.SetIn(reader);

                    Program.Main(null);

                    output = writer.ToString();
                }
            }

            //then
            Assert.AreEqual(expectedOutput, output);
        }

        private string GetExpectedOutputForRank3Table()
        {
            var raw1 = String.Format("{0}2{0}3{0}5{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw2 = String.Format("2{0}4{0}6{0}10{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw3 = String.Format("3{0}6{0}9{0}15{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);
            var raw4 = String.Format("5{0}10{0}15{0}25{1}", TabDelimitedTablePrinter.Tab, Environment.NewLine);

            return Program.ConsoleMessage + raw1 + raw2 + raw3 + raw4;
        }
    }
}
