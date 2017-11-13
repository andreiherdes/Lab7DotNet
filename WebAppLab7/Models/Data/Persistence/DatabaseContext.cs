using System;
using Microsoft.EntityFrameworkCore;
using WebAppLab7.Models.Data.Entities;

namespace WebAppLab7.Models.Data.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }

    }
}
