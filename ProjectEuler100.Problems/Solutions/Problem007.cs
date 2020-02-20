using System;

namespace ProjectEuler100.Problems
{
    // What is the 10 001st prime number?
    // solution time = 00:00:00.0563085
    public class Problem007
    {
        public int Solve(int nth)
        {
            var primes = new Utils.EulerTools().FirstNPrimes(nth);

            return primes[nth - 1];
        }
    }
}
