using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructrure.DatabaseContext.Configurations;

public class TargetCategoryConfiguration : IEntityTypeConfiguration<TargetCategory>
{
    public void Configure(EntityTypeBuilder<TargetCategory> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(c => c.Description)
            .HasMaxLength(300);
    }
}