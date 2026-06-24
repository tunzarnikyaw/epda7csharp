using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            // 0-Rock, 1-Paper, 2-Scissors
            Console.WriteLine("0-Rock, 1-Paper, 2-Scissors");
            Console.Write("Your choice: ");
            int player = int.Parse( Console.ReadLine() );

            int computer = new Random().Next(3);
            if( computer == 0 ) Console.WriteLine("Computer plays ROCK");
            if( computer == 1 ) Console.WriteLine("Computer plays PAPER");
            if( computer == 2 ) Console.WriteLine("Computer plays SCISSORS");

            if( (player == 0 && computer == 1) || (player == 1 && computer == 2) || (player == 2 && computer == 0)){
                Console.WriteLine("Computer Wins!");
            }
            else if( (player == 0 && computer == 2) || (player == 1 && computer == 0) || (player == 2 && computer == 1)){
                Console.WriteLine("Player Wins!");
            }
            else{
                Console.WriteLine("Draw!");
            }
        }
    }
}