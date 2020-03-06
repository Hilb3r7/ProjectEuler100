using System;
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

        public long NChooseK(int n, int k)
        {
            if (k == 0) return 1;
            if (k > n / 2) return NChooseK(n, n - k);

            return n * NChooseK(n - 1, k - 1) / k;
        }

        // sigma(p^a) = (p^(a+1) - 1) / (p-1) and the function is multiplicative
        public int SumOfProperDivisors(int num)
        {
            //TODO: If number is big enough, get prime list and use GetPrimeFactorizatoin();
            var factorization = GetPrimeFactorizationNaively(num);
            int sum = 1;

            foreach (var prime in factorization.Keys)
            {
                sum *= (int)(Math.Pow(prime, factorization[prime] + 1) - 1) / (prime - 1);
            }

            return sum - num;
        }

        public int SumOfProperDivisors(int num, List<int> primes)
        {
            var factorization = GetPrimeFactorization(num, primes);
            int sum = 1;

            foreach (var prime in factorization.Keys)
            {
                sum *= (int)(Math.Pow(prime, factorization[prime] + 1) - 1) / (prime - 1);
            }

            return sum - num;
        }

        public Dictionary<int, int> GetPrimeFactorization(int num, List<int> primes)
        {
            var factorizaton = new Dictionary<int, int>();

            if (primes.BinarySearch(num) >= 0) factorizaton.Add(num, 1);
            else
            {
                int index = 0;
                while (num > 1 && primes[index] * primes[index] <= num)
                {
                    int power = 0;
                    while (num % primes[index] == 0)
                    {
                        num /= primes[index];
                        power++;
                    }

                    if (power > 0) factorizaton.Add(primes[index], power);
                    index++;
                }

                if (num != 1) factorizaton.Add(num, 1);
            }

            return factorizaton;
        }

        public Dictionary<int, int> GetPrimeFactorizationNaively(int num)
        {
            var factorizaton = new Dictionary<int, int>();
            int power = 0;

            while (num % 2 == 0)
            {
                power++;
                num /= 2;
            }
            if (power != 0) factorizaton.Add(2, power);

            for (int i = 3; i * i <= num; i += 2)
            {
                power = 0;
                while (num % i == 0)
                {
                    power++;
                    num /= i;
                }
                if (power != 0) factorizaton.Add(i, power);
            }

            if (num != 1) factorizaton.Add(num, 1);

            return factorizaton;
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
