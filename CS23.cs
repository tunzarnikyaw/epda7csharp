using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int d = int.Parse( Console.ReadLine() );

            // if( d == 0 )
            //     Console.WriteLine("Your digit is ZERO");
            // else if( d == 1 )
            //     Console.WriteLine("Your digit is ONE");
            // else if( d == 2 )
            //     Console.WriteLine("Your digit is TWO");
            
            switch( d )
            {
                case 0: Console.WriteLine("Your digit is ZERO"); break;
                case 1: Console.WriteLine("Your digit is ONE"); break;
                case 2: Console.WriteLine("Your digit is TWO"); break;
                case 3: Console.WriteLine("Your digit is THREE"); break;
                case 4: Console.WriteLine("Your digit is FOUR"); break;
                case 5: Console.WriteLine("Your digit is FIVE"); break;
                case 6: Console.WriteLine("Your digit is SIX"); break;
                case 7: Console.WriteLine("Your digit is SEVEN"); break;
                case 8: Console.WriteLine("Your digit is EIGHT"); break;
                case 9: Console.WriteLine("Your digit is NINE"); break;
                default: Console.WriteLine("Please enter a single digit!"); break;
            }

        }
    }
}