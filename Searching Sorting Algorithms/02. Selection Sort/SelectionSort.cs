using System;
using System.Linq;

namespace _02._Selection_Sort
{
    public class SelectionSort
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SelectArr(array);
        }

        private static void SelectArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                var currIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(array, currIndex, minIndex);
            }

            Console.WriteLine(string.Join(" ", array));
        }

        private static void Swap(int[] array, int currIndex, int minIndex)
        {
            var temp = array[currIndex];
            array[currIndex] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}
