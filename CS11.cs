// Logical Operators
using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine( true && true ); // true
            Console.WriteLine( true && false ); // false
            Console.WriteLine( false && false ); // false

            Console.WriteLine( true || true ); // true
            Console.WriteLine( true || false ); // true
            Console.WriteLine( false || false ); // false

            Console.WriteLine( !true ); // false
        }
    }
}