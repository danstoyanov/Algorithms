using System;
using System.Linq;

namespace _3._Bubble_Sort
{
    public class BubbleSort
    {
        static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            BubbleSort(inputArr);
        }

        private static void BubbleSort(int[] inputArr)
        {

        }
    }
}
