using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Infrastructure.Data.DataBaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data.Extensions
{
    public static class DataBaseExtension
    {
        public static async Task InitialyzeDataBaseAsync(this WebApplication app)
        {
            using IServiceScope scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            dbContext.Database.MigrateAsync().GetAwaiter().GetResult();

            await SeedData(dbContext);
        }

        private static async Task SeedData(ApplicationDbContext dbContext)
        {
            await SeedTopicsAsync(dbContext);
        }

        private static async Task SeedTopicsAsync(ApplicationDbContext dbContext)
        {
            if (!await dbContext.Topics.AnyAsync())
            {
                await dbContext.Topics.AddRangeAsync(InitialData.Topics);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}