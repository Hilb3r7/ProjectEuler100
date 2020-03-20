using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Using words.txt a 16K text file containing nearly two-thousand 
    // common English words, how many are triangle words?
    // Solution time = 00:00:00.0190889
    public class Problem042
    {
        public int Solve()
        {
            return GetNumTriangleWords(ParseInput());
        }

        // Sums the letters of the words in a list and uses lookup table to check if word sum is traingle number
        private int GetNumTriangleWords(string[] words)
        {
            int count = 0;
            bool[] triangleVals = GetTriangleValues(391);  // 15 letter "ZZZ..." just guessing this will be enough

            foreach (var word in words)
            {
                if (triangleVals[word.Sum(x => x - 64)]) count++;
            }

            return count;
        }

        // creates a boolean array where triangle value indexes less than bound are true
        private bool[] GetTriangleValues(int bound)
        {
            var triangleVals = new bool[bound];
            int tn = 1;
            int diff = 2;
            while (tn < bound)
            {
                triangleVals[tn] = true;
                tn += diff;
                diff++;
            }

            return triangleVals;
        }

        private string[] ParseInput()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Problem42.txt");
            return File.ReadAllText(path).Replace("\"", "").Split(",");
        }

    }
}
