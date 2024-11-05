using Microsoft.EntityFrameworkCore;
using property_management_api.Models;

namespace property_management_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
            modelBuilder.Entity<Property>().ToTable("Properties");
        }

        public DbSet<Property> Properties { get; set; }
    }
}
