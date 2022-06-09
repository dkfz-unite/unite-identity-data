using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Entities;
using Unite.Identity.Entities.Enums;
using Unite.Identity.Services.Models;

namespace Unite.Identity.Services.Mappers
{
    public class CandidatePermissionMapper : IEntityTypeConfiguration<CandidatePermission>
    {
        public void Configure(EntityTypeBuilder<CandidatePermission> entity)
        {
            entity.ToTable("CandidatePermissions");

            entity.HasKey(candidatePermission => new { candidatePermission.CandidateId, candidatePermission.PermissionId });

            entity.Property(candidatePermission => candidatePermission.CandidateId)
                  .IsRequired();

            entity.Property(candidatePermission => candidatePermission.PermissionId)
                  .IsRequired()
                  .HasConversion<int>();


            entity.HasOne<EnumValue<Permission>>()
                  .WithMany()
                  .HasForeignKey(candidatePermission => candidatePermission.PermissionId);

            entity.HasOne(candidatePermission => candidatePermission.Candidate)
                  .WithMany(candidate => candidate.CandidatePermissions)
                  .HasForeignKey(candidatePermission => candidatePermission.CandidateId)
                  .IsRequired();
        }
    }
}
