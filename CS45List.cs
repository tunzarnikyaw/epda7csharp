using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){10, 20, 30};

            Console.WriteLine( numbers );
            Console.WriteLine( numbers.Count ); // 3

            numbers.Add( 40 );
            numbers.Add( 50 );

            numbers.Remove( 30 );       // Delete 30 from the list
            numbers.RemoveAt( 0 );     // Delete the first element (10) from the list

            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine( numbers[i] );    // 20, 40, 50
            }

        }
    }
}