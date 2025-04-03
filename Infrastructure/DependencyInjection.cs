using Application.Data.DataBaseContext;
using Infrastructure.Data.DataBaseContext;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("SqlLiteConnectionString");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(connection);
            });
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            return services;
        }
    }
}
