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

            List<INameable> LivingCreatures = new List<INameable>();

            LivingCreatures.Add(new Person("Szymon", 34));
            LivingCreatures.Add(new Person("Bill", 21));
            LivingCreatures.Add(new Person("John", 66));

            LivingCreatures.Add(new Dog("Rex"));
            LivingCreatures.Add(new Dog("Phil"));
            LivingCreatures.Add(new Dog("Azor"));

            Console.WriteLine("Names of peoples and dogs:");
            LivingCreatures.ForEach(elem => Console.WriteLine(elem.GetName())); //lambda function

        }
    }
}
