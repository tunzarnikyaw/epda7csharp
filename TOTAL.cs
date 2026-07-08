using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int total = 0;
            for(int i=0; i<args.Length; i++){
                total += int.Parse(args[i]);
            }
            Console.WriteLine("Total is " + total);
        }
    }
}