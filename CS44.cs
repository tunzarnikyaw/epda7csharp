using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine( args );          // System.String[]
            Console.WriteLine( args.Length );   // ??

            for(int i=0; i<args.Length; i++){
                Console.WriteLine( args[i] );
            }
        }
    }
}