using System;
using System.Linq;
using System.Collections.Generic;

namespace FriendOfPesho
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ');

            int points = int.Parse(n[0]);
            int streets = int.Parse(n[1]);
            int hospitals = int.Parse(n[2]);

            string[] allHospitals = Console.ReadLine().Split(' ');

            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            for (int i = 0; i < streets; i++)
            {
                string[] currentStreet = Console.ReadLine().Split(' ');
                int firstNode = int.Parse(currentStreet[0]);
                int secondNode = int.Parse(currentStreet[1]);
                int distance = int.Parse(currentStreet[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }

                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node firstNodeObject = allNodes[firstNode];

                Node secondNodeObject = allNodes[secondNode];

                if (!graph.ContainsKey(firstNodeObject)) //proverka dali 1-q vruh e v grafa, ako ne e go dobavqme
                {
                    graph.Add(firstNodeObject, new List<Connection>());
                }

                if (!graph.ContainsKey(secondNodeObject)) //proverka dali 2-riq vruh e v node-a, ako ne e , go dobavqme
                {
                    graph.Add(secondNodeObject, new List<Connection>());
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));   // Dvuposo4nite vruzki
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));   // 

            }

            for (int i = 0; i < allHospitals.Length; i++)
            {

                int currentHospital = int.Parse(allHospitals[i]);

                allNodes[currentHospital].IsHospital = true;
            }

            long result = long.MaxValue;


            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospital = int.Parse(allHospitals[i]);

                DijkstraAlgorithm(graph, allNodes[currentHospital]);

                long tempSum = 0;

                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSum += node.Value.DijkstraDistance;
                    }
                }
                if (tempSum < result)
                {
                    result = tempSum;
                }
            }
            Console.WriteLine(result);
        }

        static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }
            source.DijkstraDistance = 0;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + connection.Distance;

                    if (potDistance < connection.Node.DijkstraDistance)
                    {
                        connection.Node.DijkstraDistance = potDistance;
                        queue.Enqueue(connection.Node);
                    }
                }
            }
        }
    }
}
