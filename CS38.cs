using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] asdfasdfasdf)
        {
            int x = 5;              // x is a variable
            Console.WriteLine( x ); // 5

            int[] y = {10, 20, 30}; // y is an array
            Console.WriteLine( y ); // System.Int32[]

            Console.WriteLine( y[0] );  // 10
            Console.WriteLine( y[1] );  // 20
            Console.WriteLine( y[2] );  // 30

            Console.WriteLine( y[3] );  // System.IndexOutOfRangeException: Index was outside the bounds of the array.
        }
    }
}