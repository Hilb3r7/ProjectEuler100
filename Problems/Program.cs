﻿using System;
using System.Diagnostics;

namespace ProjectEuler100.Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            var answer = new Problem006().Solve(100);

            sw.Stop();

            Console.WriteLine($"anser = {answer}; time = {sw.Elapsed}");

        }
    }
}