// Area of Rectangle
using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of rectangle: ");
            int length = int.Parse( Console.ReadLine() );
            Console.Write("Enter the width of rectangle: ");
            int width = int.Parse( Console.ReadLine() );

            int area = length * width;
            Console.WriteLine("The area of rectangle is " + area);
        }
    }
}