using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; }

        public Car(int numberOfDoors) : base(150, "Car")
        {
            NumberOfDoors = numberOfDoors;
        }
    }
}
