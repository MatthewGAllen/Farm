using System;
using System.Collections.Generic;
using System.Text;

namespace EX4AFarm
{
    class Cow
    {
        public void Speak()
        {
            Console.WriteLine("Moo");
        }
        public void Name(string name)
        {
            Console.WriteLine($"My name is {name} and I am a Cow!");
        }

        public void Product()
        {
            Console.WriteLine("I produce Beef!");
        }

        public void Food()
        {
            Console.WriteLine("I eat cattle feed!");
        }
    }
}
