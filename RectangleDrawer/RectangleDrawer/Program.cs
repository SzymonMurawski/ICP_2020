using System;

namespace RectangleDrawer
{
    class Program
    {
        // This program will print a rectangle filled with * of size specified by the user

        /*
         * TODO:
         * 1. DONE Read input x from the user
         * 2. DONE Read input y from the user
         * 3. DONE Print rectangle x*y 
         * 4. DONE Ask the user, for a string, that should be placed instead of '*' when printing rectangle
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of rectangle.");
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your rectangle is of size: {x} X {y}");
            Console.Write("Type the building block of a rectangle: ");
            string element = Console.ReadLine();
            
            // Loop for printing rows y times
            for (int j = 0; j < y; j++)
            {
                // Loop for printing a single row
                for (int i = 0; i < x; i++)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }
    }
}
