using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Entities.Enums;
using Unite.Identity.Data.Services.Models;

namespace Unite.Identity.Data.Services.Mappers;

internal class TokenPermissionMapper : IEntityTypeConfiguration<TokenPermission>
{
public void Configure(EntityTypeBuilder<TokenPermission> entity)
{
      entity.ToTable("TokenPermissions");

      entity.HasKey(tokenPermission => new { tokenPermission.TokenId, tokenPermission.PermissionId });

      entity.Property(tokenPermission => tokenPermission.TokenId)
            .IsRequired();

      entity.Property(tokenPermission => tokenPermission.PermissionId)
            .IsRequired()
            .HasConversion<int>();

      entity.HasOne<EnumValue<Permission>>()
            .WithMany()
            .HasForeignKey(tokenPermission => tokenPermission.PermissionId);

      entity.HasOne(tokenPermission => tokenPermission.Token)
            .WithMany(token => token.TokenPermissions)
            .HasForeignKey(tokenPermission => tokenPermission.TokenId)
            .IsRequired();
      }
}
