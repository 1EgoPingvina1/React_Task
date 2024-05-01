using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Bicycle : Vehicle
    {
        public int NumberOfGears { get; }

        public Bicycle(int numberOfGears) : base(20, "Bicycle")
        {
            NumberOfGears = numberOfGears;
        }
    }
}
