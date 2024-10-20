using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class GPU
    {
        public string Model { get; set; }
        public int Memory { get; set; }  

        public GPU(string model, int memory)
        {
            Model = model;
            Memory = memory;
        }
    }

}
