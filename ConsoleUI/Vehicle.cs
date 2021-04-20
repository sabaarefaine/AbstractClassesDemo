using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

        public int Year { get; set; } = 2016;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";

        public abstract void DriveAbstract(); //stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Base Drive Virtual");
        }
    }
}
