using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Evaluate the sum of all the amicable numbers under 10000.
    // Solution time = 00:00:00.0240443
    public class Problem021
    {
        public int Solve(int bound)
        {
            return GetAmicableNumbers(bound).Sum();
        }

        private List<int> GetAmicableNumbers(int bound)
        {
            var amicables = new List<int>();
            var primes = new Utils.EulerTools().AllPrimesLessThan(bound);

            for (int n = 2; n < bound; n++)
            {        
                int dofn = SumOfDivisors(GetPrimeFactorization(n, primes)) - n; // proper divisors of n 
                if (dofn > n && SumOfDivisors(GetPrimeFactorization(dofn, primes)) - dofn == n)
                {
                    amicables.Add(n);
                    if (dofn < bound) amicables.Add(dofn);
                } 
            }

            return amicables;
        }

        // sigma(p^a) = (p^(a+1) - 1) / (p-1) and the function is multiplicative
        private int SumOfDivisors(Dictionary<int, int> factorization)
        {
            int sum = 1;

            foreach (var prime in factorization.Keys)
            {
                sum *= (int)(Math.Pow(prime, factorization[prime] + 1) - 1) / (prime - 1);
            }

            return sum;
        }

        private Dictionary<int, int> GetPrimeFactorization(int num, List<int> primes)
        {
            var factorizaton = new Dictionary<int, int>();

            if (primes.BinarySearch(num) >= 0) factorizaton.Add(num, 1);
            else
            {
                int index = 0;
                while (num > 1 && primes[index] * primes[index] <= num)
                {
                    int power = 0;
                    while (num % primes[index] == 0)
                    {
                        num /= primes[index];
                        power++;
                    }

                    if (power > 0) factorizaton.Add(primes[index], power);
                    index++;
                }

                if (num != 1) factorizaton.Add(num, 1);
            }

            return factorizaton;
        }
    }
}
