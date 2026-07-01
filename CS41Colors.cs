using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            string[] colors = {"white", "red", "blue", "orange", "cyan"};
            Random r = new Random();
            int c = r.Next( colors.Length );

            Console.WriteLine("Today's lucky color is " + colors[c] );
        }
    }
}