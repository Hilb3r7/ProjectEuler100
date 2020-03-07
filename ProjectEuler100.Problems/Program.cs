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

            var answer = new Problem026().Solve(1000);

            sw.Stop();

            Console.WriteLine($"answer = {answer}; time = {sw.Elapsed}");

        }
    }
}
