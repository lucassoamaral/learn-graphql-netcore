using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductBacklog.Api.Data.Entity.Type;

namespace ProductBacklog.Api.Data.Entity.Configuration
{
    public class RequirementConfiguration : IEntityTypeConfiguration<Requirement>
    {
        public void Configure(EntityTypeBuilder<Requirement> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(250);
            builder.Property(x => x.DetailedDescription).IsRequired();

            builder.HasOne(x => x.Project).WithMany(x => x.Requirements).HasForeignKey(x => x.ProjectId).IsRequired();
        }
    }
}
