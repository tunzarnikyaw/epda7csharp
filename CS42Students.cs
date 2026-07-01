using System;

namespace MyNamespace
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            string[] students = {
                "Myat Min Khant",
                "Lynn Hlyan Htet Naing",
                "Thike Shwe Sin",
                "Si Thu Lwin",
                "Thu Ta Htoo",
                "Than Yaw Zin",
                "Swam Ye Htet",
                "Min Hein Khant",
                "Kyaut Shinn Thant",
                "Hein Htet Zin",
                "Ye Yint Min Myat",
                "Pyae Phyo Aung",
                "Aung Kaung Pyae",
                "Pyae Pyae Thu",
                "Hlaing Phone Myat",
                "Toe Tet Aung",
                "Zin Wai Thaw",
                "Su Mon Soe",
                "Si Thu",
                "Wyne Maw Phoo",
                "Wine Su Hlaing",
                "Thura Lynn",
                "Nay Chi Htet Hlaing",
                "Saung Thansin Oo",
                "Khin San Win",
                "Ye Myint Mo",
                "Aung Min Khant",
                "Thu Kha Pyae Sone"
            };
            Random r = new Random();
            int c = r.Next( students.Length );

            Console.WriteLine("Today's lucky student is " + students[c] );
        }
    }
}