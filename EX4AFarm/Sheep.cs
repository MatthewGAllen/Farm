using System;
using System.Collections.Generic;
using System.Text;

namespace EX4AFarm
{
    class Sheep
    {
        public void Speak()
        {
            Console.WriteLine("Bahhh");
        }
        public void Name(string name)
        {
            Console.WriteLine($"My name is {name} and I am a Sheep!");
        }

        public void Product()
        {
            Console.WriteLine("I produce gyros!");
        }

        public void Food()
        {
            Console.WriteLine("I eat grass!");
        }
    }
}
