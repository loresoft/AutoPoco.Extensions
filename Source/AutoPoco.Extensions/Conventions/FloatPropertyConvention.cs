using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class FloatPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<FloatSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Type(x => x == typeof(float));
        }
    }
}