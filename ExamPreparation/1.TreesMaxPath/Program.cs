using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.TreesMaxPath
{
    class Program
    {
        static long maxSum = 0;
        static HashSet<Node> usedNodes = new HashSet<Node>();

        public static void DFS(Node node, long currentSum)
        {
            currentSum += node.Value;
            usedNodes.Add(node);

            for (int i = 0; i < node.NumberOfChildren; i++)
            {
                if (usedNodes.Contains(node.GetChild(i)))
                {
                    continue;
                }
                DFS(node.GetChild(i), currentSum);
            }

            if (node.NumberOfChildren == 1 && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, Node> nodes = new Dictionary<int, Node>();

            int maxNode = 0;

            for (int i = 0; i < n - 1; i++)
            {
                string connection = Console.ReadLine();

                
                string[] separatedConnection = connection.Split(
                    new char[] { '(', '<', '-', ')' }, StringSplitOptions.RemoveEmptyEntries);

                int parent = int.Parse(separatedConnection[0]);
                int child = int.Parse(separatedConnection[1]);

                Node parentNode;
                Node childNode;

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node(parent);
                    nodes.Add(parent, parentNode);
                }
                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node(child);
                    nodes.Add(child, childNode);
                }

                parentNode.AddChild(childNode);
                childNode.AddChild(parentNode);

                if (parent>maxNode)
                {
                    maxNode = parent;
                }

                if (child>maxNode)
                {
                    maxNode=child;
                }

            }

            foreach (var node in nodes)
            {
                if (node.Value.NumberOfChildren == 1)
                {
                    usedNodes.Clear();
                    DFS(node.Value, 0);
                }
            }

            Console.WriteLine(maxSum);
        }
    }
    public class Node
    {
        private int value;
        private List<Node> children;
        private bool hasParent;

        public Node(int value)
        {
            this.value = value;
            this.children = new List<Node>();
        }

        public int Value
        {
            get { return this.value; }
        }
        public int NumberOfChildren
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(Node child)
        {
            child.hasParent = true;
            children.Add(child);
        }

        public Node GetChild(int index)
        {
            return this.children[index];
        }
    }
}