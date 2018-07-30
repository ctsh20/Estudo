using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicio
            Console.WriteLine("Hello World!");

            var s = "Good morning!";

            Console.WriteLine(s);

            Console.WriteLine($"Today is {Util.Data()}");
        }
    }
}
