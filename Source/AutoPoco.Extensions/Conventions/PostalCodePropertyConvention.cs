using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class PostalCodePropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<PostalCodeSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x => 
                String.Equals(x, "PostalCode", StringComparison.OrdinalIgnoreCase) || 
                String.Equals(x, "ZipCode", StringComparison.OrdinalIgnoreCase) || 
                String.Equals(x, "Zip", StringComparison.OrdinalIgnoreCase));

            requirements.Type(x => x == typeof(String));
        }
    }
}