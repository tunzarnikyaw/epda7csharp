// C# Arithmetic Operators

using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine( 10 + 3 ); // 13
            Console.WriteLine( 10 - 3 ); // 7
            Console.WriteLine( 10 * 3 ); // 30
            Console.WriteLine( 10 / 3 ); // 3
            Console.WriteLine( 10 % 3 ); // 1

            int x = 10;
            x++;
            Console.WriteLine(x); // 11
            x--;
            Console.WriteLine(x); // 10
        }
    }
}