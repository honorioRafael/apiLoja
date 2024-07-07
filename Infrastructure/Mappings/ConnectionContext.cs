using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandMap());
        }
        public DbSet<Brand> Brands { get; set; }
    }
}
