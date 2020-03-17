using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    public class Problem038
    {
        // What is the largest 1 to 9 pandigital 9-digit number that can be formed 
        // as the concatenated product of an integer with (1,2, ... , n) where n > 1?
        // Solution time = 00:00:00.0003654
        public int Solve()
        {
            return LargestConcatenatedProduct();
        }

        /* 
         * From example in problem we know first digit of our solution has to be a 9
         * it can't be a 2,3 or 5+ digits because that won't give us a 9 digit number or 
         * a 9 digit number starting with a 9, so it's 4 digits. It can't be greater than 9500 
         * as 95xx * 2 = 19xx, and it can't have an 8 or 1 in it since 9xxx * 2 = 18xx, 
         * so we only have to look between 9234 and 9476. Since its such a small space 
         * we don't need to bother removing any numbers that are are guarunteed to not 
         * work (contain a 9, 8, 1, 0, ends in 5, 4, etc) 
         */
        private int LargestConcatenatedProduct()
        {
            for (int i = 9476; i >= 9234; i--)
            {
                int num = i * 100000 + i * 2;
                if (IsPandigital(num)) return num; // guarunteed to be largest
            }

            return 918273645;
        }

        private bool IsPandigital(int num)
        {
            if (num < 123456789 || num > 987654321 || num % 9 != 0) return false;

            bool[] arr = new bool[10];
            for (int i = 0; i < 9; i++)
            {
                int digit = num % 10;
                if (arr[digit]) return false; // we've already had one
                arr[digit] = true;
                num /= 10;
            }

            return !arr[0]; // check for a zero
        }

    }
}
