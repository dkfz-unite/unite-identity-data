using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class UserSessionMapper : IEntityTypeConfiguration<UserSession>
{
    public void Configure(EntityTypeBuilder<UserSession> entity)
    {
        entity.ToTable("UserSessions");

        entity.HasKey(userSession => userSession.Id);

        entity.Property(userSession => userSession.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(userSession => userSession.UserId)
              .IsRequired()
              .ValueGeneratedNever();

        entity.Property(userSession => userSession.Session)
              .IsRequired()
              .HasMaxLength(100);

        entity.Property(userSession => userSession.Expires)
              .IsRequired()
              .HasDefaultValueSql("CURRENT_TIMESTAMP");


        entity.HasOne(userSession => userSession.User)
              .WithMany(user => user.UserSessions)
              .HasForeignKey(userSession => userSession.UserId)
              .IsRequired();


        entity.HasIndex(userSession => userSession.Session)
              .IsUnique();
    }
}
