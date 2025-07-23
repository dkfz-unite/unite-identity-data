using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class WorkerTokenMapper : IEntityTypeConfiguration<WorkerToken>
{
      public void Configure(EntityTypeBuilder<WorkerToken> entity)
      {
            entity.ToTable("WorkerToken");

            entity.HasKey(token => token.Id);

            entity.HasAlternateKey(token => token.Value);

            entity.Property(token => token.Id)
                  .IsRequired()
                  .ValueGeneratedOnAdd();

            entity.Property(token => token.Value)
                  .IsRequired();

            entity.HasOne(workerToken => workerToken.Worker)
                  .WithMany(worker => worker.WorkerToken)
                  .HasForeignKey(workerToken => workerToken.WorkerId) 
                  .IsRequired();
      }
}
