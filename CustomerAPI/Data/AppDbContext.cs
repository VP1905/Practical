using CustomerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustomerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customers> Customer { get; set; }
    }
}
