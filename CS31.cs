using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int n;
            do
            {
                n = r.Next(100);
                Console.WriteLine( n );
            }
            while( n != 24 );
        }
    }
}