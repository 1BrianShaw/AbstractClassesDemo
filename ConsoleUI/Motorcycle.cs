using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a MOTORCYCLE with an abstract method");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a MOTORCYCLE with a virtual method");
        }

    }
}
