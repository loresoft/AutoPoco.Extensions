using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class DateTimeSource : DatasourceBase<DateTime>
    {
        private static readonly Random _random = new Random();

        private readonly DateTime _min;
        private readonly DateTime _max;

        public DateTimeSource()
        {
            int year = DateTime.Now.Year;
            _min = new DateTime(year - 10, 1, 1);
            _max = new DateTime(year + 3, 1, 1);
        }

        public DateTimeSource(DateTime min, DateTime max)
        {
            _min = min;
            _max = max;
        }

        public override DateTime Next(IGenerationContext context)
        {
            var range = (_max - _min).Ticks;
            var ticks = (long)(_random.NextDouble() * range);
            return _min.AddTicks(ticks);
        }
    }
}
