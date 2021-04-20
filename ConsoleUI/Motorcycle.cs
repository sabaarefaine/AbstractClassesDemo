using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle Drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This Drive Virtual");
        }
    }
}
