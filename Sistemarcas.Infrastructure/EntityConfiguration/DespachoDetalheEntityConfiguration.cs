using Sistemarcas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistemarcas.Infrastructure.EntityConfiguration
{
    public class DespachoDetalheEntityConfiguration : IEntityTypeConfiguration<Despachos_Detalhes>
    {
        public void Configure(EntityTypeBuilder<Despachos_Detalhes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(c => c.Despacho)
                .WithMany()
                .HasForeignKey(d => d.Despachoid)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Processo)
               .WithMany()
               .HasForeignKey(d => d.Processoid)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.TipoDespacho)
               .WithMany()
               .HasForeignKey(d => d.Tipodespachoid)
               .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Despachos_Detalhes");
        }
    }
}