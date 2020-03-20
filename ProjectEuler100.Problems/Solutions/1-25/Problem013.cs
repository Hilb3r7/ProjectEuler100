using System;
using System.IO;
using System.Numerics;

namespace ProjectEuler100.Problems
{
    // Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
    // Solution time = 00:00:00.0326251
    public class Problem013
    {
        public string Solve(int digits)
        {
            return GetFirstXDigits(digits);
        }

        private string GetFirstXDigits(int digits)
        {
            BigInteger sum = new BigInteger(0);
            var values = ParseInput();

            foreach (var v in values)
            {
                sum = BigInteger.Add(BigInteger.Parse(v), sum);
            }

            return sum.ToString().Substring(0, digits);
        }

        private string[] ParseInput()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Problem13.txt");
            return File.ReadAllText(path).Split(new[] { "\n" }, StringSplitOptions.None);
        }

    }
}
