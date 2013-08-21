using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class CompanyPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<CompanySource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x => String.Equals(x, "Company", StringComparison.OrdinalIgnoreCase) || String.Equals(x, "CompanyName", StringComparison.OrdinalIgnoreCase));
            requirements.Type(x => x == typeof(String));
        }
    }
}