using System;
using System.IO;
using System.Linq;

// What is the total of all the name scores in the file?
// Solution time = 00:00:00.0385618
namespace ProjectEuler100.Problems
{
    public class Problem022
    {
        public int Solve()
        {
            return TotalNameScore(ParseInput());
        }

        public string[] ParseInput()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Problem22.txt");
            var names = File.ReadAllText(path).Replace("\"", "").Split(",");
            Array.Sort(names);

            return names;
        }

        public int TotalNameScore(string[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].ToCharArray().Sum(x => x - 64) * (i + 1);
            }

            return sum;
        }
    }
}
