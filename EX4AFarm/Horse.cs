using System;
using System.Collections.Generic;
using System.Text;

namespace EX4AFarm
{
    public class Horse
    {

        public void Speak()
        {
            Console.WriteLine("Neigh");
        }

        public void Name(string name)
        {
            Console.WriteLine($"My name is {name} and I am a Horse!");
        }

        public void Product()
        {
            Console.WriteLine("I produce glue!");
        }

        public void Food()
        {
            Console.WriteLine("I eat hay!");
        }
        
    }
}
