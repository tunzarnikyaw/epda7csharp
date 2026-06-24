using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the capital city of Japan?");
            Console.Write("Answer: ");
            string answer = Console.ReadLine();

            // if( answer == "Tokyo" || answer == "TOKYO" || answer == "tokyo" )
            // if( answer == "Naypyidaw" || answer == "Nay Pyi Taw" )
            if( answer.ToUpper() == "TOKYO" )
            {
                Console.WriteLine("Your answer is CORRECT!");
            }
            else
            {
                Console.WriteLine("Your answer is INCORRECT");
            }

        }
    }
}