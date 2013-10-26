using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SubsetOfStrings
{
    class SubsetOfStrings
    {
        static StringBuilder sb = new StringBuilder();

        public static void Main()
        {
            Console.WriteLine("Insert a number of combination elements k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a set of n strings separated by comma:");
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] arr = new string[k];
            GenerateAllCombinations(0, input.Length, arr, input);

            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb.ToString());
        }

        private static void GenerateAllCombinations(int index, int n, string[] arr, string[] input)
        {
            int start;
            if (index == arr.Length)
            {
                sb.Append("(");
                sb.Append(string.Join(" ", arr));
                sb.Append("), ");
            }
            else
            {
                if (index != 0)
                {
                    string str = arr[index - 1];
                    start = Array.IndexOf(input, str) + 1;
                }
                else
                {
                    start = 0;
                }

                for (int i = start; i < n; i++)
                {
                    arr[index] = input[i];
                    GenerateAllCombinations(index + 1, n, arr, input);
                }
            }
        }
    }
}
