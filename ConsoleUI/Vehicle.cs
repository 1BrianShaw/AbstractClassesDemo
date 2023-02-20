using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 2010;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Corolla";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving a VEHICLE with a Virtual Method");
        }

    }
}
