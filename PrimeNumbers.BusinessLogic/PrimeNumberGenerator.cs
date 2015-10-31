using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.BusinessLogic
{
    public class PrimeNumberGenerator : IPrimeNumberGenerator
    {
        private readonly List<int> _primes = new List<int>();

        public PrimeNumberGenerator()
        {
        }

        public PrimeNumberGenerator(int start)
        {
            Initialize(start);
        }

        public int GenerateNext()
        {
            var currentValue = _primes.Count == 0 
                ? 1 
                : _primes[_primes.Count - 1];

            while (true)
            {
                //skip even numbers except 2
                var increment = (currentValue <= 2) ? 1 : 2;
                currentValue += increment;

                if (IsValuePrime(currentValue))
                {
                    _primes.Add(currentValue);
                    return currentValue;
                }
            }
        }

        private void Initialize(int end)
        {
            for (var i = 2; i <= end; i++)
            {
                if(IsValuePrime(i))
                    _primes.Add(i);
            }
        }

        private bool IsValuePrime(int value)
        {
            return _primes
                .Select(prime => value%prime)
                .All(reminder => reminder != 0);
        }
    }
}
