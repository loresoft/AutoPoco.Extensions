using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoPoco.Configuration;
using AutoPoco.Conventions;

namespace AutoPoco
{
    public static class ConventionExtensions
    {
        public static void UseExtendedConventions(this IEngineConventionConfiguration configuration)
        {
            configuration.ScanAssemblyWithType<BooleanPropertyConvention>();
        }
    }
}
