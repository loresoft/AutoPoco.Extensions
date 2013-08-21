using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class WebsitePropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<WebsiteSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x =>
                String.Equals(x, "WebSite", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(x, "Url", StringComparison.OrdinalIgnoreCase));

            requirements.Type(x => x == typeof(String));
        }
    }
}