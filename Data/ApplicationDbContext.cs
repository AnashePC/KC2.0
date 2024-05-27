using Microsoft.EntityFrameworkCore;
using KhumaloCraft02.Models;
using System.Collections.Generic;

namespace KhumaloCraft02.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}

