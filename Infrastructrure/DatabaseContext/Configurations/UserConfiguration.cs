using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructrure.DatabaseContext.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        
        builder.HasIndex(u => u.Email)
            .IsUnique();

        builder.Property(u => u.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.PasswordHash)
            .IsRequired();
    }
}