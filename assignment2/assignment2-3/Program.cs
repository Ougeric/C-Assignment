using System;
using System.Collections.Generic;

namespace PrimeSieve
{
    public class PrimeFinder
    {
        public static List<int> FindPrimes(int max)
        {
            if (max < 2) return new List<int>();

            var flags = InitFlags(max);
            MarkNonPrimes(flags, max);
            return CollectPrimes(flags);
        }

        private static bool[] InitFlags(int size)
        {
            var flags = new bool[size + 1];
            Array.Fill(flags, true, 2, flags.Length - 2);
            return flags;
        }

        private static void MarkNonPrimes(bool[] flags, int max)
        {
            for (int n = 2; n * n <= max; n++)
            {
                if (flags[n]) MarkMultiples(flags, n, max);
            }
        }

        private static void MarkMultiples(bool[] flags, int prime, int max)
        {
            for (int m = prime * prime; m <= max; m += prime)
            {
                flags[m] = false;
            }
        }

        private static List<int> CollectPrimes(bool[] flags)
        {
            var primes = new List<int>();
            for (int n = 2; n < flags.Length; n++)
            {
                if (flags[n]) primes.Add(n);
            }
            return primes;
        }

        private static void PrintResult(List<int> primes)
        {
            Console.WriteLine($"2~100素数（共{primes.Count}个）：");
            Console.WriteLine(string.Join(" ", primes));
        }

        static void Main()
        {
            const int max = 100;
            PrintResult(FindPrimes(max));
        }
    }
}