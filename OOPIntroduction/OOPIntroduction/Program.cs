using System;
using System.Collections.Generic;

namespace OOPIntroduction
{
    class Program
    {
        // Ask the user for a name and age of a person, END to finish
        // After finish, display the list of users with names
        static void Main()
        {
            List<string> PeopleList = new List<string>();
            List<int> PeopleAge = new List<int>();
            Console.WriteLine("Provide names and ages of users, type END to finish and display this list");
            int iterator = 1;
            while(true)
            {
                Console.Write($"{iterator++} Person: \n Name:");
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                PeopleList.Add(name);
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());
                PeopleAge.Add(age);
            }
            //PeopleList.ForEach(elem => Console.WriteLine(elem)); //lambda function
            for (int i = 0; i< PeopleList.Count; i++)
            {
                Console.WriteLine($"Name: {PeopleList[i]}, age: {PeopleAge[i]}");
            }
        }
    }
}
