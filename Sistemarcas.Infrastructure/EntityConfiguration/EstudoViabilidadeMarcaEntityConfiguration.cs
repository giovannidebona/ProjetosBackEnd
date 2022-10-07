using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class EstudoViabilidadeMarcaEntityConfiguration : IEntityTypeConfiguration<Estudo_Viabilidade_Marcas>
    {
        public void Configure(EntityTypeBuilder<Estudo_Viabilidade_Marcas> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.EstudoViabilidade)
                .WithMany()
                .HasForeignKey(d => d.Estudo_viabilidade_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Estudo_Viabilidade_Marcas");
        }
    }
}
