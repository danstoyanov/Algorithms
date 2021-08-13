using System;
using System.Linq;

namespace _1._Permutations_without_Repetitions
{
    public class Program
    {
        public static string[] elements;
        public static string[] permutations;
        public static bool[] currElement;

        static void Main()
        {
            elements = Console
                .ReadLine()
                .Split()
                .ToArray();

            permutations = new string[elements.Length];
            currElement = new bool[elements.Length];

            Permute(0);
        }
        private static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int elementIndx = 0; elementIndx < elements.Length; elementIndx++)
            {
                if (!currElement[elementIndx])
                {
                    currElement[elementIndx] = true;
                    permutations[index] = elements[elementIndx];
                    Permute(index + 1);
                    currElement[elementIndx] = false;
                }
            }
        }
    }
}
