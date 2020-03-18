using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    public class Problem040
    {
        // If dn represents the nth digit of the fractional part, find the value of the following expression. 
        // d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
        // Solution time = 00:00:00.0007427
        public int Solve()
        {
            return ProductOfDSubNs();
        }

        private int ProductOfDSubNs()
        {
            int product = 1;
            for (int i = 1; i <= 1000000; i *= 10) product *= GetDSubN(i);

            return product;
        }

        private int GetDSubN(int digit)
        {
            int[] amounts = {0, 9, 180, 2700, 36000, 450000, 5400000 }; // number of digits in each order of 10

            int index = 0;
            while (amounts[index] < digit)
            {
                digit -= amounts[index];
                index++;
            }

            int nthNum = (digit - 1) / index; // the nth X digit number
            int number = (int) Math.Pow(10, index - 1) + nthNum; // The actual number
            int digitInNum = ((digit - 1) % index); // which 0indexed digit from L to R is the value

            return number.ToString().ToCharArray()[digitInNum] - '0';
        }

    }
}
