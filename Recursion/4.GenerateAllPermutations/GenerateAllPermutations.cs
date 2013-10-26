using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GenerateAllPermutations
{
    class GenerateAllPermutations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            GenerateAllCombinatins(0, n, array);
        }

        private static void GenerateAllCombinatins(int index, int n, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    bool checkNumber = true;
                    for (int j = 0; j < index; j++)
                    {
                        if (arr[j] == i)
                        {
                            checkNumber = false;
                        }
                    }
                    if (checkNumber)
                    {
                        arr[index] = i;
                        GenerateAllCombinatins(index + 1, n, arr);
                    }
                }
            }
        }
    }
}
