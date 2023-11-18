using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitConverter
{
    public class LengthConverter : UnitConverter
    {
        public new enum Units
        {
            Kilometer,
            Meter,
            Centimeter,
            Millimeter,
            Micrometer,
            Nanometer,
            Mile,
            Yard,
            Foot,
            Inch,
            NauticalMile
        }

        public LengthConverter()
        {
            Name = "Length";
        }

        public LengthConverter(string name) : base(name) { }

        public override double Convert(UnitConverter.Units fromUnits, UnitConverter.Units toUnits, double value)
        {
            return 0;
        }

        public override string[] GetUnitsAsStrings()
        {
            string[] strings = new string[] {
                "Kilometer",
                "Meter",
                "Centimeter",
                "Millimeter",
                "Micrometer",
                "Nanometer",
                "Mile",
                "Yard",
                "Foot",
                "Inch",
                "NauticalMile" };

            return strings;
        }

        public override UnitConverter.Units GetStringsAsUnits(string s)
        {
            switch (s)
            {
                case "Kilometer":
                    return (UnitConverter.Units)Units.Kilometer;
                case "Meter":
                    return (UnitConverter.Units)Units.Meter;
                case "Centimeter":
                    return (UnitConverter.Units)Units.Centimeter;
                case "Millimeter":
                    return (UnitConverter.Units)Units.Millimeter;
                case "Micrometer":
                    return (UnitConverter.Units)Units.Micrometer;
                case "Nanometer":
                    return (UnitConverter.Units)Units.Nanometer;
                case "Mile":
                    return (UnitConverter.Units)Units.Mile;
                case "Yard":
                    return (UnitConverter.Units)Units.Yard;
                case "Foot":
                    return (UnitConverter.Units)Units.Foot;
                case "Inch":
                    return (UnitConverter.Units)Units.Inch;
                case "NauticalMile":
                    return (UnitConverter.Units)Units.NauticalMile;
                default:
                    return (UnitConverter.Units)Units.Kilometer;
            }
        }
    }
}
