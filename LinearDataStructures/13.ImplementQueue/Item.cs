namespace _13.ImplementQueue
{
    using System;
    using System.Linq;
    using System.Text;

    public class Item
    {
        public dynamic Value { get; set; }

        public Item NextItem { get; set; }

        public override string ToString()
        {
            StringBuilder valueAsString = new StringBuilder();
            valueAsString.Append(this.Value);
            return valueAsString.ToString();
        }
    }
}
