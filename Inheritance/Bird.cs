using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }


        public string Tail { get; set; }
        public int Legs { get; set; }
        public string Wings { get; set; }
        public bool HasBabies { get; set; }

        public string Fly()
        {
            return"is flying away";
        }



    }

}

// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class
