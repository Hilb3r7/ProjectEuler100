using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Find the sum of all numbers which are equal to the sum of the factorial of their digits.
    // Solution time = 00:00:00.0146315
    public class Problem034
    {
        public int Solve()
        {
            return GetAllFactorialDigitSums();
        }

        private int GetAllFactorialDigitSums()
        {
            int[] factorials = GetFactorialArray();
            var sums = new HashSet<int>();
            GetFactorialSums(0, factorials, 7, 0, sums); // impossible for more than 7 digits

            return sums.Where(x => IsFactorialDigitSum(x, factorials)).Sum() - 3; // 2! and 1! not sums
        }

        // Instead of checking every number I check possible sum since there are fewer of those
        // than numbers. This is another "Stars and Bars" combinatorial problem like problem 30.
        // This adds every combination that can be made from num of digits leq digit to a set. There are dupes
        // because 0! = 1! (and the way I coded it to get all digits leq produces some) so a set is used.
        private void GetFactorialSums(int index, int[] factorials, int digits, int sum, HashSet<int> sums)
        {
            if (digits == 0 || index == factorials.Length) sums.Add(sum);
            else
            {
                for (int i = 0; i <= digits; i++)
                {
                    int tmp = factorials[index] * i;
                    GetFactorialSums(index + 1, factorials, digits - i, sum + tmp, sums);
                }
            }
        }

        private bool IsFactorialDigitSum(int num, int[] factorials)
        {
            int tmp = num;
            int total = 0;
            
            while (tmp > 0)
            {
                int digit = tmp % 10;
                total += factorials[digit];
                tmp /= 10;
            }

            return total == num;
        }

        private int[] GetFactorialArray()
        {
            var factorials = new int[10];
            for (int i = 0; i < 10; i++)
            {
                factorials[i] = Factorial(i);
            }

            return factorials;
        }

        private int Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;

            return n * Factorial(n - 1);
        }
    }
}
