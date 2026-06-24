using System;

namespace NumberGuessingGame
{
    class Game
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int computer = r.Next(100) + 1;
            int guess;

            do
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse( Console.ReadLine() );

                if( guess < computer )
                {
                    Console.WriteLine("Your number is SMALL");
                }
                else if( guess > computer )
                {
                    Console.WriteLine("Your number is LARGE");
                }
                else
                {
                    Console.WriteLine("RIGHT!");
                }
            } while( guess != computer );
        } // end of Main()
    } // end of class
} // end of namespace