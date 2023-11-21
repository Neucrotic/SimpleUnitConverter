using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitConverter
{
    public class SpeedConverter : UnitConverter
    {
        public new enum Units
        {
            KilometersPerHour,
            MilesPerHour,
            FeetPerSecond,
            Knots
        }

        public SpeedConverter() : base()
        {
            Name = "Speed";

            conversions.Add((UnitConverter.Units)Units.KilometersPerHour, ConvertFromKilometersPerHour);
            conversions.Add((UnitConverter.Units)Units.MilesPerHour, ConvertFromMilesPerHour);
            conversions.Add((UnitConverter.Units)Units.FeetPerSecond, ConvertFromFeetPerSecond);
            conversions.Add((UnitConverter.Units)Units.Knots, ConvertFromKnots);
        }

        public override string[] GetAllUnitsAsStrings()
        {
            string[] strings = new string[] {
                "KilometersPerHour",
                "MilesPerHour",
                "FeetPerSecond",
                "Knots" };

            return strings;
        }

        public override string GetUnitAsString(UnitConverter.Units u)
        {
            switch (u)
            {
                case (UnitConverter.Units)Units.KilometersPerHour:
                    return "KilometersPerHour";
                case (UnitConverter.Units)Units.MilesPerHour:
                    return "MilesPerHour";
                case (UnitConverter.Units)Units.FeetPerSecond:
                    return "FeetPerSecond";
                case (UnitConverter.Units)Units.Knots:
                    return "Knots";
                default:
                    return "Conversion Error";
            }
        }

        public override UnitConverter.Units GetStringsAsUnits(string s)
        {
            switch (s)
            {
                case "KilometersPerHour":
                    return (UnitConverter.Units)Units.KilometersPerHour;
                case "MilesPerHour":
                    return (UnitConverter.Units)Units.MilesPerHour;
                case "FeetPerSecond":
                    return (UnitConverter.Units)Units.FeetPerSecond;
                case "Knots":
                    return (UnitConverter.Units)Units.Knots;
                default:
                    return (UnitConverter.Units)Units.KilometersPerHour;
            }
        }

        decimal ConvertFromKilometersPerHour(UnitConverter.Units units, decimal kilometers)
        {
            switch(units)
            {
                case (UnitConverter.Units)Units.MilesPerHour:
                    return kilometers / 1.609M;
                case (UnitConverter.Units)Units.FeetPerSecond:
                    return kilometers / 1.097M;
                case (UnitConverter.Units)Units.Knots:
                    return kilometers / 1.852M;
                default:
                    return 0;
            }
        }

        decimal ConvertFromMilesPerHour(UnitConverter.Units units, decimal miles)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.KilometersPerHour:
                    return miles * 1.609M;
                case (UnitConverter.Units)Units.FeetPerSecond:
                    return miles * 1.467M;
                case (UnitConverter.Units)Units.Knots:
                    return miles / 1.151M;
                default:
                    return 0;
            }
        }

        decimal ConvertFromFeetPerSecond(UnitConverter.Units units, decimal feet)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.KilometersPerHour:
                    return feet * 1.097M;
                case (UnitConverter.Units)Units.MilesPerHour:
                    return feet * 1.467M;
                case (UnitConverter.Units)Units.Knots:
                    return feet / 1.688M;
                default:
                    return 0;
            }
        }

        decimal ConvertFromKnots(UnitConverter.Units units, decimal knots)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.KilometersPerHour:
                    return knots * 1.852M;
                case (UnitConverter.Units)Units.MilesPerHour:
                    return knots * 1.151M;
                case (UnitConverter.Units)Units.FeetPerSecond:
                    return knots * 1.688M;
                default:
                    return 0;
            }
        }
    }
}
