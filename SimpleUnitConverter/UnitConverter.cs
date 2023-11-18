using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitConverter
{
    public abstract class UnitConverter
    {
        public enum Units { }

        public string Name { get; set; }

        public UnitConverter() { }

        public UnitConverter(string name)
        {
            Name = name;
        }

        public abstract double Convert(Units fromUnits, Units toUnits, double value);

        public abstract string[] GetUnitsAsStrings();

        public abstract Units GetStringsAsUnits(string s);
    }
}
