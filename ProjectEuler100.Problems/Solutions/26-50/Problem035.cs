using System;
using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // How many circular primes are there below one million?
    // Solution time = 00:00:00.1146921
    public class Problem035
    {
        public int Solve(int bound)
        {
            return GetCircularPrimes(bound).Count;
        }

        private List<int> GetCircularPrimes(int bound)
        {
            var circulars = new List<int>();
            var primes = new Utils.EulerTools().AllPrimesLessThan(bound * 10);

            primes.ForEach(x => { if (x < bound && IsCircular(x, primes)) circulars.Add(x); });

            return circulars;
        }

        // Takes digits off from the front and puts them on the back
        private bool IsCircular(int prime, List<int> primes)
        {
            int numDigits = (int) Math.Ceiling(Math.Log10(prime));
            int pow10 = (int) Math.Pow(10, numDigits - 1);

            for (int i = 0; i < numDigits - 1; i++)
            {
                int digit = prime / pow10;
                if (digit % 2 == 0) return false;
                else
                {
                    prime *= 10;
                    prime = (prime + digit) % (pow10 * 10);
                    if (primes.BinarySearch(prime) < 0) return false;
                }
            }

            return true;
        }
    }
}
