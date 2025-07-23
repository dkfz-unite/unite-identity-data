using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Entities.Enums;
using Unite.Identity.Data.Services.Models;

namespace Unite.Identity.Data.Services.Mappers;

internal class WorkerTokenPermissionMapper : IEntityTypeConfiguration<WorkerTokenPermission>
{
      public void Configure(EntityTypeBuilder<WorkerTokenPermission> entity)
      {
            entity.ToTable("WorkerTokenPermissions");

            entity.HasKey(tokenPermission => new { tokenPermission.TokenId, tokenPermission.PermissionId });

            entity.Property(tokenPermission => tokenPermission.TokenId)
                  .IsRequired();

            entity.Property(tokenPermission => tokenPermission.PermissionId)
                  .IsRequired()
                  .HasConversion<int>();

            entity.HasOne<EnumValue<Permission>>()
                  .WithMany()
                  .HasForeignKey(tokenPermission => tokenPermission.PermissionId);

            entity.HasOne(tokenPermission => tokenPermission.WorkerToken)
                  .WithMany(workerToken => workerToken.WorkerTokenPermission)
                  .HasForeignKey(tokenPermission => tokenPermission.TokenId) 
                  .IsRequired();
      }
}