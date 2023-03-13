using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class UserMapper : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> entity)
    {
        entity.ToTable("Users");

        entity.HasKey(user => user.Id);

        entity.HasAlternateKey(user => user.Email);

        entity.Property(user => user.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(user => user.Email)
              .IsRequired()
              .HasMaxLength(100);

        entity.Property(user => user.IsRoot)
              .IsRequired()
              .HasDefaultValue(false);

        entity.Property(user => user.IsRegistered)
              .IsRequired()
              .HasDefaultValue(false);
    }
}
