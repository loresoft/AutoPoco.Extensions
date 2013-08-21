using System;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class PhonePropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<PhoneSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x => x.Contains("Phone") || x.Contains("Fax"));

            requirements.Type(x => x == typeof(String));
        }
    }
}