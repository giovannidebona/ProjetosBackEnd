using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class CorrespondenteEntityConfiguration : IEntityTypeConfiguration<Correspondentes>
    {
        public void Configure(EntityTypeBuilder<Correspondentes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(d => d.Pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Correspondentes");
        }
    }
}
