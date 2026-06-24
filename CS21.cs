using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Acronym: ");
            string a = Console.ReadLine().ToUpper();

            if( a == "CPU" )
                Console.WriteLine("Central Processing Unit");
            else if( a == "RAM" )
                Console.WriteLine("Random Access Memory");
            else if( a == "USB" )
                Console.WriteLine("Universal Serial Bus");
            else if( a == "PC" )
                Console.WriteLine("Personal Computer");
            else if( a == "GPU" )
                Console.WriteLine("Graphics Processing Unit");
            else if( a == "SSD" )
                Console.WriteLine("Solid-State Drive");
            else
                Console.WriteLine("Unknown Acronym");
        }
    }
}