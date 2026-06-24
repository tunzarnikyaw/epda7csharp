// C# Operator Precedence
using System;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int x = 5 + 2 * 3 / 3 - 4 * 11;
            //      5 +   6   / 3 - 4 * 11;
            //      5 +       2   - 4 * 11;
            //      5 +       2   -   44;
            //        7           -   44;
            //                    -37
            Console.WriteLine(x); // -37

        }
    }
}