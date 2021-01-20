using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntroduction
{
    public class Person : INameable
    {
        public string Name;
        public int Age;
        public string Address;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return $"Name: {Name}, age: {Age}";
        }
        public void AddOneYearToAge()
        {
            Age = Age + 1;
        }
    }
}
