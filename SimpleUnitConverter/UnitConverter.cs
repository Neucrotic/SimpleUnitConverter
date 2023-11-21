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

        protected Dictionary<Units, Func<Units, decimal, decimal>> conversions = new();

        public UnitConverter() { }

        public decimal Convert(Units fromUnits, Units toUnits, decimal value)
        {

            // Check if the dictionary contains the specified unit
            if (conversions.TryGetValue(fromUnits, out var conversionFunction))
            {
                // Invoke the corresponding conversion function
                return conversionFunction(toUnits, value);
            }

            // Handle the case where the unit is not found
            throw new ArgumentException("Conversion not supported for the specified unit.", nameof(fromUnits));
        }

        public abstract string[] GetAllUnitsAsStrings();

        public abstract string GetUnitAsString(Units u);

        public abstract Units GetStringsAsUnits(string s);
    }
}
