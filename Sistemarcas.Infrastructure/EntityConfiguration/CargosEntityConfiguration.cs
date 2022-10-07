using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class CargosEntityConfiguration : IEntityTypeConfiguration<Cargos>
    {
        public void Configure(EntityTypeBuilder<Cargos> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasMaxLength(100);

            builder.ToTable("Cargos");
        }
    }
}
