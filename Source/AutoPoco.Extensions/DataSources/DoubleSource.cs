using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class DoubleSource : DatasourceBase<double>
    {
        private readonly double _min;
        private readonly double _max;
        private readonly int? _decimals;
        private static readonly Random _random = new Random();

        public DoubleSource()
        {
            _min = double.MinValue;
            _max = double.MaxValue;
        }

        public DoubleSource(double min, double max)
        {
            _min = min;
            _max = max;
        }

        public DoubleSource(double min, double max, int decimals)
        {
            _min = min;
            _max = max;
            _decimals = decimals;
        }
        
        public override double Next(IGenerationContext context)
        {
            // Perform arithmetic in double type to avoid overflowing
            var range = _max - _min;
            var sample = _random.NextDouble();

            return _decimals == null ? (sample*range) + _min : Math.Round((sample*range) + _min, _decimals.Value);
        }
    }
}
