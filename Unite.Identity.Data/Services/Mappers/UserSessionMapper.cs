using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class UserSessionMapper : IEntityTypeConfiguration<UserSession>
{
    public void Configure(EntityTypeBuilder<UserSession> entity)
    {
        entity.ToTable("UserSessions");

        entity.HasKey(userSession => new { userSession.UserId, userSession.Session });

        entity.Property(userSession => userSession.UserId)
              .IsRequired();

        entity.Property(userSession => userSession.Session)
              .IsRequired()
              .HasMaxLength(100);


        entity.HasOne(userSession => userSession.User)
              .WithMany(user => user.UserSessions)
              .HasForeignKey(userSession => userSession.UserId)
              .IsRequired();


        entity.HasIndex(userSession => userSession.Session);
    }
}
