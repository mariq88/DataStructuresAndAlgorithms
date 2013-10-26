using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Recursion___Crossword
{
    class Program
    {
        static HashSet<string> allWords = new HashSet<string>();
        static string[] words;
        static string[] crossword;

        static bool CheckVertical()
        {
            StringBuilder currentWord = new StringBuilder();
            for (int i = 0; i < crossword.Length; i++)
            {
                currentWord.Clear();
                for (int j = 0; j < crossword.Length; j++)
                {
                    currentWord.Append(crossword[j][i]);
                }
                if (!allWords.Contains(currentWord.ToString()))
                {
                    return false;
                }
            }
            return true;
        }


        static void Solver(int indexLine)
        {
            if (indexLine >= crossword.Length)
            {
                if (CheckVertical())
                {
                    Printer();
                    Environment.Exit(0);
                }
                return;
            }
            for (int i = 0; i < words.Length; i++)
            {
                crossword[indexLine] = words[i];
                Solver(indexLine + 1);
                crossword[indexLine] = null;
            }
        }

        static void Printer()
        {
            for (int i = 0; i < crossword.Length; i++)
            {
                Console.WriteLine(crossword[i]);
            }
        }

        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            words = new string[2 * n];
            crossword = new string[n];

            for (int i = 0; i < 2 * n; i++)
            {
                words[i] = Console.ReadLine();
                allWords.Add(words[i]);
            }

            Array.Sort(words);
            Solver(0);
            Console.WriteLine("NO SOLUTION!");
        }
    }
}
