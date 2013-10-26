using System;
using System.Collections.Generic;
using System.Linq;

public class SortingIncreasingOrder
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == string.Empty)
            {
                break;
            }
            else
            {
                numbers.Add(int.Parse(input));
            }
        }

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
