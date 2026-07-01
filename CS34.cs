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
            int count = 0;

            do
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse( Console.ReadLine() );
                count++;
                if( guess != computer && count == 10 )
                {
                    Console.WriteLine("GAME OVER!");
                    Console.Beep(348, 1000);
                    Console.Beep(512, 1000);
                    break;
                }

                if( guess < computer )
                {
                    Console.WriteLine("Your number is SMALL");
                    Console.Beep(348, 1000);
                }
                else if( guess > computer )
                {
                    Console.WriteLine("Your number is LARGE");
                    Console.Beep(512, 1000);
                }
                else
                {
                    Console.WriteLine("RIGHT!");
                    Console.WriteLine("You guessed " + count + " time(s).");
                    Console.Beep(512, 500);
                    Console.Beep(640, 500);
                }
            } while( guess != computer );            
        }
    }
}