using System;
using System.Linq;

namespace BinaryForms
{
    class BinaryPasswords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int unknownDigitsNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='*')
                {
                    unknownDigitsNumber++;
                }
            }
            long answer = 1;

            for (int i = 0; i < unknownDigitsNumber; i++)
            {
                answer *= 2;
            }
            Console.WriteLine(answer);
        }
    }
}
