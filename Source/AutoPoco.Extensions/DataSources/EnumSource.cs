using System;
using System.Collections.Generic;
using System.Linq;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class EnumSource<TEnum> : DatasourceBase<TEnum>
        where TEnum : struct, IConvertible
    {
        private static readonly Random _random = new Random();
        private List<TEnum> _values;

        public override TEnum Next(IGenerationContext context)
        {
            if (!typeof(TEnum).IsEnum)
                throw new ArgumentException("TEnum must be an enumerated type");

            if (_values == null)
                _values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();

            return _values.ElementAt(_random.Next(_values.Count()));
        }
    }
}
