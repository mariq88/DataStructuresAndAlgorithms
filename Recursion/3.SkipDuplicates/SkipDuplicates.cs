using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SkipDuplicates
{
    class SkipDuplicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            GenerateAllCombinations(0, n, array);
        }

        private static void GenerateAllCombinations(int index, int n, int[] array)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
            }
            else
            {
                int start = 1;

                if (index != 0)
                {
                    start = array[index - 1] + 1;
                }

                for (int i = start; i <= n; i++)
                {
                    array[index] = i;
                    GenerateAllCombinations(index + 1, n, array);
                }
            }
        }
    }
}
