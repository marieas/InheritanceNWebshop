using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIntro
{
    public class Student : Person
    {
        public bool isDiciplined { get; set; }
        public Student(string name) : base(name)
        {
        }

        public override void Drink()
        {
            Console.WriteLine("i am drinking:) ");
        }

        public void Study()
        {

        }
    }
}
