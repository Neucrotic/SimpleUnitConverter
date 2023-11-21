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

        public TemperatureConverter() : base()
        {
            Name = "Temperature";

            conversions.Add((UnitConverter.Units)Units.Celsius, ConvertFromCelsius);
            conversions.Add((UnitConverter.Units)Units.Fahrenheit, ConvertFromFahrenheit);
            conversions.Add((UnitConverter.Units)Units.Kelvin, ConvertFromKelvin);
        }

        public override string[] GetAllUnitsAsStrings()
        {
            string[] strings = new string[] {
                "Celsius",
                "Fahrenheit",
                "Kelvin" };

            return strings;
        }

        public override string GetUnitAsString(UnitConverter.Units u)
        {
            switch (u)
            {
                case (UnitConverter.Units)Units.Celsius:
                    return "Celsius";
                case (UnitConverter.Units)Units.Fahrenheit:
                    return "Fahrenheit";
                case (UnitConverter.Units)Units.Kelvin:
                    return "Kelvin";
                default:
                    return "Conversion Error";
            }
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

        decimal ConvertFromCelsius(UnitConverter.Units units, decimal celsius)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.Fahrenheit:
                    return celsius * 1.8M + 32.0M;
                case (UnitConverter.Units)Units.Kelvin:
                    return celsius + 273.15M;
                default:
                    return 0;
            }
        }

        decimal ConvertFromFahrenheit(UnitConverter.Units units, decimal fahrenheit)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.Celsius:
                    return (fahrenheit - 32.0M) * 0.556M;
                case (UnitConverter.Units)Units.Kelvin:
                    return ((fahrenheit - 32.0M) * 0.556M) + 273.15M;
                default:
                    return 0;
            }
        }

        decimal ConvertFromKelvin(UnitConverter.Units units, decimal kelvin)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.Celsius:
                    return kelvin - 273.15M;
                case (UnitConverter.Units)Units.Fahrenheit:
                    return ((kelvin - 273.15M) * 1.8M) + 32.0M;
                default:
                    return 0;
            }
        }
    }
}
