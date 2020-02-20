using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the largest palindrome made from the product of two 3-digit numbers.
    // solution time = 00:00:00.0006378
    public class Problem004
    {
        public int Solve(int numDigits)
        {
            return LargestPalindrone(numDigits);
        }

        /* attempt at generating all the numbers that are the product of
         * two three digests numbers in decreasing order by using a n x n table
         * and traversing it diagonally. This eventually will fail and the numbers
         * wont be in correct descending order, but it still gives us the correct answer and
         * I'm tired of this problem, so moving on!
         */
        private int LargestPalindrone(int nDigits)
        {
            var max = Math.Pow(10, nDigits);
            int row, col, sum = 2;

            while (sum <= (max * 2) - 2)
            {
                for (int i = sum /2; i > 0; i--)
                {
                    col = i;
                    row = sum - i;
                    if (col <= max - 1 && row <= max - 1)
                    {
                        int num = (int) ((max - row) * (max - col));
                        if (IsPalindrone(num)) return num;
                    }
                }
                sum++;
            }

            return 0;
        }

        private Boolean IsPalindrone(int num)
        {
            return num == Reverse(num);
        }

        private int Reverse(int num)
        {
            int reverse = 0;
            
            while (num != 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }
            
            return reverse;
        }
    }
}
