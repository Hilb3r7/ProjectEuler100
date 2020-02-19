using System;
using System.Diagnostics;

namespace ProjectEuler100.Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            var answer = new Problem007().Solve(10001);

            sw.Stop();

            Console.WriteLine($"anser = {answer}; time = {sw.Elapsed}");

        }
    }
}
