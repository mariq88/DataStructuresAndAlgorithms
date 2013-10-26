using System;
using System.Linq;

namespace Recursion
{
    class RecursionNLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            GenerateAllCombinatins(0, array);
        }

        private static void GenerateAllCombinatins(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    GenerateAllCombinatins(index + 1, arr);
                }
            }
        }
    }
}
