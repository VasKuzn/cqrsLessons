using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Data.DataBaseContext;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.DataBaseContext
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Topic> Topics => Set<Topic>();

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}