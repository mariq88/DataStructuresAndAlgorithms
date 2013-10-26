using System;
using System.Linq;
using System.Text;

namespace _5.OrderedElements
{
    class OrderedElements
    {
        static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a set of n strings separated by comma:");
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] array = new string[k];
            GenerateAllCombinations(0, input.Length, array, input);

            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb.ToString());
        }

        private static void GenerateAllCombinations(int index, int n, string[] array, string[] input)
        {
            if (index == array.Length)
            {
                sb.Append("(");
                sb.Append(string.Join(" ", array));
                sb.Append("), ");
            }
            else
            {

                for (int i = 0; i < n; i++)
                {
                    array[index] = input[i];
                    GenerateAllCombinations(index + 1, n, array, input);
                }
            }
        }
    }
}
