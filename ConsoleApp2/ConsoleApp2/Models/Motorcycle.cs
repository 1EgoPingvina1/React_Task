using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; }
        public int Horsepower { get; }

        public Motorcycle(bool hasSidecar, int horsepower) : base(120, "Motorcycle")
        {
            HasSidecar = hasSidecar;
            Horsepower = horsepower;
        }
    }
}
