using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class PasswordPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<PasswordSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x =>
                String.Equals(x, "Password", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "UserPassword", StringComparison.OrdinalIgnoreCase));

            requirements.Type(x => x == typeof(String));
        }
    }
}