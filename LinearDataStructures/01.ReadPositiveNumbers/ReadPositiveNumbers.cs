using System;
using System.Collections.Generic;
using System.Linq;

public class ReadPositiveNumbers
{
    public static void Main(string[] args)
    {
        List<int> numbersEntered = new List<int>();
        while (true)
        {
            string numbers = Console.ReadLine();
            if (numbers == string.Empty)
            {
                break;
            }
            else
            {
                numbersEntered.Add(int.Parse(numbers));
            }
        }

        Console.WriteLine("The sum of the enetered elements is:" + numbersEntered.Sum());
        Console.WriteLine("The average of the enetered elements is: " + numbersEntered.Average());
    }
}
