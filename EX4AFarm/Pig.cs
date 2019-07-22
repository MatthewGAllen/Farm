using System;
using System.Collections.Generic;
using System.Text;

namespace EX4AFarm
{
    class Pig
    {
        public void Speak()
        {
            Console.WriteLine("Oink");
        }
        public void Name(string name)
        {
            Console.WriteLine($"My name is {name} and I am a Pig!");
        }

        public void Product()
        {
            Console.WriteLine("I produce bacon!");
        }

        public void Food()
        {
            Console.WriteLine("I eat anything!");
        }
    }
}
