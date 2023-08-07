using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class ServiceMapper : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> entity)
    {
        entity.ToTable("Services");


        entity.HasKey(service => service.Id);

        entity.HasAlternateKey(service => service.Name);


        entity.Property(service => service.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(service => service.Name)
              .IsRequired()
              .HasMaxLength(100);
    }
}
