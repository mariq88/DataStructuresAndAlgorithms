namespace _12.ImplementStack
{
    using System;
    using System.Linq;

    public class TestStack
    {
        public static void Main(string[] args)
        {
            StackImplementation<int> stack = new StackImplementation<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int[] stackToArray = stack.ToArray();
            for (int i = 0; i < stackToArray.Length; i++)
            {
                Console.Write(stackToArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(0));
            stack.Clear();
            Console.WriteLine(stack.Count);
        }
    }
}
