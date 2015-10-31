using System;
using System.Collections.Generic;

namespace PrimeNumbers.BusinessLogic
{
    public class PrimeTableFactory : IPrimeTableFactory
    {
        private readonly IPrimeNumberGenerator _primeNumberGenerator;

        public PrimeTableFactory(IPrimeNumberGenerator primeNumberGenerator)
        {
            _primeNumberGenerator = primeNumberGenerator;
        }

        public PrimeTable Create(int rank)
        {
            if (rank < 1)
                throw new ArgumentException();

            var axis = GetTableAxis(rank);
            return new PrimeTable(axis);
        }

        private int[] GetTableAxis(int rank)
        {
            var primes = new List<int>();
            while (primes.Count < rank)
            {
                var prime = _primeNumberGenerator.GenerateNext();
                primes.Add(prime);
            }

            return primes.ToArray();
        }
    }
}
