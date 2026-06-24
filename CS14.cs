using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = int.Parse( Console.ReadLine() );

            if( number % 2 == 0 )
            {
                Console.WriteLine("Your number is EVEN");
            }
            else
            {
                Console.WriteLine("Your number is ODD");
            }
        }
    }
}