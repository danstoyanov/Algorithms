using System;
using System.Linq;

namespace _3._Bubble_Sort
{
    public class Bubble_Sort
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
            var isSorted = false;
            var i = 0;

            while (!isSorted)
            {
                isSorted = true;

                for (int j = 1; j < inputArr.Length - i; j++)
                {
                    if (inputArr[j - 1] > inputArr[j])
                    {
                        Swap(inputArr, j - 1, j);
                        isSorted = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputArr));
        }
        private static void Swap(int[] array, int currIndex, int minIndex)
        {
            var temp = array[currIndex];
            array[currIndex] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}
