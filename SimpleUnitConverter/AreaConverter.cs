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

            conversions.Add((UnitConverter.Units)Units.SQRKilometer, ConvertFromSQRKilometer);
            conversions.Add((UnitConverter.Units)Units.SQRMeter, ConvertFromSQRMeter);
            conversions.Add((UnitConverter.Units)Units.SQRMile, ConvertFromSQRMile);
            conversions.Add((UnitConverter.Units)Units.SQRYard, ConvertFromSQRYard);
            conversions.Add((UnitConverter.Units)Units.SQRFoot, ConvertFromSQRFoot);
            conversions.Add((UnitConverter.Units)Units.SQRInch, ConvertFromSQRInch);
            conversions.Add((UnitConverter.Units)Units.Hectar, ConvertFromHectar);
            conversions.Add((UnitConverter.Units)Units.Acre, ConvertFromAcre);
        }

        public override string[] GetAllUnitsAsStrings()
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

        public override string GetUnitAsString(UnitConverter.Units u)
        {
            switch(u)
            {
                case (UnitConverter.Units)Units.SQRKilometer:
                    return "SQRKilometer";
                case (UnitConverter.Units)Units.SQRMeter:
                    return "SQRMeter";
                case (UnitConverter.Units)Units.SQRMile:
                    return "SQRMile";
                case (UnitConverter.Units)Units.SQRYard:
                    return "SQRYard";
                case (UnitConverter.Units)Units.SQRFoot:
                    return "SQRFoot";
                case (UnitConverter.Units)Units.SQRInch:
                    return "SQRInch";
                case (UnitConverter.Units)Units.Hectar:
                    return "Hectar";
                case (UnitConverter.Units)Units.Acre:
                    return "Acre";
                default:
                    return "Conversion Error";
            }
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

        decimal ConvertFromSQRKilometer(UnitConverter.Units units, decimal sqrKilometers)
        {
            switch (units)
            {
                case (UnitConverter.Units)Units.SQRKilometer:
                    return 0;
                case (UnitConverter.Units)Units.SQRMeter:
                    return 0;
                case (UnitConverter.Units)Units.SQRMile:
                    return 0;
                case (UnitConverter.Units)Units.SQRYard:
                    return 0;
                case (UnitConverter.Units)Units.SQRFoot:
                    return 0;
                case (UnitConverter.Units)Units.SQRInch:
                    return 0;
                case (UnitConverter.Units)Units.Hectar:
                    return 0;
                case (UnitConverter.Units)Units.Acre:
                    return 0;
                default:
                    return 0;
            }
        }

        decimal ConvertFromSQRMeter(UnitConverter.Units units, decimal sqrMeters) { return 0; }

        decimal ConvertFromSQRMile(UnitConverter.Units units, decimal sqrMiles) { return 0; }

        decimal ConvertFromSQRYard(UnitConverter.Units units, decimal sqrYards) { return 0; }

        decimal ConvertFromSQRFoot(UnitConverter.Units units, decimal sqrFeet) { return 0; }

        decimal ConvertFromSQRInch(UnitConverter.Units units, decimal sqrInches) { return 0; }

        decimal ConvertFromHectar(UnitConverter.Units units, decimal hectars) { return 0; }

        decimal ConvertFromAcre(UnitConverter.Units units, decimal acres) { return 0; }
    }
}
