using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class ProviderMapper : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> entity)
    {
        entity.ToTable("Provider");

        entity.HasKey(provider => provider.Id);

        entity.HasAlternateKey(provider => provider.Name);

        entity.Property(provider => provider.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(provider => provider.Name)
              .IsRequired()
              .HasMaxLength(100);

        entity.Property(provider => provider.Label)
              .IsRequired()
              .HasMaxLength(100);

        entity.Property(provider => provider.IsActive)
              .IsRequired()
              .HasDefaultValue(false);


        entity.HasMany(provider => provider.Users)
              .WithOne(user => user.Provider)
              .IsRequired();
    }
}
