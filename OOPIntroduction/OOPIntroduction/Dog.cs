using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntroduction
{
    public class Dog : INameable
    {
        public string Name;
        public Dog(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
