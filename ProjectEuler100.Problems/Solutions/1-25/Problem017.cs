using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // If all the numbers from 1 to 1000 (one thousand) inclusive were 
    // written out in words, how many letters would be used? 
    // Solution time = 00:00:00.0083249
    public class Problem017
    {
        public int Solve(int bound)
        {
            return GetTotalLetterCount(bound);
        }

        // Would be faster to not iterate over every number
        // since there is an obvious pattern, but I thought this way
        // was more fun.
        private int GetTotalLetterCount(int bound)
        {
            int total = 0;

            for (int i = 1; i <= bound; i++) total += GetNumLettersInNumber(i);

            return total;
        }

        private int GetNumLettersInNumber(int num)
        {
            int sum = 0;
            var dict = GetDict();

            if (num % 100 < 20)
            {
                sum += dict[num % 100];
            } else
            {
                sum += dict[num % 10];
                sum += dict[num % 100 - num % 10];
            }

            if (num > 99)
            {
                sum += dict[(num / 100) % 10];

                if (num % 100 == 0)
                {
                    if (num % 1000 != 0) sum += dict[100];

                }
                else sum += dict[100] + 3; // "and"
            }

            if (num > 999)
            {
                sum += dict[(num / 1000) % 10];
                sum += (num % 1000 == 0) ? dict[1000] : dict[1000] + 3; // "and"
            }

            return sum;
        }

        private Dictionary<int, int> GetDict()
        {
            return new Dictionary<int, int>
            {
                {0, 0}, {1, 3}, {2, 3}, {3, 5}, {4, 4}, {5, 4},
                {6, 3}, {7, 5}, {8, 5}, {9, 4}, {10, 3},
                {11, 6}, {12, 6}, {13, 8}, {14, 8}, {15, 7},
                {16, 7}, {17, 9}, {18, 8}, {19, 8}, {20, 6},
                {30, 6}, {40, 5}, {50, 5}, {60, 5}, {70, 7},
                {80, 6}, {90, 6}, {100, 7}, {1000, 8}
            };
        }
    }
}
