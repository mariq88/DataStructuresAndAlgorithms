using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsInNeed
{
    public class Connection
    {
        public Node Node { get; set; }
        public long Distance { get; set; }

        public Connection(Node node, long distance)
        {
            this.Node = node;
            this.Distance = distance;
        }
    }
}
