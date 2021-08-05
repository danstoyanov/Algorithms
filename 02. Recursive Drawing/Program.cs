using System;

namespace _02._Recursive_Drawing
{
    public class Program
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var arr = new int[size];

            FigurePrint(arr, arr.Length);
        }

        static void FigurePrint(int[] arr, int index)
        {
            if (index == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', index));

            FigurePrint(arr, index - 1);

            Console.WriteLine(new string('#', index));
        }
    }
}
