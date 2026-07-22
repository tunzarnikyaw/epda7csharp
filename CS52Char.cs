using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            char x = 'A';
            Console.WriteLine( Char.IsLetter(x) ); // True
            Console.WriteLine( Char.IsDigit(x) );  // False
            Console.WriteLine( Char.IsUpper(x) );  // True
            Console.WriteLine( Char.IsLower(x) );  // False
            Console.WriteLine( Char.IsLetterOrDigit(x) ); // True

            char y = '1';
            Console.WriteLine( Char.IsLetter(y) ); // False
            Console.WriteLine( Char.IsDigit(y) );  // True
            Console.WriteLine( Char.IsUpper(y) );  // False
            Console.WriteLine( Char.IsLower(y) );  // False
            Console.WriteLine( Char.IsLetterOrDigit(y) ); // True

            char z = '!';
            Console.WriteLine( Char.IsLetter(z) ); // False
            Console.WriteLine( Char.IsDigit(z) );  // False
            Console.WriteLine( Char.IsUpper(z) );  // False
            Console.WriteLine( Char.IsLower(z) );  // False
            Console.WriteLine( Char.IsLetterOrDigit(z) ); // False
        }
    }
}