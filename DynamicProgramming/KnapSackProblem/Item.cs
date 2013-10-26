using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapSackProblem
{
    class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, int weight, int value)
        {
            this.Name = name;
            this.Weight = weight;
            this.Value = value;
        }

        public override string ToString()
        {
            return String.Format("({0}: weight={1}, value={2})", this.Name, this.Weight, this.Value);
        }
    }
}
