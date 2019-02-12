using Microsoft.EntityFrameworkCore;
using ProductBacklog.Api.Data.Entity.Configuration;
using ProductBacklog.Api.Data.Entity.Type;

namespace ProductBacklog.Api.Data.Context
{
    public class ProductBacklogContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public DbSet<Requirement> Requirements { get; set; }

        public ProductBacklogContext(DbContextOptions<ProductBacklogContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new RequirementConfiguration());
        }
    }
}
