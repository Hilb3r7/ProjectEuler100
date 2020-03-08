using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler100.Problems
{
    class Program
    {
        static void Main(string[] args) 
        {
            var sw = Stopwatch.StartNew();

            var answer = new Problem028().Solve(1001);

            sw.Stop();

            Console.WriteLine($"answer = {answer}; time = {sw.Elapsed}");

        }
    }
}
