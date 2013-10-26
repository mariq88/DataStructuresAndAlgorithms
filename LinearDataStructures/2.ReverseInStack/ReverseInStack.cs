using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseInStack
{
    public static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();
        Console.Write("Enter the number of the integers you want to add to the stack: ");
        int numbersCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbersCount; i++)
        {
            int input = int.Parse(Console.ReadLine());
            numbers.Push(input);
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}