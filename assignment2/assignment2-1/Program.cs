using System;
using System.Collections.Generic;

namespace PrimeFactorization
{
    public class PrimeFactorCalculator
    {
        public static List<int> GetPrimeFactors(int num)
        {
            List<int> factors = new List<int>();

            if (num <= 1)
            {
                return factors;
            }

            while (num % 2 == 0)
            {
                factors.Add(2);
                num /= 2;
            }

            for (int i = 3; i * i <= num; i += 2)
            {
                while (num % i == 0)
                {
                    factors.Add(i);
                    num /= i;
                }
            }

            if (num > 1)
            {
                factors.Add(num);
            }

            return factors;
        }

        private static int GetValidatedInput()
        {
            int num;
            do
            {
                Console.Write("请输入一个正整数：");
                string input = Console.ReadLine();
                if (int.TryParse(input, out num) && num > 0)
                {
                    return num;
                }
                Console.WriteLine("输入无效，请输入一个大于0的整数。");
            } while (true);
        }

        private static void DisplayResult(List<int> factors)
        {
            if (factors.Count == 0)
            {
                Console.WriteLine("该数字没有素数因子。");
                return;
            }

            Console.WriteLine("素数因子为：");
            Console.WriteLine(string.Join(" ", factors));
        }

        static void Main()
        {
            int num = GetValidatedInput();
            List<int> primeFactors = GetPrimeFactors(num);
            DisplayResult(primeFactors);
        }
    }
}
