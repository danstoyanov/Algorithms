using System;
using System.Linq;

namespace _1_Recursive_Array_Sum
{
    public class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(CalcArr(arr, 0));
        }

        public static int CalcArr(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }

            return arr[index] + CalcArr(arr, index + 1);
        }
    }
}
