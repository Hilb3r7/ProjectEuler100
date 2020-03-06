using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    // time = 00:00:00.0055060
    public class Problem024
    {
        public string Solve(int nthPerm)
        {
            return GetNthLexographicPerm(nthPerm);
        }

        private string GetNthLexographicPerm(int nthPerm)
        {
            var factorials = new int[] { 362880, 40320, 5040, 720, 120, 24, 6, 2, 1};
            var digits = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var answer = "";

            foreach (var f in factorials)
            {
                int count = 0;
                while (f < nthPerm)
                {
                    nthPerm -= f;
                    count++;
                }

                answer += digits[count];
                digits.RemoveAt(count);
            }

            return answer + digits[0];
        }
    }
}
