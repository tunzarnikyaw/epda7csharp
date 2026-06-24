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
            if( score == 100 )
            {
                Console.WriteLine("A*");
            }
            else
            {
                if( score >= 80 )
                {
                    Console.WriteLine("A");
                }
                else
                {
                    if( score >= 60 )
                    {
                        Console.WriteLine("B");
                    }
                    else
                    {
                        if( score >= 40 )
                        {
                            Console.WriteLine("C");
                        }
                        else
                        {
                            Console.WriteLine("D/Fail");
                        }
                    }
                }
            }

            // Version 2
            if( score == 100 )
                Console.WriteLine("A*");
            else if( score >= 80 )
                    Console.WriteLine("A");
                else if( score >= 60 )
                        Console.WriteLine("B");
                    else if( score >= 40 )
                            Console.WriteLine("C");
                        else
                            Console.WriteLine("D/Fail");

        }
    }
}