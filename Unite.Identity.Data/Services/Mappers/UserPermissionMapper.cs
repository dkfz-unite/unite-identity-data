﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;
using Unite.Identity.Data.Entities.Enums;
using Unite.Identity.Data.Services.Models;

namespace Unite.Identity.Data.Services.Mappers;

internal class UserPermissionMapper : IEntityTypeConfiguration<UserPermission>
{
    public void Configure(EntityTypeBuilder<UserPermission> entity)
    {
        entity.ToTable("UserPermissions");

        entity.HasKey(userPermission => new { userPermission.UserId, userPermission.PermissionId });

        entity.Property(userPermission => userPermission.UserId)
              .IsRequired();

        entity.Property(userPermission => userPermission.PermissionId)
              .IsRequired()
              .HasConversion<int>();


        entity.HasOne<EnumValue<Permission>>()
              .WithMany()
              .HasForeignKey(userPermission => userPermission.PermissionId);

        entity.HasOne(userPermission => userPermission.User)
              .WithMany(user => user.UserPermissions)
              .HasForeignKey(userPermission => userPermission.UserId)
              .IsRequired();
    }
}
