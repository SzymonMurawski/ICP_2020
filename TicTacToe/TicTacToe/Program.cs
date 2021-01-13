using System;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello. Welcome to Tic-Tac-Toe game");
            while (true)
            {
                RunMenu();
            }
        }

        private static void RunMenu()
        {
            Console.WriteLine("Please select an option:\n" +
                "1) Play game\n" +
                "2) About author\n" +
                "3) Exit\n");
            Console.Write("Choosen option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    PlayGame();
                    break;
                case "2":
                    ShowInfo();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("Some info");
        }

        private static void PlayGame()
        {
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
