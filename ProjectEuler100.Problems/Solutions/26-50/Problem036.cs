using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    public class Problem036
    {
        // Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        // Solution time = 00:00:00.0052046
        public int Solve(int bound)
        {
            return SumDualBasePalindrones(bound);
        }

        private int SumDualBasePalindrones(int bound)
        {
            int sum = 0;
            var palindrones = new List<int>();
            GetBinaryPalindrones(4, 0, 1000000, palindrones); // all odd lengths
            GetBinaryPalindrones(8, 0, 1000000, palindrones); // all even lengths

            palindrones.ForEach(x => { if (ReverseBase10Number(x) == x) sum += x; });

            return sum + 4; // Algorithm doesnt generate 1 and 3
        }

        // Algorithm that adds a "1" on either end of the binary number and adds it to list
        // or effectively sticks a zero on either end, and then flips all the bits and adds that number.
        // Then calls function on those 2 new numbers. This creates a tree that contains every odd or even 
        // digit binary palindrone depending on if powOfTwo is an even or odd power of two.
        private void GetBinaryPalindrones(int powOfTwo, int num, int bound, List<int> palindrones)
        {
            if (powOfTwo > bound) { }
            else
            {
                int shifted = num << 1;
                int num1 = powOfTwo + 1 + shifted;
                if (num1 < bound) palindrones.Add(num1);
                GetBinaryPalindrones(powOfTwo * 4, num1, bound, palindrones);
                int num2 = (powOfTwo * 2 - 1) ^ shifted;
                if (num2 < bound) palindrones.Add(num2);
                GetBinaryPalindrones(powOfTwo * 4, num2, bound, palindrones);
            }
        }

        private int ReverseBase10Number(int n)
        {
            int reverse = 0;

            while (n > 0)
            {
                int digit = n % 10;
                reverse *= 10;
                reverse += digit;
                n /= 10;
            }

            return reverse;
        }
    }
}
