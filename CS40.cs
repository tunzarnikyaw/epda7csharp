using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            string[] fruits = {"apple", "mango", "orange", "kiwi", "watermelon"};

            // for(int i=0; i<fruits.Length; i++)
            // {
            //     Console.WriteLine( fruits[i] );
            // }

            foreach(string fruit in fruits)
            {
                Console.WriteLine( fruit );
            }
        }
    }
}