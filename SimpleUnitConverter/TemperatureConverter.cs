using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleUnitConverter
{
    public class TemperatureConverter : UnitConverter
    {
        public new enum Units
        {
            Celsius,
            Fahrenheit,
            Kelvin
        }

        public TemperatureConverter()
        {
            Name = "Temperature";
        }

        public TemperatureConverter(string name) : base(name) { }

        public override double Convert(UnitConverter.Units fromUnits, UnitConverter.Units toUnits, double value)
        {
            return 0;
        }

        public override string[] GetUnitsAsStrings()
        {
            string[] strings = new string[] {
                "Celsius",
                "Fahrenheit",
                "Kelvin" };

            return strings;
        }

        public override UnitConverter.Units GetStringsAsUnits(string s)
        {
            switch (s)
            {
                case "Celsius":
                    return (UnitConverter.Units)Units.Celsius;
                case "Fahrenheit":
                    return (UnitConverter.Units)Units.Fahrenheit;
                case "Kelvin":
                    return (UnitConverter.Units)Units.Kelvin;
                default:
                    return (UnitConverter.Units)Units.Celsius;
            }
        }
    }
}
