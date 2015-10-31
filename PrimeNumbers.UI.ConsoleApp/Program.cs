using System;
using PrimeNumbers.BusinessLogic;

namespace PrimeNumbers.UI.ConsoleApp
{
    public class Program
    {
        public const string ConsoleMessage = "Please provide the prime table rank:";
        public const string ConsoleErrorMessage = "Invalid rank.";

        public static void Main(string[] args)
        {
            Console.Write(ConsoleMessage);
            var rankString = Console.ReadLine();

            int rank;
            if (int.TryParse(rankString, out rank) && rank > 0)
            {
                var primeNumberGenerator = new PrimeNumberGenerator();
                var primeTableFactory = new PrimeTableFactory(primeNumberGenerator);
                var primeTable = primeTableFactory.Create(rank);

                var tabDelimitedTablePrinter = new TabDelimitedTablePrinter();
                tabDelimitedTablePrinter.Print(primeTable);
            }
            else Console.WriteLine(ConsoleErrorMessage);

            Console.ReadLine();
        }
    }
}
