using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIntro
{
    public class Teacher : Person
    {
        public bool Pedagogical { get; set; }

        public List<string> Subjects { get; set; }
        public Teacher(string name)  : base(name)
        {
        }
        public void Teach()
        {

        }
        public void Grade()
        {

        }

        public override void Drink()
        {
            Console.WriteLine("i am drinking:) ");
        }
    }
}
