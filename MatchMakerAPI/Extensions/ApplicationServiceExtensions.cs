using System;
using MatchMakerAPI.Data;
using MatchMakerAPI.Interfaces;
using MatchMakerAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MatchMakerAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            //for jwt tokens

            services.AddScoped<ITokenService, TokenService>();


            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }
            );

            return services;
        }
    }
}
