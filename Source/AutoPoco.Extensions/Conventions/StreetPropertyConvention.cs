using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class StreetPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<StreetSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x =>
                String.Equals(x, "Street", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "Street1", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "Address", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "Address1", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "AddressLine1", StringComparison.OrdinalIgnoreCase));

            requirements.Type(x => x == typeof(String));
        }
    }
}