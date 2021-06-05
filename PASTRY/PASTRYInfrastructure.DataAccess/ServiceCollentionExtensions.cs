using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PASTRYInfrastructure.DataAccess
{
    public static class ServiceCollentionExtensions
    {
        public static IServiceCollection SetupDataAccessInfrastructure([NotNull] this IServiceCollection services, string connectionString)
        {
            return services.AddDbContext<MvcCakeContext>(opt => opt.UseSqlServer(connectionString));
        }
    }
}
