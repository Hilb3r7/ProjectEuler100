using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    // Solution time = 00:00:00.5553753
    public class Problem023
    {
        public int Solve()
        {
            return SumOfNonTwoSumAbundants();
        }

        // subtacts all the numbers leq 28123 that can be written as the sum of two abundants, from the
        // sum of the first 28123 numbers, which leaves the sum of all the numbers that cant be written
        // as the sum of two abundants
        private int SumOfNonTwoSumAbundants()
        {
            var sumsOfTwoAbundants = new List<int>();
            var abundants = GetAbundantNumbers(28123);

            int index = 0;
            while (abundants[index] < 28123 / 2)
            {
                for (int j = index; j < abundants.Count; j++)
                {
                    sumsOfTwoAbundants.Add(abundants[index] + abundants[j]);
                }
                index++;
            }

            return 28123 * 28124 / 2 - sumsOfTwoAbundants.Distinct().Where(x => x <= 28123).Sum();
        }

        private List<int> GetAbundantNumbers(int bound)
        {
            var abundants = new List<int>();

            for (int i = 12; i < bound; i++)
            {
                if (IsAbundantNum(i)) abundants.Add(i);
            }

            return abundants;
        }

        private bool IsAbundantNum(int num)
        {
            return SumOfProperDivisors(num) > num;
        }

        private int SumOfProperDivisors(int num)
        {
            var factorization = GetPrimeFactorizationNaively(num);
            int sum = 1;

            foreach (var prime in factorization.Keys)
            {
                sum *= (int)(Math.Pow(prime, factorization[prime] + 1) - 1) / (prime - 1);
            }

            return sum - num;
        }

        private Dictionary<int, int> GetPrimeFactorizationNaively(int num)
        {
            var factorizaton = new Dictionary<int, int>();
            int power = 0;

            while (num % 2 == 0)
            {
                power++;
                num /= 2;
            }
            if (power != 0) factorizaton.Add(2, power);

            for (int i = 3; i * i <= num; i += 2)
            {
                power = 0;
                while (num % i == 0)
                {
                    power++;
                    num /= i;
                }
                if (power != 0) factorizaton.Add(i, power);
            }

            if (num != 1) factorizaton.Add(num, 1);

            return factorizaton;
        }
    }
}
