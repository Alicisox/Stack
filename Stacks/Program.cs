using System;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
