using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductBacklog.Api.Data.Entity.Type;
using System;

namespace ProductBacklog.Api.Data.Entity.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.RepositoryUrl).HasMaxLength(1000);
            builder.Property(x => x.ProjectUrl).HasMaxLength(1000);
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired().HasDefaultValue(DateTimeOffset.Now);

            builder.HasOne(x => x.ParentProject).WithMany(x => x.Subprojects).HasForeignKey(x => x.ParentProjectId);
        }
    }
}
