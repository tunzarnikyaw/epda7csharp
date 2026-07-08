using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            for(int i=0; i<args.Length; i++)
            {
                if( int.Parse(args[i]) % 2 == 0 )
                {
                    Console.WriteLine( args[i] + " is even")
                } 
                else 
                {
                    Console.WriteLine( args[i] + " is odd")
                }
            }
        }
    }
}   