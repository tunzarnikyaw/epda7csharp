using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            string s = "C Sharp Programming";
                    //  0123456789012345678

            Console.WriteLine( s );
            Console.WriteLine( s.ToUpper() ); // C SHARP PROGRAMMING
            Console.WriteLine( s.ToLower() ); // c sharp programming
            Console.WriteLine( s.Length );      // 19
            Console.WriteLine( s[0] );          // C          
            Console.WriteLine( s[11] );         // g
            Console.WriteLine( s.Substring(2, 5) ); // Sharp
            Console.WriteLine( s.Substring(8, 3) ); // Pro
            Console.WriteLine( s.IndexOf("Sharp") ); // 2
            Console.WriteLine( s.IndexOf("EPDA") ); // -1
            Console.WriteLine( s.IndexOf("a") ); // 4
            Console.WriteLine( s.IndexOf("a", 5) ); // 13
            Console.WriteLine( s.Contains("Java") ); // False
            Console.WriteLine( s.StartsWith("C") ); // True
            Console.WriteLine( s.EndsWith("ing") ); // True
            Console.WriteLine( s.Replace("a", "@") ); // C Sh@rp Progr@mming

            string t = " C Sharp Programming ";
            Console.WriteLine( t );             //  C Sharp Programming
            Console.WriteLine( "[" + t + "]");  // [ C Sharp Programming ]
            Console.WriteLine( "[" + t.Trim() + "]"); // [C Sharp Programming]

            Console.WriteLine( s == t );        // False
            Console.WriteLine( s == t.Trim() ); // True
            
        }
    }
}