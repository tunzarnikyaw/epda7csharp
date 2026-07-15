using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue size is " + queue.Count); // 3
            Console.WriteLine("Front of the queue is " + queue.Peek()); // 10

            while( queue.Count > 0 )
            {
                Console.WriteLine( queue.Dequeue() ); // 10, 20, 30
            }
        }
    }
}