using System;

namespace Mynamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Score: ");
            int score = int.Parse( Console.ReadLine() );

            // Version 1
            if( score >= 80 )
            {
                Console.WriteLine("DISTINCTION");
            }
            else{
                if( score >= 40 )
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("FAIL");
                }
            }

            // Version 2
            if( score >= 40 )
            {
                if( score >= 80 )
                {
                    Console.WriteLine("DISTINCTION");
                }
                else
                {
                    Console.WriteLine("PASS");
                }
            }
            else
            {
                Console.WriteLine("FAIL");
            }

        }
    }
}