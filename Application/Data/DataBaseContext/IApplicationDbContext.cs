using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Data.DataBaseContext
{
    public interface IApplicationDbContext
    {
        DbSet<Topic> Topics { get; }
    }
}