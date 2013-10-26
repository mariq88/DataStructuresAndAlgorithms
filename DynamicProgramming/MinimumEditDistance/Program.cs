using System;
using System.Linq;

namespace MinimumEditDistance
{
    class MinimumEditDistance
    {
        public const double InsertCost = 0.8;
        public const double DeleteCost = 0.9;
        public const double ReplaceCost = 1.0;

        static void Main()
        {
            string firstString = "developer";
            string secondString = "envelope";

            double cost = GetMinimumEditDistanceCost(firstString, secondString);
            Console.WriteLine("Minimum edit distance cost = {0}", cost);
        }

        /// <summary>
        /// Finding minimal cost for editing a string to become equal to another string
        /// For more info http://en.wikipedia.org/wiki/Levenshtein_distance
        /// </summary>
        /// <param name="firstString">The first string to edit</param>
        /// <param name="secondString">The string you aim to achive</param>
        /// <returns>The cost of editing</returns>
        public static double GetMinimumEditDistanceCost(string firstString, string secondString)
        {
            double[,] matrix = new double[firstString.Length + 1, secondString.Length + 1];

            for (int i = 1; i <= firstString.Length; i++)
            {
                matrix[i, 0] = i;
            }
            for (int i = 1; i <= secondString.Length; i++)
            {
                matrix[0, i] = i;
            }

            for (int i = 1; i <= firstString.Length; i++)
            {
                for (int j = 1; j <= secondString.Length; j++)
                {
                    double deletion = matrix[i - 1, j] + 1 * DeleteCost;
                    double insertion = matrix[i, j - 1] + 1 * InsertCost;
                    double replacing = matrix[i - 1, j - 1]
                        + (firstString[i - 1] == secondString[j - 1] ? 0 : 1) * ReplaceCost;

                    matrix[i, j] = Math.Min(replacing, Math.Min(insertion, deletion));
                }
            }

            return matrix[firstString.Length, secondString.Length];
        }
    }
}
