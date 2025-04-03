using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Topics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITopicsService, TopicsService>();
            return services;
        }
    }
}