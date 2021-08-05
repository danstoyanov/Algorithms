using System;

namespace _03._Generating_0_1_Vectors
{
    public class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var arr = new int[num];
            Generate(arr, 0); 
        }

        public static void Generate(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join("", arr));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                arr[index] = i;
                Generate(arr, index + 1);
            }
        }
    }
}
