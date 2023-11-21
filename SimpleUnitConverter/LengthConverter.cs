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

        public LengthConverter() : base()
        {
            Name = "Length";

            conversions.Add((UnitConverter.Units)Units.Kilometer, ConvertFromKilometer);
            conversions.Add((UnitConverter.Units)Units.Meter, ConvertFromMeter);
            conversions.Add((UnitConverter.Units)Units.Centimeter, ConvertFromCentimeter);
            conversions.Add((UnitConverter.Units)Units.Millimeter, ConvertFromMillimeter);
            conversions.Add((UnitConverter.Units)Units.Micrometer, ConvertFromMicrometer);
            conversions.Add((UnitConverter.Units)Units.Nanometer, ConvertFromNanometer);
            conversions.Add((UnitConverter.Units)Units.Mile, ConvertFromMile);
            conversions.Add((UnitConverter.Units)Units.Yard, ConvertFromYard);
            conversions.Add((UnitConverter.Units)Units.Foot, ConvertFromFoot);
            conversions.Add((UnitConverter.Units)Units.Inch, ConvertFromInch);
            conversions.Add((UnitConverter.Units)Units.NauticalMile, ConvertFromNauticalMile);
        }

        public override string[] GetAllUnitsAsStrings()
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

        public override string GetUnitAsString(UnitConverter.Units u)
        {
            switch (u)
            {
                case (UnitConverter.Units)Units.Kilometer:
                    return "Kilometer";
                case (UnitConverter.Units)Units.Meter:
                    return "Meter";
                case (UnitConverter.Units)Units.Centimeter:
                    return "Centimeter";
                case (UnitConverter.Units)Units.Millimeter:
                    return "Millimeter";
                case (UnitConverter.Units)Units.Micrometer:
                    return "Micrometer";
                case (UnitConverter.Units)Units.Nanometer:
                    return "Nanometer";
                case (UnitConverter.Units)Units.Mile:
                    return "Mile";
                case (UnitConverter.Units)Units.Yard:
                    return "Yard";
                case (UnitConverter.Units)Units.Foot:
                    return "Foot";
                case (UnitConverter.Units)Units.Inch:
                    return "Inch";
                case (UnitConverter.Units)Units.NauticalMile:
                    return "NauticalMile";
                default:
                    return "Conversion Error";
            }
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

        decimal ConvertFromKilometer(UnitConverter.Units units, decimal kilometers)
        {
            switch(units)
            {
                case (UnitConverter.Units)Units.Kilometer:
                    return 0;
                case (UnitConverter.Units)Units.Meter:
                    return 0;
                case (UnitConverter.Units)Units.Centimeter:
                    return 0;
                case (UnitConverter.Units)Units.Millimeter:
                    return 0;
                case (UnitConverter.Units)Units.Micrometer:
                    return 0;
                case (UnitConverter.Units)Units.Nanometer:
                    return 0;
                case (UnitConverter.Units)Units.Mile:
                    return 0;
                case (UnitConverter.Units)Units.Yard:
                    return 0;
                case (UnitConverter.Units)Units.Foot:
                    return 0;
                case (UnitConverter.Units)Units.Inch:
                    return 0;
                case (UnitConverter.Units)Units.NauticalMile:
                    return 0;
                default:
                    return 0;
            }
        }

        decimal ConvertFromMeter(UnitConverter.Units units, decimal meters) { return 0; }

        decimal ConvertFromCentimeter(UnitConverter.Units units, decimal centimeters) { return 0; }

        decimal ConvertFromMillimeter(UnitConverter.Units units, decimal millimeters) { return 0; }

        decimal ConvertFromMicrometer(UnitConverter.Units units, decimal micrometers) { return 0; }

        decimal ConvertFromNanometer(UnitConverter.Units units, decimal nanometers) { return 0; }

        decimal ConvertFromMile(UnitConverter.Units units, decimal miles) { return 0; }

        decimal ConvertFromYard(UnitConverter.Units units, decimal yards) { return 0; }

        decimal ConvertFromFoot(UnitConverter.Units units, decimal feet) { return 0; }

        decimal ConvertFromInch(UnitConverter.Units units, decimal inches) { return 0; }

        decimal ConvertFromNauticalMile(UnitConverter.Units units, decimal nauticalMiles) { return 0; }
    }
}
