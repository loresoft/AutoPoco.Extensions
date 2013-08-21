using System;
using System.Globalization;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class EmailSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);
        private int _index;
        private readonly string _domain = "";

        public EmailSource() { }

        public EmailSource(string domain)
        {
            _domain = domain ?? "";
        }

        public override string Next(IGenerationContext context)
        {
            string name = PasswordSource.Generate(8);
            string domain = string.IsNullOrEmpty(_domain)
                ? _domains[_random.Next(0, _domains.Length)]
                : _domain.Trim();

            return string.Format("{0}{1}@{2}", name, _index++, domain);
        }

        private static readonly string[] _domains =
        {
            "gmail.com",
            "msn.com",
            "outlook.com",
            "hotmail.com",
            "aol.com",
            "yahoo.com"
        };
    }

    public class PhoneSource : DatasourceBase<String>
    {
        public const string DefaultFormat = "({0}) {1}-{2}";

        private static readonly Random _random = new Random();
        private readonly string _format;

        public PhoneSource()
            : this(DefaultFormat)
        { }

        public PhoneSource(string format)
        {
            _format = format ?? DefaultFormat;
        }


        public override string Next(IGenerationContext context)
        {
            string areaCode = _random.Next(100, 999).ToString(CultureInfo.InvariantCulture);
            string exchange = _random.Next(100, 999).ToString(CultureInfo.InvariantCulture);
            string number = _random.Next(1, 9999).ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');

            return string.Format(_format, areaCode, exchange, number);
        }

    }

}
