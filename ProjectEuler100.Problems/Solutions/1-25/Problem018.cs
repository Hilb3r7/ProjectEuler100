using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Find the maximum total from top to bottom of the triangle below
    // Solution time = 00:00:00.0273440
    public class Problem018
    {
        public int Solve()
        {
            return MaxPathSum(ParseInput());
        }

        /* Starts at next to last row and for each element replaces its value
         * with its value added to largest of the two paths below it, and works its
         * way up. This results in the top containing the maximum value of the path
         * through the triangle 
         */
        private int MaxPathSum(List<List<int>> triangle)
        {
            var copy = DeepCopy(triangle);

            for (int i = copy.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < copy[i].Count; j++)
                {
                    copy[i][j] += Math.Max(copy[i + 1][j], copy[i + 1][j + 1]);
                }
            }

            return copy[0][0];
        }

        private List<List<int>> ParseInput()
        {
            var pyramid = new List<List<int>>();

            var path = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Problem18.txt");
            var input = File.ReadAllText(path).Split("\n");

            foreach (var line in input)
            {
                var x = line.Split(" ").Select(int.Parse).ToList();
                pyramid.Add(x);
            }

            return pyramid;
        }

        private List<List<int>> DeepCopy(List<List<int>> original)
        {
            var copy = new List<List<int>>(original.Count);

            original.ForEach(x => copy.Add(new List<int>(x)));

            return copy;
        }
    }
}
