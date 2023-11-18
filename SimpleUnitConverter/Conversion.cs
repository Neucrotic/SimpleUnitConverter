using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitConverter
{
    public class Conversion
    {
        public string Name;
        public double Multiplier;

        public Conversion() { }
        public Conversion(string name, double multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }
    }
}
