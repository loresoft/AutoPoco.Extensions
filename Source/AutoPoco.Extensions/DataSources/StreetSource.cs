using System;
using System.Globalization;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class StreetSource : DatasourceBase<String>
    {
        private static readonly Random _random = new Random();

        public override string Next(IGenerationContext context)
        {
            string street = _streets[_random.Next(0, _streets.Length)];
            string number = _random.Next(10, 8000).ToString(CultureInfo.InvariantCulture);
            string suffix = _suffix[_random.Next(0, _suffix.Length)];

            return string.Format("{0} {1} {2}", number, street, suffix);
        }

        private static readonly string[] _suffix =
        {
            "AVE",
            "BLVD",
            "CTR",
            "CIR",
            "CT",
            "DR",
            "HWY",
            "LN",
            "PKWY",
            "ST"
        };

        private static readonly string[] _streets =
        {
            "Second", 
            "Third", 
            "First", 
            "Fourth", 
            "Park", 
            "Fifth", 
            "Main", 
            "Sixth", 
            "Oak", 
            "Seventh", 
            "Pine",
            "Maple", 
            "Cedar", 
            "Eighth", 
            "Elm", 
            "View", 
            "Washington", 
            "Ninth", 
            "Lake", 
            "Hill"
        };
    }
}
