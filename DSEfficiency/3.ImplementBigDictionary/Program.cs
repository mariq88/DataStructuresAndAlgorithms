using _03.ImplementBigDictionary;
using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var bidictionary = new BiDictionary<string, int, string>();

        bidictionary.Add("pesho", 1, "JavaScript");
        bidictionary.Add("gosho", 2, "Java");
        bidictionary.Add("nakov", 3, "C#");
        bidictionary.Add("gosho", 3, "Coffee");
        bidictionary.Add("nakov", 1, "Python");

        Console.WriteLine(bidictionary.Count);
    }
}