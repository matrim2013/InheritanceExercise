using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            {
                myBird.Legs = 2;
                myBird.Lifespan = 80;
                myBird.Color = "Red and Yellow";
                myBird.Diet = "Saltines";
                myBird.Flight = true;
                myBird.Species = "Parrot";
                myBird.Sound = "Caw";
                myBird.WingSpan = 14;
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile()
            {
                Legs = 4,
                Lifespan = 70,
                Color = "Black",
                Diet = "Birds",
                Group = "Crocodylidae",
                SkinType = "Scutes ",
                BirthMethod = "Eggs",
                Tail = true
            };


        }
    }
}
