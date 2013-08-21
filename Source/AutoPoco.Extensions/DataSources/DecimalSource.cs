using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class DecimalSource : DatasourceBase<decimal>
    {
        private static readonly Random _random = new Random();

        private readonly decimal _min;
        private readonly decimal _max;
        private readonly int? _decimals;

        public DecimalSource()
        {
            _min = decimal.MinValue;
            _max = decimal.MaxValue;
        }

        public DecimalSource(decimal min, decimal max)
        {
            _min = min;
            _max = max;
        }

        public DecimalSource(decimal min, decimal max, int decimals)
        {
            _min = min;
            _max = max;
            _decimals = decimals;
        }

        public override decimal Next(IGenerationContext context)
        {
            // Perform arithmetic in double type to avoid overflowing
            var range = (double)_max - (double)_min;
            var sample = _random.NextDouble();
            var scaled = (sample * range) + (double)_min;

            return _decimals == null ? (decimal) scaled : Math.Round((decimal) scaled, _decimals.Value);
        }
    }
}
