using System;

// Leap Year Calculator
// Developed by TZK
// 15-Jul-2026

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the year: ");
            year = int.Parse( Console.ReadLine() );

            if( year % 4 == 0 )
            {
                if( year % 100 == 0 )
                {
                    if( year % 400 == 0 )
                    {
                        Console.WriteLine("It is a leap year!");
                    }
                    else
                    {
                        Console.WriteLine("It is NOT a leap year!");
                    }
                }
                else
                {
                    Console.WriteLine("It is a leap year!");
                }
            }
            else
            {
                Console.WriteLine("It is NOT a leap year!");
            }
        }
    }
}