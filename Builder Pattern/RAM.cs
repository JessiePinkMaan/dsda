using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class RAM
    {
        public string Model { get; set; }
        public int Size { get; set; } 

        public RAM(string model, int size)
        {
            Model = model;
            Size = size;
        }
    }

}
