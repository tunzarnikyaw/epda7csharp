using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine( i );
                if( i == 5 )
                    break;
            }
        }
    }
}