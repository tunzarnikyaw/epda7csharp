using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Random x = new Random();
            int n;

            for(int i=1; i<=10; i++)
            {
                n = x.Next(100);
                Console.WriteLine( n );
            }

        }
    }
}