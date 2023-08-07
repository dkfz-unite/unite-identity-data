using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Unite.Identity.Data.Entities;

namespace Unite.Identity.Data.Services.Mappers;

internal class WorkerMapper : IEntityTypeConfiguration<Worker>
{
    public void Configure(EntityTypeBuilder<Worker> entity)
    {
        entity.ToTable("Workers");


        entity.HasKey(worker => worker.Id);

        entity.HasAlternateKey(worker => worker.Name);


        entity.Property(worker => worker.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

        entity.Property(worker => worker.Name)
              .IsRequired()
              .HasMaxLength(100);
    }
}
