using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("3 + 2 = ?");
            Console.Write("Ansewr: ");
            string answer = Console.ReadLine();

            if( answer == "5" )
            {
                Console.WriteLine("RIGHT!");
            }
            else{
                Console.WriteLine("WRONG!");
            }
        }
    }
}