using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class DecimalPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<DecimalSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Type(x => x == typeof(decimal));
        }
    }
}