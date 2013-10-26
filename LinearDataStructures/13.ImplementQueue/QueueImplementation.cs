namespace _13.ImplementQueue
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;

    public class QueueImplementation : IEnumerable
    {
        public Item CurrentElement { get; set; }

        private Item firstElement;

        public QueueImplementation()
        {
            this.CurrentElement = null;
            this.firstElement = null;
        }

        public void Enqueue(object item)
        {
            Item currItem = new Item();
            currItem.Value = item;

            currItem.NextItem = this.CurrentElement;
            this.CurrentElement = currItem;
        }

        public Item Dequeue()
        {
            Item currElement = new Item();

            if (this.CurrentElement == null)
            {
                currElement = null;
            }
            else
            {
                currElement.Value = this.CurrentElement.Value;
                this.CurrentElement = this.CurrentElement.NextItem;
            }

            return currElement;
        }

        public IEnumerator GetEnumerator()
        {
            this.firstElement = this.CurrentElement;

            while (this.CurrentElement != null)
            {
                yield return this.CurrentElement.Value;
                this.CurrentElement = this.CurrentElement.NextItem;
            }

            this.CurrentElement = this.firstElement;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder queueAsString = new StringBuilder();

            foreach (var item in this)
            {
                queueAsString.AppendFormat("{0} ", this.CurrentElement.Value);
            }

            return queueAsString.ToString();
        }
    }
}
