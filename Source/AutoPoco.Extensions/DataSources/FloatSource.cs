using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class FloatSource : DatasourceBase<float>
    {
        private readonly float _min;
        private readonly float _max;
        private readonly int? _decimals;
        private static readonly Random _random = new Random();

        public FloatSource()
        {
            _min = float.MinValue;
            _max = float.MaxValue;
        }

        public FloatSource(float min, float max)
        {
            _min = min;
            _max = max;
        }

        public FloatSource(float min, float max, int decimals)
        {
            _min = min;
            _max = max;
            _decimals = decimals;
        }
        
        public override float Next(IGenerationContext context)
        {
            // Perform arithmetic in double type to avoid overflowing
            var range = (double)_max - _min;
            var sample = _random.NextDouble();
            var scaled = (sample * range) + _min;

            return _decimals == null ? (float) scaled : (float) Math.Round(scaled, _decimals.Value);
        }
    }
}
