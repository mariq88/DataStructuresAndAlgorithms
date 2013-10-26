using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapSackProblem
{
    class Program
    {
        static void Main()
        {
            Item[] items = {
                               new Item("Bira", 2, 4),
                               new Item("Bira", 2, 4),
                               new Item("Bira", 2, 4),
                               new Item("Bira", 2, 4),
                               new Item("Bira", 2, 4),
                               new Item("Laptop", 4, 1000),
                               new Item("TV", 10, 500),
                               new Item("Rakia", 2, 20),
                               new Item("Cheese", 5, 20),
                               new Item("Nuts", 1, 5)
                           };

            int sackMaxWeight = 10;
            List<Item> toTake = GetKnapsackItems(items, sackMaxWeight);

            PrintResultItemsList(toTake, sackMaxWeight);
        }

        private static void PrintResultItemsList(List<Item> toTake, int sackMaxWeight)
        {
            int weight = 0;
            int value = 0;
            Console.WriteLine("In knapsack with max weight={0} we are getting items:", sackMaxWeight);
            Console.WriteLine();

            foreach (Item item in toTake)
            {
                weight += item.Weight;
                value += item.Value;
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Items weight = {0}", weight);
            Console.WriteLine("Items value = {0}", value);
        }

        public static List<Item> GetKnapsackItems(Item[] items, int sackMaxWeight)
        {
            List<Item> result = new List<Item>();
            int[,] valuesTable = new int[items.Length, sackMaxWeight + 1];
            bool[,] toTake = new bool[valuesTable.GetLength(0), valuesTable.GetLength(1)];

            for (int w = 0; w <= sackMaxWeight; w++)
            {
                if (items[0].Weight <= w)
                {
                    valuesTable[0, w] = items[0].Value;
                    toTake[0, w] = true;
                }
            }

            for (int index = 1; index < items.Length; index++)
            {
                Item item = items[index];

                for (int w = 0; w <= sackMaxWeight; w++)
                {
                    if (item.Weight > w)
                    {
                        valuesTable[index, w] = valuesTable[index - 1, w];
                    }
                    else
                    {
                        int dW = w - item.Weight;
                        int newValue = item.Value + valuesTable[index - 1, dW];
                        if (valuesTable[index - 1, w] <= newValue)
                        {
                            valuesTable[index, w] = newValue;
                            toTake[index, w] = true;
                        }
                        else
                        {
                            valuesTable[index, w] = valuesTable[index - 1, w];
                        }
                    }
                }
            }

            int weight = sackMaxWeight;
            for (int index = items.Length - 1; index >= 0; index--)
            {
                if (toTake[index, weight])
                {
                    result.Add(items[index]);
                    weight -= items[index].Weight;
                }
            }

            return result;
        }
    }
}
