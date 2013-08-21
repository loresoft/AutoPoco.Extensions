using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class CityPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<CitySource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x => String.Equals(x, "City", StringComparison.OrdinalIgnoreCase));
            requirements.Type(x => x == typeof(String));
        }
    }
}