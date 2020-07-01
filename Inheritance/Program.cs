using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            var tropicalBird = new Bird();

            tropicalBird.Color = "multicolor";
            tropicalBird.Name = "Mango";
            tropicalBird.Wings = "long";
            tropicalBird.Weight = 3;

            Console.WriteLine($"My bird is named {tropicalBird.Name} and {tropicalBird.Fly()}");


            var snake = new Reptile();

            snake.Name = "Bingo";
            snake.Length = 6;
            snake.Venimous = true;
            snake.Color = "green";

            Console.WriteLine($"I have a snake called {snake.Name} and is {snake.Length} feet long " + 
                $"oh and by the way has {snake.Color} color and {snake.Crawl()} in the backyard" );





            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
