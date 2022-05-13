using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIntro
{
    public abstract class Person
    {     
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"I am eating, and my name is {Name}");
        }

        public abstract void Drink();
    }
}
