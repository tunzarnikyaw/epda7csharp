using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int a = r.Next(10) + 1;
            int b = r.Next(10) + 1;

            Console.WriteLine(a + " + " + b + " = ?");
            Console.Write("Ansewr: ");
            string answer = Console.ReadLine();

            if( answer == (a + b).ToString() )
            {
                Console.WriteLine("RIGHT!");
            }
            else{
                Console.WriteLine("WRONG!");
            }
        }
    }
}