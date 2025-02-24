using System;
internal class Program
{
    static void Main()
    {
        Console.Write("输入第一个数字：");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("输入第二个数字：");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("输入运算符：");
        string op = Console.ReadLine();

        double res =
        op == "+" ? num1 + num2 :
        op == "-" ? num1 - num2 :
        op == "*" ? num1 * num2 :
        op == "/" ? (num2 != 0 ? num1 / num2 : double.NaN) :
        double.NaN;
        Console.WriteLine("结果：" + res);
    }
}
