using System;
using System.Collections.Generic;
using System.Linq;

public class CountMaxSequence
{
    public static List<int> MaxSequenceOfSameNumbers(List<int> numbers)
    {
        int currentNumber = 0;
        int length = 1;
        int maxLength = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                length++;
            }
            else
            {
                length = 1;
            }

            if (length > maxLength)
            {
                maxLength = length;
                currentNumber = numbers[i];
            }
        }

        List<int> maxSequence = new List<int>(maxLength);
        for (int i = 0; i < maxLength; i++)
        {
            maxSequence.Add(currentNumber);
        }

        return maxSequence;
    }

    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 2, 3, 5, 5, 7, 8, 10, 2, 2, 1, 5, 3, 2, 2, 5, 2, 10, 10, 10 };
        List<int> maxSequence = MaxSequenceOfSameNumbers(numbers);
        foreach (var item in maxSequence)
        {
            Console.WriteLine(item);
        }
    }
}
