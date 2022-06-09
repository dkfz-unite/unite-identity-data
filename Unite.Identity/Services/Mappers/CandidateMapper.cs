using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Entities;

namespace Unite.Identity.Services.Mappers
{
    public class CandidateMapper : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> entity)
        {
            entity.ToTable("Candidates");

            entity.HasKey(candidate => candidate.Id);

            entity.HasAlternateKey(candidate => candidate.Email);

            entity.Property(candidate => candidate.Id)
                  .IsRequired()
                  .ValueGeneratedOnAdd();

            entity.Property(candidate => candidate.Email)
                  .IsRequired()
                  .HasMaxLength(100);
        }
    }
}
