using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveNegativeNumbers
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { -5, 5, 3, -9, 4, 10, -152, 15, -15263 };
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.Remove(numbers[i]);
            }
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}