using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    public class Problem039
    {
        // For which value of p ≤ 1000, is the number of solutions maximised?
        // Solution time = 00:00:00.0056482
        public int Solve(int bound)
        {
            return GetMaxSolutionsForPerim(bound);
        }

        private int GetMaxSolutionsForPerim(int bound)
        {
            var perims = NumSolutionsForPermiters(bound);

            int maxNumSolutions = 0;
            int maxPerim = 0;
            for (int i = 0; i < perims.Length; i += 2) // no odd perims
            {
                if (perims[i] > maxNumSolutions)
                {
                    maxNumSolutions = perims[i];
                    maxPerim = i;
                }
            }

            return maxPerim;
        }

        // Takes a primitive triple perimiter and multiplies it to get all perims values that
        // primitive will generate leq the bound
        private int[] NumSolutionsForPermiters(int bound)
        {
            int[] perims = new int[bound + 1];
            var primitives = GetAllPrimitiveTriples(bound / 2); // a + b > c via triangle inequality

            foreach (var primitive in primitives)
            {
                int perim = primitive[0] + primitive[1] + primitive[2];
                for (int i = perim; i <= bound; i += perim)
                {
                    perims[i]++;
                }
            }

            return perims;
        }

        // uses Berggren's ternery tree for pythagorean triples, bound on size of hypotenuse
        private List<int[]> GetAllPrimitiveTriples(int cBound)
        {
            var primitives = new List<int[]>();
            var nodes = new Stack<int[]>();
            nodes.Push(new int[] { 3, 4, 5 });

            while (nodes.Count != 0)
            {
                var node = nodes.Pop();
                if (node[2] < cBound)
                {
                    primitives.Add(node);
                    int a = node[0], b = node[1], c = node[2];
                    nodes.Push(new int[] { a - 2*b + 2*c, 2*a - b + 2*c, 2*a - 2*b + 3*c });
                    nodes.Push(new int[] { a + 2*b + 2*c, 2*a + b + 2*c, 2*a + 2*b + 3*c });
                    nodes.Push(new int[] { -a + 2*b + 2*c, -2*a + b + 2*c, -2*a + 2*b + 3*c});
                }
            }

            return primitives;
        }
    }
}
