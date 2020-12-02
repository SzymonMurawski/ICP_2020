using System;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            double x = 123;
            double remainder = x % 2;
            if (remainder == 0)
            {
                Console.WriteLine("Number is even");
            } else
            {
                Console.WriteLine("Number is odd");
            }

            if (remainder == 0)
                Console.WriteLine("asdfad");
            else
                Console.Write("Sadf");

            string[] fieldStates = new string[9];
            Console.Write("State of the first field: ");
            fieldStates[0] = Console.ReadLine();
            Console.Write("State of the second field: ");
            fieldStates[1] = Console.ReadLine();
            Console.Write("State of the third field: ");
            fieldStates[2] = Console.ReadLine();
            Console.Write("State of the fourth field: ");
            fieldStates[3] = Console.ReadLine();
            Console.Write("State of the fifth field: ");
            fieldStates[4] = Console.ReadLine();
            Console.Write("State of the sixth field: ");
            fieldStates[5] = Console.ReadLine();
            Console.Write("State of the seventh field: ");
            fieldStates[6] = Console.ReadLine();
            Console.Write("State of the eight field: ");
            fieldStates[7] = Console.ReadLine();
            Console.Write("State of the nine field: ");
            fieldStates[8] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($" {fieldStates[0]} | {fieldStates[1]} | {fieldStates[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldStates[3]} | {fieldStates[4]} | {fieldStates[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {fieldStates[6]} | {fieldStates[7]} | {fieldStates[8]}");
        }
    }
}
