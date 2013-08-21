using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class DoublePropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<DoubleSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Type(x => x == typeof(Double));
        }
    }
}