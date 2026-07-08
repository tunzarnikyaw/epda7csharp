using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            List<int> evenNumberList = new List<int>();
            List<int> oddNumberList = new List<int>();

            for(int i=0; i<args.Length; i++)
            {
                if( int.Parse(args[i]) % 2 == 0 )
                {
                    // add to the evenNumberList
                    evenNumberList.Add( int.Parse(args[i]) );
                }
                else
                {
                    // add to the oddNumberList
                    oddNumberList.Add( int.Parse(args[i]) );
                }
            } // end for
            Console.Write("Even numbers are ");
            foreach(int n in evenNumberList)
                Console.Write( n + " ");
            Console.WriteLine();

            Console.Write("Odd numbers are ");
            foreach(int n in oddNumberList)
                Console.Write( n + " ");
            Console.WriteLine();

        }
    }
}   