using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoPoco.Configuration;
using AutoPoco.DataSources;

namespace AutoPoco.Conventions
{
    public class EmailPropertyConvention : ITypePropertyConvention
    {
        public void Apply(ITypePropertyConventionContext context)
        {
            context.SetSource<EmailSource>();
        }

        public void SpecifyRequirements(ITypeMemberConventionRequirements requirements)
        {
            requirements.Name(x => String.Equals(x, "EmailAddress", StringComparison.OrdinalIgnoreCase) || String.Equals(x, "Email", StringComparison.OrdinalIgnoreCase));
            requirements.Type(x => x == typeof(String));
        }
    }
}
