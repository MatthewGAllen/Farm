using System;

namespace EX4AFarm
{
    //Created By: Matthew Allen
    //For: ISTA 220 Exercise 4A
    //On: July 22, 2019

    /* The purpose of this program is to get more familiar with using instances of classes.
     * I created four animals and gave them methods of Speak, Name, Product, and Food. The Name method in each class takes
     in one string argument that it uses to print the name of the animal. */
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
