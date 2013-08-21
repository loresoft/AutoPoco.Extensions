using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class BooleanSource : DatasourceBase<bool>
    {
        private static readonly Random _random = new Random();

        public override bool Next(IGenerationContext context)
        {
            return _random.Next(2) == 1;
        }
    }
}
