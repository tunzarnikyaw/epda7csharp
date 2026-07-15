using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack size is " + stack.Count); // 3
            Console.WriteLine("Top of the stack is " + stack.Peek()); // 30

            while(stack.Count > 0)
                Console.WriteLine(stack.Pop()); // 30, 20, 10
        }
    }
}