using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.EFCoreContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["PostgresConnection:connectionString"];
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseNpgsql(connectionString,
                    optionsBuilder => optionsBuilder.MigrationsAssembly("SocialNetwork.DAL.Migrations"));
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Index");
                    options.ExpireTimeSpan = TimeSpan.FromHours(3);
                });
        }

        public static void ConfigureSharedServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
        }

    }
}
