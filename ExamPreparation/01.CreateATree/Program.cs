using System;
using System.Linq;

namespace _01.CreateATree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //broq elementi, koito pro4itame

            var nodes = new Node<int>[n]; //dvoikite vhodni danni, za koito zadelqme pamet

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i); //syzdavame vsi4ki vurhove, koito sa razka4eni
            }
            for (int i = 1; i < n - 1; i++) // suzdavane na vruzkite v durvoto i e do n-1, za6toto vruzkite sa vinagi s 1 po-malko ot broq na node-te
            {
                string edgeAsString = Console.ReadLine();
                var edgeAsPart = edgeAsString.Split(' '); //4etem si vhodovete po dvoiki i splitvame, za suotvetnite 4isla po interval

                int parentID = int.Parse(edgeAsPart[0]); //1-to 4islo e roditelq po uslovie
                int childID = int.Parse(edgeAsPart[1]); //2-to 4islo e naslednik

                nodes[parentID].Children.Add(nodes[childID]); //zaka4ame roditelite i naslednicite v durvoto

            }

            var isChild = new bool[n];
        }
    }
}
