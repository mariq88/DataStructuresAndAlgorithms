using System;
using System.Linq;

public class CountTheOccurenceOFTheNumbers
{
    public static void Main(string[] args)
    {
        int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        var numbers = array.GroupBy(n => n);
        foreach (var number in numbers)
        {
            Console.WriteLine("{0} occures-> {1}times", number.Key, number.Count());
        }
    }
}