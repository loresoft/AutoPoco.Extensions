using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class TimeSpanSource : DatasourceBase<TimeSpan>
    {
        private readonly TimeSpan _min;
        private readonly TimeSpan _max;
        private static readonly Random _random = new Random();
        
        public TimeSpanSource(TimeSpan min, TimeSpan max)
        {
            _min = min;
            _max = max;
        }

        public override TimeSpan Next(IGenerationContext context)
        {
            var range = (_max - _min).Ticks;
            var ticks = (long)(_random.NextDouble() * range);
            return _min.Add(TimeSpan.FromTicks(ticks));
        }
    }
}
