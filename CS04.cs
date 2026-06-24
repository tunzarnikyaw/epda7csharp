using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse( Console.ReadLine() );
            Console.Write("Enter a number: ");
            int b = int.Parse( Console.ReadLine() );
            int c = a + b;
            Console.WriteLine("The sum is " + c);
        }
    }
}