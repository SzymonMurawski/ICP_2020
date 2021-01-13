using System;
using System.IO;

namespace StarshipLog
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to starship journal");
            while (true)
            {
                Console.WriteLine("Type start to begin loggin entries. Type exit to end the program");
                string input = Console.ReadLine();
                if (input == "start")
                {
                    LogEntries();
                } else if (input == "exit")
                {
                    Environment.Exit(0);
                }
            }
        }

        static void LogEntries()
        {
            Console.WriteLine("Your are now logging entries Captain. Type stop to finish");
            string path = "captains_log.txt";
            using (StreamWriter sr = File.Exists(path) ? File.AppendText(path) : new StreamWriter("captains_log.txt"))
            {
                sr.WriteLine($"Stardate {DateTime.Now}");
                while(true)
                {
                    string input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }
                    sr.WriteLine(input);
                }
                sr.WriteLine("\nCaptain");
            }
        }
    }
}
