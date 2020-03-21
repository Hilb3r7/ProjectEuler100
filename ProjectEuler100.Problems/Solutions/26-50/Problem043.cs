using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the sum of all 0 to 9 pandigital numbers with this property.
    // Soltution time = 00:00:00.0153908
    public class Problem043
    {
        // I solved this by hand, you can work out what most of the digits have to be.
        // You end up with xx30952867, xx06357289, and xx60357289, with {1,4} being left
        // in each case, so 6 numbers to add together. Decided to try and implement a solution
        // that solves it the same way, instead of just brute force
        public long Solve()
        {
            return GetSubDivisiblePandigitals().Sum();
        }

        // We create a set of all the possible numbers with the divisiblity property with
        // the number in the correct index. Then we create the next set of numbers that overlaps
        // with what we have. Any intersection that doesnt repeat digits creates a new valid possibility.
        // As we progress we are left with fewer and fewer possibilities.
        private List<long> GetSubDivisiblePandigitals()
        {
            var modulii = new int[] { 17, 13, 11, 7, 5, 3, 2 };
            var index = 7; // where d8d9d10 starts
            var pandigitals = new HashSet<int[]>();

            for (int i = 0; i < modulii.Length; i++)
            {
                var moduloSet = PopulateSet(modulii[i], index - i);
                pandigitals = IntersectSets(moduloSet, pandigitals, index - i + 1);
            }

            var subDivisibles = new List<long>();
            foreach (var pandigital in pandigitals)
            {
                GetFirstDigit(pandigital);
                subDivisibles.Add(ArrToLong(pandigital));
            }

            return subDivisibles;          
        }

        // creates an xxxxYYYxxx array with all possible valid 3 digit numbers for the appropriate substring
        private HashSet<int[]> PopulateSet(int modulus, int startIndex)
        {
            var dafuq = new HashSet<int[]>();

            for (int i = modulus; i < 1000; i += modulus)
            {
                if (!HasRepeatingDigits(i))
                {
                    var arr = new int[10];
                    arr[startIndex] = i / 100;
                    arr[startIndex + 1] = (i % 100) / 10;
                    arr[startIndex + 2] = i % 10;
                    dafuq.Add(arr);
                }
            }

            return dafuq;
        }

        // returns a set of all the valid combinations of the set with the single substring property and the 
        // set containing multiple valid substrings
        private HashSet<int[]> IntersectSets(HashSet<int[]> moduloSet, HashSet<int[]> pandigitals, int matchIndex)
        {
            if (pandigitals.Count == 0) return moduloSet; // we don't have any pandigitals yet 

            var intersections = new HashSet<int[]>();

            foreach (var pandigital in pandigitals)
            {
                foreach (var moduloArr in moduloSet)
                {
                    if (IsIntersection(moduloArr, pandigital, matchIndex) && HasUniqueIntegers(moduloArr, pandigital, matchIndex))
                    {
                        intersections.Add(CombineArrays(moduloArr, pandigital, matchIndex));
                    }
                }
            }

            return intersections;
        }

        private bool IsIntersection(int[] arr1, int[] arr2, int i)
        {
            return (arr1[i] == arr2[i] && arr1[i + 1] == arr2[i + 1]);
        }

        // Checks that the non overlapping digit in the modulo numer is not present
        // in the pandigital
        private bool HasUniqueIntegers(int[] moduloArr, int[] pandigital, int matchIndex)
        {
            int digit = moduloArr[matchIndex - 1];

            for (int i = matchIndex + 2; i < pandigital.Length; i++)
            {
                if (pandigital[i] == digit) return false;
            }

            return true;
        }

        private int[] CombineArrays(int[] moduloArr, int[] pandigital, int matchIndex)
        {
            var combined = (int[]) pandigital.Clone();
            combined[matchIndex - 1] = moduloArr[matchIndex - 1];

            return combined;
        }

        private bool HasRepeatingDigits(int num)
        {
            var digits = new HashSet<int>();
            for (int i = 0; i < 3; i++)
            {
                digits.Add(num % 10);
                num /= 10;
            }

            return digits.Count < 3;
        }

        // pandigitals sums to 45, so whatever we are short must be the first number
        private void GetFirstDigit(int[] arr)
        {
            arr[0] = 45 - arr.Sum();
        }

        private long ArrToLong(int[] arr)
        {
            long num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                num *= 10;
                num += arr[i];
            }

            return num;
        }

    }
}
