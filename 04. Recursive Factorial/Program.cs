using System;

namespace _04._Recursive_Factorial
{
    public class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialCalc(num));
        }

        public static int FactorialCalc(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * FactorialCalc(num - 1);
        }
    }
}
