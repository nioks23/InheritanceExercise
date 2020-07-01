using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public int Length { get; set; }
        public bool Venimous { get; set; }
        public string Eye { get; set; }

        public string Crawl()
        {
            return"is crawling";
        }
    }
}




// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class
