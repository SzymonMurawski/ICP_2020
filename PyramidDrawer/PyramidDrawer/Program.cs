using System;

namespace PyramidDrawer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to program that will draw a pyramid!");
            Console.Write("What should be the height of the pyramid? ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Drawing a pyramid of height {height}");
        }
    }
}
