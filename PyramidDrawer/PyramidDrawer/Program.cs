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

            for (int row = 0; row < height; row++)
            {
                int numberOfAsterikses = 2 * row + 1;
                int padding = height - row - 1;
                for (int i = 0; i < padding; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < numberOfAsterikses; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
