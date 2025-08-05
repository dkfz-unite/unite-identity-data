using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class TokenMapper : IEntityTypeConfiguration<Token>
{
    public void Configure(EntityTypeBuilder<Token> entity)
    {
        entity.ToTable("Tokens");


        entity.HasKey(token => token.Id);

        entity.HasAlternateKey(token => token.Name);


        entity.Property(token => token.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        entity.Property(token => token.Key)
            .IsRequired();

        entity.HasIndex(token => token.Key)
            .IsUnique();

        entity.Property(token => token.Name)
            .IsRequired()
            .HasMaxLength(100);
    }
}
