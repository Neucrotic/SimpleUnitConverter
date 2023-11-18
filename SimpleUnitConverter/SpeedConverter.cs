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

        public SpeedConverter()
        {
            Name = "Speed";
        }

        public SpeedConverter(string name) : base(name) { }

        public override double Convert(UnitConverter.Units fromUnits, UnitConverter.Units toUnits, double value)
        {
            switch (fromUnits)
            {
                case ((UnitConverter.Units)Units.KilometersPerHour):
                    switch (toUnits)
                    {
                        case (UnitConverter.Units)Units.FeetPerSecond:
                            return KilometersPHToFeetPS(value);
                        default:
                            return 1;
                    }
                default:
                    return 1;
            }
        }

        public override string[] GetUnitsAsStrings()
        {
            string[] strings = new string[] {
                "KilometersPerHour",
                "MilesPerHour",
                "FeetPerSecond",
                "Knots" };

            return strings;
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

        double KilometersPHToFeetPS(double kilometers)
        {
            return kilometers / 1.097;
        }
    }
}
