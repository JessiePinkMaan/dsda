using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Computer
    {
        public CPU Processor { get; set; }
        public Motherboard Motherboard { get; set; }
        public RAM Memory { get; set; }
        public Storage Storage { get; set; }
        public GPU GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"Computer: {Processor.Model}, {Motherboard.Model}, {Memory.Size}GB RAM, {Storage.Size}GB {Storage.Type}, {GraphicsCard.Model}";
        }
    }
}
