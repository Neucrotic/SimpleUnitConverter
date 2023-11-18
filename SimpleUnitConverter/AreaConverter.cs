using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitConverter
{
    public class AreaConverter : UnitConverter
    {
        public new enum Units
        {
            SQRKilometer,
            SQRMeter,
            SQRMile,
            SQRYard,
            SQRFoot,
            SQRInch,
            Hectar,
            Acre
        }

        public AreaConverter() : base()
        {
            Name = "Area";
        }

        public AreaConverter(string name) : base(name) { }

        public override double Convert(UnitConverter.Units fromUnits, UnitConverter.Units toUnits, double value)
        {
            return 0;
        }

        public override string[] GetUnitsAsStrings()
        {
            string[] strings = new string[] {
                "SQRKilometer",
                "SQRMeter",
                "SQRMile",
                "SQRYard",
                "SQRFoot",
                "SQRInch",
                "Hectar",
                "Acre" };

            return strings;
        }

        public override UnitConverter.Units GetStringsAsUnits(string s)
        {
            switch (s)
            {
                case "SQRKilometer":
                    return (UnitConverter.Units)Units.SQRKilometer;
                case "SQRMeter":
                    return (UnitConverter.Units)Units.SQRMeter;
                case "SQRMile":
                    return (UnitConverter.Units)Units.SQRMile;
                case "SQRYard":
                    return (UnitConverter.Units)Units.SQRYard;
                case "SQRFoot":
                    return (UnitConverter.Units)Units.SQRFoot;
                case "SQRInch":
                    return (UnitConverter.Units)Units.SQRInch;
                case "Hectar":
                    return (UnitConverter.Units)Units.Hectar;
                case "Acre":
                    return (UnitConverter.Units)Units.Acre;
                default:
                    return (UnitConverter.Units)Units.SQRKilometer;
            }
        }

        double SQRKilometersToSQRMeters(double value)
        {
            return 0;
        }
    }
}
