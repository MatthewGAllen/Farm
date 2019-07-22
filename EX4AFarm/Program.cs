using System;

namespace EX4AFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse mrEd = new Horse();
             mrEd.Speak();
             mrEd.Name("Mr.Ed");
             mrEd.Product();
             mrEd.Food();
            
            

            Console.WriteLine();

            Cow Mary = new Cow();
            Mary.Speak();
            Mary.Name("Mary");
            Mary.Product();
            Mary.Food();

            Console.WriteLine();

            Pig Wilbur = new Pig();
            Wilbur.Speak();
            Wilbur.Name("Wilbur");
            Wilbur.Product();
            Wilbur.Food();

            Console.WriteLine();

            Sheep Dolly = new Sheep();
            Dolly.Speak();
            Dolly.Name("Dolly");
            Dolly.Product();
            Dolly.Food();
        }
    }
}
