using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = {10, 20, 77, 32, 45, 80, 12};

            Console.WriteLine( numbers[2] );    // 77
            Console.WriteLine( numbers[5] );    // 80
            // Console.WriteLine( numbers[7] );    // IndexOutOfRangeException

            for(int i=0; i<7; i++)
            {
                Console.WriteLine( numbers[i] );
            }
        }
    }
}