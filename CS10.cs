// Assignment Operators
using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int x;  // declare variable - 'x'
            x = 10; // assign value 10 to 'x'
            Console.WriteLine(x); // 10

            x = x + 5;
            Console.WriteLine(x); // 15

            x = x * 5;
            Console.WriteLine(x); // 75

            x += 5;
            Console.WriteLine(x); // 80

            x -= 70;
            Console.WriteLine(x); // 10

            x *= 10;
            Console.WriteLine(x); // 100

            x /= 50;
            Console.WriteLine(x); // 2

            x %= 2;
            Console.WriteLine(x); // 0
        }
    }
}