using System;
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

        entity.Property(provider => provider.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(provider => provider.Name)
              .IsRequired()
              .HasMaxLength(100);

        entity.Property(provider => provider.Label)
              .HasMaxLength(100);

        entity.Property(provider => provider.IsActive)
              .IsRequired()
              .HasDefaultValue(false);

        entity.Property(provider => provider.Priority);

        entity.HasMany(provider => provider.Users)
              .WithOne(user => user.Provider)
              .IsRequired();
    }
}

