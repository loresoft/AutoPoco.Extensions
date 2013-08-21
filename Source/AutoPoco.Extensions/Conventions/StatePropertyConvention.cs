using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class StatePropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<StateSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x =>
                String.Equals(x, "State", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "StateProvidence", StringComparison.OrdinalIgnoreCase));

            requirements.Type(x => x == typeof(String));
        }
    }
}