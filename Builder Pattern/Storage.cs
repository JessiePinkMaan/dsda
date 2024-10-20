using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class Storage
    {
        public string Type { get; set; }  
        public int Size { get; set; }  

        public Storage(string type, int size)
        {
            Type = type;
            Size = size;
        }
    }
}
