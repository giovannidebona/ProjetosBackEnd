using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class EstudoViabilidadeMarcaItemEntityConfiguration : IEntityTypeConfiguration<Estudo_Viabilidade_Marcas_Itens>
    {
        public void Configure(EntityTypeBuilder<Estudo_Viabilidade_Marcas_Itens> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.EstudoViabilidadeMarca)
                .WithMany()
                .HasForeignKey(d => d.Estudo_viabilidade_marca_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.ClasseItem)
                .WithMany()
                .HasForeignKey(d => d.Classe_item_id)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Estudo_Viabilidade_Marcas_Itens");
        }
    }
}
