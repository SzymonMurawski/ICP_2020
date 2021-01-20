using System;

namespace OOPIntroduction
{
    class Program
    {
        // Ask the user for a name of a person, END to finish
        // After finish, display the list of users
        static void Main()
        {
            string[] People = new string[20];
            Console.WriteLine("Provide names of users, type END to finish and display this list");
            for(int i =0; i < People.Length; i++)
            {
                Console.WriteLine($"{i+1} Person: ");
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                People[i] = name;
            }
            for(int i = 0; i < People.Length; i++)
            {
                Console.WriteLine(People[i]);
            }
        }
    }
}
