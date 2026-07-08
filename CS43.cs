using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int total = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Total is " + total);
        }
    }
}