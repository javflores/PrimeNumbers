using System;

namespace PrimeNumbers.UI.ConsoleApp
{
    public class Program
    {
        public const string ConsoleMessage = "Please provide the prime table rank:";

        public static void Main(string[] args)
        {
            Console.Write(ConsoleMessage);
            var rank = Console.ReadLine();
        }
    }
}
