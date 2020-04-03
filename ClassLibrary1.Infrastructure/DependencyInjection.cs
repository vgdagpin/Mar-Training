using ClassLibrary1.Application.Common.Interfaces;
using ClassLibrary1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ClassLibrary1.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ClassLibDbContext>(options =>
            {
                options.UseSqlServer
                    (
                        connectionString: configuration.GetConnectionString("ClassLib1DbConString")
                    );
            });

            service.AddScoped<IClassLibDbContext>(provider => provider.GetService<ClassLibDbContext>());
            service.AddScoped<DbContext>(provider => provider.GetService<ClassLibDbContext>());

            return service;
        }
    }
}
