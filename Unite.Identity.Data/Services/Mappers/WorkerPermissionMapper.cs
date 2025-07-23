using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Entities.Enums;
using Unite.Identity.Data.Services.Models;

namespace Unite.Identity.Data.Services.Mappers;

internal class WorkerPermissionMapper : IEntityTypeConfiguration<WorkerPermission>
{
    public void Configure(EntityTypeBuilder<WorkerPermission> entity)
    {
        entity.ToTable("WorkerPermissions");

        entity.HasKey(workerPermission => new { workerPermission.WorkerId, workerPermission.PermissionId });

        entity.Property(workerPermission => workerPermission.WorkerId)
              .IsRequired();

        entity.Property(workerPermission => workerPermission.PermissionId)
              .IsRequired()
              .HasConversion<int>();


        entity.HasOne<EnumValue<Permission>>()
              .WithMany()
              .HasForeignKey(workerPermission => workerPermission.PermissionId);

      //   entity.HasOne(workerPermission => workerPermission.Worker)
      //         .WithMany(worker => worker.WorkerPermissions)
      //         .HasForeignKey(workerPermission => workerPermission.WorkerId)
      //         .IsRequired();
    }
}
