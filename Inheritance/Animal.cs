using System;
namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {


        }

        public int Weight { get; set; }
        public string Color  { get; set; }
        public string Name { get; set; }
        public bool IsDangerous { get; set; }


        public void Run()
        {
            Console.WriteLine("is running");
        }
    }
}



// Create a class Animal
// give this class 4 members that all Animals have in common
