namespace _13.ImplementQueue
{
    using System;
    using System.Linq;

    public class TestQueue
    {
        public static void Main(string[] args)
        {
            QueueImplementation testQueue = new QueueImplementation();
            testQueue.Enqueue(-111251);
            testQueue.Enqueue(152599);

            Console.WriteLine(testQueue);

            var element = testQueue.Dequeue();

            while (element != null)
            {
                Console.WriteLine(element);
                element = testQueue.Dequeue();
            }
        }
    }
}
