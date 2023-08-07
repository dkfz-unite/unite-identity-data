using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Entities.Enums;
using Unite.Identity.Data.Services.Models;

namespace Unite.Identity.Data.Services.Mappers;

internal class ServicePermissionMapper : IEntityTypeConfiguration<ServicePermission>
{
    public void Configure(EntityTypeBuilder<ServicePermission> entity)
    {
        entity.ToTable("ServicePermissions");

        entity.HasKey(servicePermission => new { servicePermission.ServiceId, servicePermission.PermissionId });

        entity.Property(servicePermission => servicePermission.ServiceId)
              .IsRequired();

        entity.Property(servicePermission => servicePermission.PermissionId)
              .IsRequired()
              .HasConversion<int>();


        entity.HasOne<EnumValue<Permission>>()
              .WithMany()
              .HasForeignKey(servicePermission => servicePermission.PermissionId);

        entity.HasOne(servicePermission => servicePermission.Service)
              .WithMany(service => service.ServicePermissions)
              .HasForeignKey(servicePermission => servicePermission.ServiceId)
              .IsRequired();
    }
}
