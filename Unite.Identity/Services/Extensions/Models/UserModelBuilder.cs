using Microsoft.EntityFrameworkCore;
using Unite.Identity.Entities;

namespace Unite.Identity.Services.Extensions.Models
{
    internal static class UserModelBuilder
    {
        internal static void BuildUserModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(user => user.Id);

                entity.HasAlternateKey(user => user.Email);

                entity.Property(user => user.Id)
                      .IsRequired()
                      .ValueGeneratedOnAdd();

                entity.Property(user => user.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(user => user.Password)
                      .IsRequired();
            });
        }
    }
}
