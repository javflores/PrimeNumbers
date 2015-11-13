using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers.BusinessLogic
{
    public class PrimeNumberGenerator : IPrimeNumberGenerator
    {
        private readonly List<int> _primes = new List<int>();

        public IEnumerator<int> GetEnumerator()
        {
            return GenerateNext().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerable<int> GenerateNext()
        {
            var currentValue = _primes.Count == 0
                ? 1
                : _primes[_primes.Count - 1];

            while (true)
            {
                //skip even numbers except 2
                var increment = (currentValue <= 2) ? 1 : 2;
                currentValue += increment;

                if (IsPrime(currentValue))
                {
                    _primes.Add(currentValue);
                }

                yield return _primes.Last();
            }
        }

        private bool IsPrime(int value)
        {
            return _primes
                .Select(prime => value%prime)
                .All(reminder => reminder != 0);
        }
    }
}
