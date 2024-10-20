using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Motherboard
    {
        public string Model { get; set; }
        public string Socket { get; set; }

        public Motherboard(string model, string socket)
        {
            Model = model;
            Socket = socket;
        }
    }

}
