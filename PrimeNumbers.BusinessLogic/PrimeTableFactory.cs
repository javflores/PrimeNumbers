using System;
using System.Collections.Generic;
using System.Linq;

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
            return _primeNumberGenerator.Take(rank).ToArray();
        }
    }
}
