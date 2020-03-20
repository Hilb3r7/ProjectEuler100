using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // What is the largest n-digit pandigital prime that exists?
    // Solution time = 00:00:00.0145561
    public class Problem041
    {
        // My first approach generated all primes less than 987654322 and
        // starting at largest checked for first pandigital, this took 20 seconds.
        // This approach generates all 7 and 4 digit pandigitals (as only those can
        // potentially be prime and checks if they are prime.
        public int Solve()
        {
            return GetLargestPandigitalPrime();
        }

        // Generates every 7 and 4 digit permutation, but the space is so small
        // it's not worth optimizing to generate only potential primes
        private int GetLargestPandigitalPrime()
        {
            int[] sevenDigit = { 1, 2, 3, 4, 5, 6, 7 };
            int[] fourDigit = { 1, 2, 3, 4 };
            var perms = new List<int>();
            int largestPrime;

            // check 7 digit permutations
            GetAllNDigitPermutations(7, sevenDigit, perms);
            largestPrime = GetLargestPrime(perms);
            if (largestPrime != 0) return largestPrime;

            // none found, so check four digit
            perms.Clear();
            GetAllNDigitPermutations(4, fourDigit, perms);

            return GetLargestPrime(perms);
        }

        // Returns largest prime from a list of integers, or 0 if none found
        private int GetLargestPrime(List<int> perms)
        {
            var tools = new Utils.EulerTools();
            
            int largest = 0;
            foreach (var perm in perms)
            {
                int last = perm % 10;
                if (last == 1 || last == 3 || last == 7 || last == 9) // only way it can be prime
                {
                    if (tools.IsPrime(perm) && perm > largest) largest = perm;
                }
            }

            return largest;
        }

        // Uses Heaps Algorithm to generate all permutations of a N digit number
        private void GetAllNDigitPermutations(int k, int[] arr, List<int> perms)
        {
            if (k == 1)
            { 
                perms.Add(GetNumFromArray(arr));
            }
            else
            {
                GetAllNDigitPermutations(k - 1, arr, perms);

                for (int i = 0; i < k - 1; i++)
                {
                    if (k % 2 == 0)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[k - 1];
                        arr[k - 1] = tmp;
                    }
                    else
                    {
                        int tmp = arr[0];
                        arr[0] = arr[k - 1];
                        arr[k - 1] = tmp;
                    }

                    GetAllNDigitPermutations(k - 1, arr, perms);
                }
            }
        }

        private int GetNumFromArray(int[] digits)
        {
            int num = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                num *= 10;
                num += digits[i];
            }

            return num;
        }

    }
}
