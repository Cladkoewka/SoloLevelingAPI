using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructrure.DatabaseContext.Configurations;

public class TargetConfiguration : IEntityTypeConfiguration<Target>
{
    public void Configure(EntityTypeBuilder<Target> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(t => t.Description)
            .HasMaxLength(300);

        builder.HasOne(t => t.Category)
            .WithMany()
            .HasForeignKey(t => t.CategoryId);
    }
}