using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse( Console.ReadLine() );

            if( number > 0 )
            {
                Console.WriteLine("POSITIVE");
            }
            else
            {
                if( number < 0 )
                {
                    Console.WriteLine("NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ZERO");
                }
            }
        }
    }
}