using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Score: ");
            int score = int.Parse( Console.ReadLine() );

            if( score >= 40 )
                Console.WriteLine("PASS");
            else
                Console.WriteLine("FAIL");
            
        }
    }
}