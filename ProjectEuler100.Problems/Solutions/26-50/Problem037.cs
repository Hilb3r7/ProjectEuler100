using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
    // Solution time = 00:00:00.0397136
    public class Problem037
    {
        public int Solve()
        {
            return GetAllLeftRightTruncatablePrimes().Sum();
        }

        private List<int> GetAllLeftRightTruncatablePrimes()
        {
            var truncatables = new List<int>();
            var primes = new Utils.EulerTools().AllPrimesLessThan(1000000); // Just guessing
            var index = 0;

            while (index < primes.Count && truncatables.Count < 11)
            {
                int prime = primes[index];
                if (IsLeftTruncatablePrime(prime, primes) && IsRightTruncatablePrime(prime, primes))
                {
                    truncatables.Add(prime);
                }
                index++;
            }

            return truncatables;
        }

        private bool IsRightTruncatablePrime(int prime, List<int> primes)
        {
            if (prime < 10) return false;

            int divisor = 10;
            int bound = (int) Math.Pow(10, Math.Floor(Math.Log10(prime)));

            while (divisor <= bound)
            {
                if (primes.BinarySearch(prime / divisor) < 0) return false;
                divisor *= 10;
            }

            return true;
        }

        private bool IsLeftTruncatablePrime(int prime, List<int> primes)
        {
            if (prime < 10) return false;

            int modulus = (int) Math.Pow(10, Math.Ceiling(Math.Log10(prime)));

            while (modulus > 1)
            {
                if (primes.BinarySearch(prime % modulus) < 0) return false;
                modulus /= 10;
            }

            return true;
        }
    }
}
