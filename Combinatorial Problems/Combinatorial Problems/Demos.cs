using System;
using System.Linq;

namespace Combinatorial_Problems
{
    public class Program
    {
        private static string[] currElements;
        private static int[] permutations;
        private static bool[] isValid;

        static void Main()
        {
             currElements = Console.ReadLine()
             .Split()
             .ToArray();

             permutations = new int[currElements.Length];
             isValid = new bool[currElements.Length];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if(index >= currElements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }
            
        }
    }
}
