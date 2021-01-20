using System;
using System.Collections.Generic;

namespace OOPIntroduction
{
    class Program
    {
        // Ask the user for a name of a person, END to finish
        // After finish, display the list of users
        static void Main()
        {
            List<string> PeopleList = new List<string>();
            Console.WriteLine("Provide names of users, type END to finish and display this list");
            int iterator = 1;
            while(true)
            {
                Console.Write($"{iterator++} Person: ");
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                PeopleList.Add(name);
            }
            PeopleList.ForEach(elem => Console.WriteLine(elem)); //lambda function
        }
    }
}
