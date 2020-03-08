﻿using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler100.Problems
{
    class Program
    {
        static void Main(string[] args) 
        {
            var sw = Stopwatch.StartNew();

            var answer = new Problem029().Solve(100, 100);

            sw.Stop();

            Console.WriteLine($"answer = {answer}; time = {sw.Elapsed}");

        }
    }
}
