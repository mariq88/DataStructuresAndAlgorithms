using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateATree
{
    class Node<T>
    {
        public T Value { get; set; }

        public List<Node<int>> Children { get; set; }

        public Node()
        {
            this.Children = new List<Node<int>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }

    }
}
