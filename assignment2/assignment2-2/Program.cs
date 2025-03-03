using System;
using System.Linq;

namespace ArrayStatistics
{
    public class ArrayStatisticsResult
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public double Average { get; set; }
        public int Sum { get; set; }
    }

    public class ArrayAnalyzer
    {
        public static ArrayStatisticsResult CalculateStatistics(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new ArrayStatisticsResult();
            }

            int max = nums[0];
            int min = nums[0];
            int sum = 0;

            foreach (int num in nums)
            {
                max = Math.Max(max, num);
                min = Math.Min(min, num);
                sum += num;
            }

            return new ArrayStatisticsResult
            {
                Max = max,
                Min = min,
                Sum = sum,
                Average = (double)sum / nums.Length
            };
        }

        private static int[] GetArrayInput()
        {
            while (true)
            {
                Console.Write("请输入整数数组（用逗号分隔）：");
                string input = Console.ReadLine();

                string[] parts = input.Split(',');
                int[] nums = new int[parts.Length];
                bool isValid = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i].Trim(), out nums[i]))
                    {
                        Console.WriteLine($"'{parts[i]}' 不是有效整数，请重新输入。");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    return nums;
                }
            }
        }

        private static void DisplayStatistics(ArrayStatisticsResult result)
        {
            Console.WriteLine("统计结果：");
            Console.WriteLine($"最大值：{result.Max}");
            Console.WriteLine($"最小值：{result.Min}");
            Console.WriteLine($"平均值：{result.Average:F2}");
            Console.WriteLine($"总和：{result.Sum}");
        }

        static void Main()
        {
            int[] nums = GetArrayInput();
            ArrayStatisticsResult result = CalculateStatistics(nums);
            DisplayStatistics(result);
        }
    }
}