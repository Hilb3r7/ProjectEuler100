﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Utils
{
    public class EulerTools
    {

        public List<int> FirstNPrimes(int n)
        {
            int bound = (int) (n * (Math.Log(n) + Math.Log(Math.Log(n)))); // upper bound for the nth prime number
            return PrimeSieve(bound).Take(n).ToList();
        }

        public List<int> AllPrimesLessThan(int n)
        {
            return PrimeSieve(n);
        }

        private List<int> PrimeSieve(int size)
        {
            var primeList = new List<int>();
            var sieve = new Boolean[size + 1];
            var upper = Math.Sqrt(size);

            for (int i = 2; i < sieve.Length; i++)
            {
                if (!sieve[i])
                {
                    primeList.Add(i);
                    if (i <= upper)
                    {
                        for (int j = i * i; j < sieve.Length; j += i) sieve[j] = true;
                    }
                }
            }

            return primeList;
        }
    }
}