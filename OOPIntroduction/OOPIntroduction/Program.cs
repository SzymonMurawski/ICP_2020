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
            List<Person> People = new List<Person>();
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
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());
                People.Add(new Person(name, age));
            }
            People.ForEach(elem => Console.WriteLine($"Name: {elem.Name}, age: {elem.Age}")); //lambda function

        }
    }
}
