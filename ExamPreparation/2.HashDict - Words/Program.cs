using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.HashDict___Words
{
    class Program
    {
       static  Dictionary<char, HashSet<string>> wordsByCharDict = new Dictionary<char, HashSet<string>>();

        static void initDict()
        {
            for (char a = 'a'; a <= 'z'; a++)
            {
                wordsByCharDict[a] = new HashSet<string>();
            }
        }

        static void AddWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                wordsByCharDict[word[i]].Add(word);
            }
        }

        static void ReadWords()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                StringBuilder word = new StringBuilder();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] >= 'a' && input[j] <= 'z')
                    {
                        word.Append(input[j]);
                    }

                    else if (input[j] >= 'A' && input[j] <= 'Z')
                    {
                        word.Append((char)(input[j] - 'A' + 'a'));
                    }

                    else if (word.Length > 0)
                    {
                        AddWord(word.ToString());
                        word.Clear();

                    }

                }

                if (word.Length > 0)
                {
                    AddWord(word.ToString());

                }
            }
        }

        static void ProcessWords()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string wordToLower = word.ToLower();
                HashSet<string> current = new HashSet<string>(wordsByCharDict[wordToLower[0]]);

                for (int j = 1; j < wordToLower.Length; j++)
                {
                    current.IntersectWith(wordsByCharDict[wordToLower[j]]);
                }

                Console.WriteLine(word + " -> " + current.Count);
            }
        }

        static void Main(string[] args)
        {
            initDict();
            ReadWords();
            ProcessWords();
        }
    }
}