using System;
using AutoPoco.Configuration;

namespace AutoPoco.Conventions
{
    public class GuidPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetValue(Guid.NewGuid());
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Type(x => x == typeof(Guid));
        }
    }
}